/// Copyright (c) 2009, Greg Todd
/// All rights reserved.
///
/// Redistribution and use in source and binary forms, with or without modification,
/// are permitted provided that the following conditions are met:
/// 
/// * Redistributions of source code must retain the above copyright notice,
///   this list of conditions and the following disclaimer.
///   
/// * Redistributions in binary form must reproduce the above copyright notice,
///   this list of conditions and the following disclaimer in the documentation
///   and/or other materials provided with the distribution.
///   
/// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
/// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
/// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
/// IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT,
/// INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING,
/// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
/// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
/// LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE
/// OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED
/// OF THE POSSIBILITY OF SUCH DAMAGE.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Google.Apis.Calendar.v3;
using Google.Apis.Auth.OAuth2;
using System.Threading;
using Google.Apis.Util.Store;
using Google.Apis.Services;
using Google.Apis.Calendar.v3.Data;

namespace ReflectiveCode.GMinder
{
    public class Calendar : IEnumerable<Gvent>, IXmlSerializable
    {
        #region Calendar Service (static)

        private const string CALENDAR_URL = "http://www.google.com/calendar/feeds/default/allcalendars/full";

        public static event EventHandler StartingAuth;
        public static event EventHandler EndingAuth;
        private static CalendarService _Service;

        public static bool SetUserCredentials(bool force)
        {
            try
            {
                OnStartingAuth();

                var fileDataStore = new FileDataStore("GMinder.Auth.Store");
                if (force)
                {
                    Properties.Settings.Default.LoggedIn = false;
                    Properties.Settings.Default.Save();

                    fileDataStore.ClearAsync().Wait();
                }

                UserCredential credential;
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GMinderClientSecrets.getSecret(),
                    new[] { CalendarService.Scope.Calendar },
                    "user",
                    CancellationToken.None,
                    fileDataStore).Result;

                _Service = new CalendarService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "GMinder",
                });

                Properties.Settings.Default.LoggedIn = true;
                Properties.Settings.Default.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Can not access your Google Calendar account. Make sure you accept when asked to authorize GMinder.",
                    "Can't access Google Calendar account",
                    System.Windows.Forms.MessageBoxButtons.OK
                );

                Logging.LogException(false, e, "Unknown Error: " + e.Message);
            }
            finally
            {
                OnEndingAuth();
            }
            return true;
        }

        public static IEnumerable<Calendar> DownloadCalendars()
        {
            IList<CalendarListEntry> calendars = null;

            if (!Properties.Settings.Default.LoggedIn)
            {
                MessageBox.Show(
                    "You must first click on the Login button to allow GMinder access to your Google Calendar",
                    "Login First",
                    System.Windows.Forms.MessageBoxButtons.OK
                );
            }
            else
            {                
                try
                {
                    calendars = _Service.CalendarList.List().Execute().Items;
                }
                catch (Exception e)
                {
                    Logging.LogException(true, e,
                        "Error downloading calendars",
                        "Did you Accept GMinder's access to your Google Calendar account?",
                        "Are you connected to the internet?"
                    );
                }
            }

            if (calendars != null)
            {
                foreach (var entry in calendars)
                    yield return new Calendar(entry);
            }
        }

        #endregion

        #region Properties

        private IList<Event> _fetchedEvents = new List<Event>();
        private List<Gvent> _Gvents = new List<Gvent>();

        public IList<EventReminder> DefaultReminders { get; private set; }

        private Schedule _Schedule;
        public Schedule Schedule
        {
            get { return _Schedule; }
            set
            {
                if (_Schedule == null)
                    _Schedule = value;
                else throw new InvalidOperationException("A Calendar's owning Schedule cannot be changed");
            }
        }

        public string Name { get; set; }
        public string ID { get; set; }

        private Color _Color;
        public Color Color
        {
            get { return _Color; }
            set
            {
                if (_Color != value)
                {
                    _Color = value;
                    foreach (var gvent in _Gvents.ToArray())
                        NotifyChange(new GventEventArgs(gvent, GventChanges.Color));
                }
            }
        }

        private bool _Enabled;
        public bool Enabled
        {
            get { return _Enabled; }
            set
            {
                _Enabled = value;
                if (!_Enabled)
                    Clear();
            }
        }

        public bool DownloadError { get; set; }

        #endregion

        private Calendar(CalendarListEntry entry)
        {
            if (entry == null)
                throw new ArgumentNullException("entry");

            Name = entry.Summary;
            ID = entry.Id;
            Enabled = entry.Selected ?? false;
            this.DefaultReminders = entry.DefaultReminders;
            if (this.DefaultReminders == null)
            {
                this.DefaultReminders = new List<EventReminder>();
            }
            SetColor(entry.ColorId);
        }

        private void SetColor(string colorId)
        {
            ColorDefinition colorDef = _Service.Colors.Get().Execute().Calendar[colorId];
            String color = colorDef.Background;
            int r = Int32.Parse(color.Substring(1, 2), System.Globalization.NumberStyles.HexNumber);
            int g = Int32.Parse(color.Substring(3, 2), System.Globalization.NumberStyles.HexNumber);
            int b = Int32.Parse(color.Substring(5, 2), System.Globalization.NumberStyles.HexNumber);
            Color = Color.FromArgb(r, g, b);

        }

        public void Create(String eventQuickAdd)
        {
            _Service.Events.QuickAdd(this.ID, eventQuickAdd).Execute();
        }

        public void Add(Gvent gvent)
        {
            if (_Gvents.Contains(gvent))
                return;

            _Gvents.Add(gvent);
            NotifyChange(new GventEventArgs(gvent, GventChanges.Added));
        }

        public void Remove(Gvent gvent)
        {
            if (!_Gvents.Contains(gvent))
                return;

            _Gvents.Remove(gvent);
            NotifyChange(new GventEventArgs(gvent, GventChanges.Deleted));
        }

        private void FetchEvents(EventsResource.ListRequest fetcher) {
            var exec = fetcher.Execute();
            foreach (var item in exec.Items) {
                _fetchedEvents.Add(item);
            }
            if (exec.NextPageToken != null)
            {
                fetcher.PageToken = exec.NextPageToken;
                FetchEvents(fetcher);
            }

        }

        public void DownloadUpdates(int days)
        {
            if (Enabled && !String.IsNullOrEmpty(this.ID))
            {
                //Update Calendar details
                try
                {
                    CalendarListEntry calendarEntry = _Service.CalendarList.Get(this.ID).Execute();
                    this.DefaultReminders = calendarEntry.DefaultReminders;
                }
                catch (Exception e)
                {
                    Logging.LogException(false, e);
                    //Do nothing. Use the defaults we already have
                }

                EventsResource.ListRequest Fetcher = _Service.Events.List(this.ID);
                Fetcher.SingleEvents = true;
                Fetcher.TimeMin = DateTime.Today;
                Fetcher.TimeMax = DateTime.Today.AddDays(days);
                
                // Download Events (First Try)
                try
                {
                    FetchEvents(Fetcher);
                    DownloadError = false;
                    return;
                }
                catch (Exception e)
                {
                    Logging.LogException(false, e,
                        String.Format("Error downloading events in Calendar.DownloadGvents({0})", days),
                        String.Format("Calendar: {0}", Name),
                        ID,
                        "The program will try once more");
                }

                // Download Events (Second Try)
                try
                {
                    FetchEvents(Fetcher);
                    DownloadError = false;
                    return;
                }
                catch (Exception e)
                {
                    Logging.LogException(false, e, "Skipping this calendar");
                    DownloadError = true;
                }
            }
        }

        public void ProcessUpdates()
        {
            if (Enabled)
            {
                // Reset the flag on all events
                foreach (var gvent in _Gvents)
                    gvent.Processed = false;

                // Merge the updates with existing events
                foreach (var entry in _fetchedEvents)
                {
                    bool matched = false;

                    // Update existing event
                    foreach (var gvent in _Gvents)
                    {
                        matched = gvent.Update(entry);
                        if (matched)
                            break;
                    }

                    // Insert new event
                    if (!matched)
                        Add(new Gvent(entry, this));
                }

                if (!DownloadError)
                {
                    // Remove events that were not updated
                    foreach (var gvent in _Gvents.ToArray())
                        if (!gvent.Processed && gvent.Start > DateTime.Today)
                            Remove(gvent);
                }
            }
        }

        public void UpdateStatus(DateTime now, DateTime soon)
        {
            foreach (Gvent gvent in _Gvents.ToArray())
                gvent.Update(now, soon);
        }

        public void Clear()
        {
            foreach (var gvent in _Gvents.ToArray())
                Remove(gvent);
            _Gvents.Clear();
        }

        private void NotifyChange(GventEventArgs e)
        {
            if (Schedule != null)
                Schedule.NotifyChange(e);
        }

        public override string ToString()
        {
            return Name;
        }


        #region Enumerator

        public IEnumerator<Gvent> GetEnumerator()
        {
            return _Gvents.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _Gvents.GetEnumerator();
        }

        #endregion

        #region Serialization

        public Calendar() { }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            if ((reader.MoveToContent() == XmlNodeType.Element) && (reader.LocalName == "Calendar"))
            {
                Name = reader["Name"];
                ID = reader["Url"];
                Enabled = Boolean.Parse(reader["Enabled"]);
                Color = Color.FromArgb(Int32.Parse(reader["Color"]));
                
                if (reader.ReadToDescendant("Event"))
                {
                    while ((reader.MoveToContent() == XmlNodeType.Element) && (reader.LocalName == "Event"))
                    {
                        var gvent = new Gvent(this);
                        gvent.ReadXml(reader);
                        Add(gvent);
                    }
                }

                this.DefaultReminders = new List<EventReminder>();
                while ((reader.MoveToContent() == XmlNodeType.Element) && (reader.LocalName == "DefaultReminder"))
                {
                    int minutes;
                    EventReminder defaultReminder = new EventReminder() { 
                        Method = reader["Method"],
                        Minutes = (Int32.TryParse(reader["Minutes"], out minutes) ? minutes : (int?)null)
                    };
                    this.DefaultReminders.Add(defaultReminder);
                    reader.Read();
                }

                reader.Read();
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("Name", Name);
            writer.WriteAttributeString("Url", ID);
            writer.WriteAttributeString("Enabled", _Enabled.ToString());
            writer.WriteAttributeString("Color", _Color.ToArgb().ToString());

            foreach (var gvent in _Gvents)
            {
                writer.WriteStartElement("Event");
                gvent.WriteXml(writer);
                writer.WriteEndElement();
            }
            foreach (var reminder in this.DefaultReminders)
            {
                writer.WriteStartElement("DefaultReminder");
                writer.WriteAttributeString("Method", reminder.Method);
                writer.WriteAttributeString("Minutes", reminder.Minutes.ToString());
                writer.WriteEndElement();

            }
        }

        #endregion

        #region Events
        protected static void OnStartingAuth()
        {
            if (StartingAuth != null)
                StartingAuth(null, null);
        }

        protected static void OnEndingAuth()
        {
            if (EndingAuth != null)
                EndingAuth(null, null);
        }
        #endregion
    }
}