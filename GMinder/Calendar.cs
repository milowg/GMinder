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
using Google.GData.Calendar;
using Google.GData.Client;

namespace ReflectiveCode.GMinder
{
    public class Calendar: IEnumerable<Gvent>, IXmlSerializable
    {
        #region Calendar Service (static)

        private const string CALENDAR_URL = "http://www.google.com/calendar/feeds/default/allcalendars/full";

        private static CalendarService _Service = new CalendarService("GMinder");

        public static bool SetUserCredentials(string username, string password)
        {
            _Service.setUserCredentials(username, password);

            var proxy = WebRequest.GetSystemWebProxy();
            proxy.Credentials = CredentialCache.DefaultCredentials;
            (_Service.RequestFactory as GDataRequestFactory).Proxy = proxy;

            try
            {
                _Service.QueryAuthenticationToken();
                return true;
            }
            catch (CaptchaRequiredException)
            {
                var dialogResult = MessageBox.Show(
                    "Your account appears to be locked. This can happen when too many failed login attempts are made. You will need to answer a CAPTCHA to unlock your account. Press OK to visit https://www.google.com/accounts/DisplayUnlockCaptcha with your browser. Return to GMinder and reenter your password once you complete the CAPTCHA.",
                    "Unlock Your Account",
                    System.Windows.Forms.MessageBoxButtons.OK
                );
                if (dialogResult == DialogResult.OK)
                {
                    try
                    {
                        System.Diagnostics.Process.Start("https://www.google.com/accounts/DisplayUnlockCaptcha");
                    }
                    catch (Exception e2)
                    {
                        Logging.LogException(true, e2,
                            "Error opening CAPTCHA in browser",
                            "Url: https://www.google.com/accounts/DisplayUnlockCaptcha"
                        );
                    }
                }
            }
            catch (InvalidCredentialsException e)
            {
                Logging.LogException(true, e,
                    "Invalid username and password.",
                    "Please enter your full email address",
                    "(for your gmail or Google Apps account)",
                    "and verify your password."
                );
            }
            catch (AuthenticationException e)
            {
                Logging.LogException(true, e, "Unknown Authentication Error");
            }
            return false;
        }

        public static IEnumerable<Calendar> DownloadCalendars()
        {
            var query = new CalendarQuery(CALENDAR_URL);
            var fetcher = new DownloadHelper<CalendarEntry>(_Service);

            try
            {
                fetcher.Download(query);
            }
            catch (Exception e)
            {
                Logging.LogException(true, e,
                    "Error downloading calendars",
                    "Did you enter your username and password correctly?",
                    "Are you connected to the internet?"
                );
            }

            foreach (var entry in fetcher.Results)
                yield return new Calendar(entry);
        }

        #endregion

        #region Properties

        private DownloadHelper<EventEntry> _Fetcher = new DownloadHelper<EventEntry>(_Service);
        private List<Gvent> _Gvents = new List<Gvent>();

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
        public string Url { get; set; }

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

        private Calendar(CalendarEntry entry)
        {
            if (entry == null)
                throw new ArgumentNullException("entry");

            Name = entry.Title.Text;
            Url = entry.Content.AbsoluteUri;
            Enabled = entry.Selected;

            string color = entry.Color;
            int r = Int32.Parse(color.Substring(1, 2), System.Globalization.NumberStyles.HexNumber);
            int g = Int32.Parse(color.Substring(3, 2), System.Globalization.NumberStyles.HexNumber);
            int b = Int32.Parse(color.Substring(5, 2), System.Globalization.NumberStyles.HexNumber);
            Color = Color.FromArgb(r, g, b);
        }

        public void Create(EventEntry entry)
        {
            Add(new Gvent(_Service.Insert(new Uri(Url), entry)));
        }

        public void Add(Gvent gvent)
        {
            if (_Gvents.Contains(gvent))
                return;

            gvent.Calendar = this;
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

        public void DownloadUpdates(int days)
        {
            if (Enabled && !String.IsNullOrEmpty(Url))
            {
                // Download events
                var query = new EventQuery(Url)
                {
                    SingleEvents = true,
                    StartTime = DateTime.Today,
                    EndTime = DateTime.Today.AddDays(days)
                };

                // Download Events (First Try)
                try
                {
                    _Fetcher.Download(query);
                    DownloadError = false;
                    return;
                }
                catch (Exception e)
                {
                    Logging.LogException(false, e,
                        String.Format("Error downloading events in Calendar.DownloadGvents({0})", days),
                        String.Format("Calendar: {0}", Name),
                        Url,
                        "The program will try once more");
                }

                // Download Events (Second Try)
                try
                {
                    _Fetcher.Download(query);
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
                foreach (var entry in _Fetcher.Results)
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
                        Add(new Gvent(entry));
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
                Url = reader["Url"];
                Enabled = Boolean.Parse(reader["Enabled"]);
                Color = Color.FromArgb(Int32.Parse(reader["Color"]));

                if (reader.ReadToDescendant("Event"))
                {
                    while ((reader.MoveToContent() == XmlNodeType.Element) && (reader.LocalName == "Event"))
                    {
                        var gvent = new Gvent();
                        gvent.ReadXml(reader);
                        Add(gvent);
                    }
                }
                reader.Read();
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("Name", Name);
            writer.WriteAttributeString("Url", Url);
            writer.WriteAttributeString("Enabled", _Enabled.ToString());
            writer.WriteAttributeString("Color", _Color.ToArgb().ToString());

            foreach (var gvent in _Gvents)
            {
                writer.WriteStartElement("Event");
                gvent.WriteXml(writer);
                writer.WriteEndElement();
            }
        }

        #endregion
    }
}