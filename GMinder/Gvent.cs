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

using Google.Apis.Calendar.v3.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;


namespace ReflectiveCode.GMinder
{
    public class Gvent : IComparable<Gvent>, IXmlSerializable
    {
        #region Properties

        public Calendar Calendar {get; private set; }

        private List<GVentMinder> _Minders = new List<GVentMinder>();

        private string _Id;
        public string Id { get { return _Id; } }

        private string _Title;
        public string Title
        {
            get { return _Title; }
            set
            {
                if (_Title != value)
                {
                    _Title = value;
                    NotifyChange(new GventEventArgs(this, GventChanges.Title));
                }
            }
        }

        private string _Location;
        public string Location
        {
            get { return _Location; }
            set
            {
                if (_Location != value)
                {
                    _Location = value;
                    NotifyChange(new GventEventArgs(this, GventChanges.Location));
                }
            }
        }

        private DateTime _Start;
        public DateTime Start
        {
            get { return _Start; }
            set
            {
                if (_Start != value)
                {
                    _Start = value;
                    NotifyChange(new GventEventArgs(this, GventChanges.Start));
                    foreach (var minder in _Minders)
                    {
                        minder.Done = false;
                    }
                }
            }
        }

        private DateTime _Stop;
        public DateTime Stop
        {
            get { return _Stop; }
            set
            {
                if (_Stop != value)
                {
                    _Stop = value;
                    NotifyChange(new GventEventArgs(this, GventChanges.Stop));
                }
            }
        }

        private string _Url;
        public string Url
        {
            get { return _Url; }
            set
            {
                if (_Url != value)
                {
                    _Url = value;
                    NotifyChange(new GventEventArgs(this, GventChanges.Url));
                }
            }
        }

        private GventStatus _Status;
        public GventStatus Status
        {
            get { return _Status; }
            set
            {
                if (_Status != value)
                {
                    _Status = value;
                    NotifyChange(new GventEventArgs(this, GventChanges.Status));
                }
            }
        }

        public bool Processed { get; set; }

        public TimeSpan Length { get { return Stop - Start; } }

        public bool AllDay
        {
            get
            {
                var length = Length;

                var days = length.TotalDays;
                var hours = length.Hours;
                var minutes = length.Minutes;

                return ((days > 0) && (hours == 0) && (minutes == 0));
            }
        }

        public string LengthString
        {
            get
            {
                TimeSpan length = Length;

                int days = (int)Math.Floor(length.TotalDays);
                int hours = length.Hours;
                int minutes = length.Minutes;

                if (AllDay && days == 1)
                    return "All day";

                StringBuilder result = new StringBuilder();

                if (days > 0)
                {
                    result.Append(days);
                    if (days > 1)
                        result.Append(" days");
                    else
                        result.Append(" day");
                }

                if (hours > 0)
                {
                    if (result.Length > 0)
                        result.Append(" ");
                    result.Append(hours);
                    result.Append(" hr");
                }

                if (minutes > 0)
                {
                    if (result.Length > 0)
                        result.Append(" ");
                    result.Append(minutes);
                    result.Append(" min");
                }

                return result.ToString();
            }
        }

        #endregion

        public Gvent(Event entry, Calendar calendar)
        {
            if (entry == null)
                throw new ArgumentNullException("entry");

            _Id = entry.HtmlLink;
            this.Calendar = calendar;
            Update(entry);
        }

        public void Add(GVentMinder minder)
        {
            if (_Minders.Contains(minder))
                return;

            minder.Gvent = this;
            _Minders.Add(minder);
            minder.Processed = true;
            NotifyChange(new GventEventArgs(this, GventChanges.AddedReminder));
        }

        public void Remove(GVentMinder minder)
        {
            if (!_Minders.Contains(minder))
                return;

            _Minders.Remove(minder);
            NotifyChange(new GventEventArgs(this, GventChanges.DeletedReminder));
        }

        public bool Update(Event entry)
        {
            if (entry.HtmlLink != Id)
                return false;

            Title = entry.Summary;
            Url = entry.HtmlLink;

            // Location
            Location = entry.Location;

            // Times

            if (entry.Start.DateTime == null)
            {
                Start = DateTime.Parse(entry.Start.Date);
            }
            else
            {
                Start = entry.Start.DateTime ?? new DateTime();
            }

            if (entry.End.DateTime == null)
            {
                Stop = DateTime.Parse(entry.End.Date);
            }
            else
            {
                Stop = entry.End.DateTime ?? new DateTime();
            }            

            foreach (var gminder in _Minders)
                gminder.Processed = false;
            
            IList<EventReminder> reminders = null;
            if (entry.Reminders != null)
            {
                if (entry.Reminders.UseDefault == true)
                {
                    reminders = this.Calendar.DefaultReminders;
                }
                else
                {
                    reminders = entry.Reminders.Overrides;
                }
            }

            if (reminders != null)
            {
                foreach (var reminder in reminders)
                {
                    if (reminder.Method == GReminder.REMINDER_TYPE_POPUP)
                    {
                        bool matched = false;

                        foreach (var minder in _Minders)
                        {
                            matched = minder.Update(reminder);
                            if (matched)
                                break;
                        }

                        if (!matched)
                            Add(new GVentMinder(reminder));
                    }
                }
            }

            foreach (var minder in _Minders.ToArray())
            {
                if (!minder.Processed)
                    Remove(minder);
            }

            Processed = true;
            return true;
        }

        public void Update(DateTime nowTime, DateTime soonTime)
        {
            if (Status == GventStatus.Dismissed)
                return;

            if (nowTime < Start)
            {
                if (_Minders.Count == 0)
                {
                    if (soonTime < Start)
                        Status = GventStatus.Future;
                    else
                        Status = GventStatus.Soon;
                }
                else
                {
                    bool isSoon = false;
                    foreach (var minder in _Minders)
                    {
                        minder.Update(nowTime);
                        isSoon = isSoon || minder.Done;
                    }

                    if (isSoon)
                        Status = GventStatus.Soon;
                    else
                        Status = GventStatus.Future;
                }
            }
            else if (nowTime < Stop)
                Status = GventStatus.Now;
            else
                Status = GventStatus.Past;
        }

        public void OpenBrowser()
        {
            if (!String.IsNullOrEmpty(Url))
            {
                try
                {
                    System.Diagnostics.Process.Start(Url);
                }
                catch (Exception e)
                {
                    Logging.LogException(false, e,
                        "Error opening event in browser",
                        String.Format("Event: {0}", Title),
                        String.Format("Url: {0}", Url));
                }
            }
        }

        public void Dismiss()
        {
            Status = GventStatus.Dismissed;
        }

        public int CompareTo(Gvent other)
        {
            if (this.Start > other.Start)
                return 1;
            if (this.Start < other.Start)
                return -1;
            if (!this.AllDay && other.AllDay)
                return 1;
            if (this.AllDay && !other.AllDay)
                return -1;
            return this.Id.CompareTo(other.Id);
        }

        private void NotifyChange(GventEventArgs e)
        {
            if (Calendar != null && Calendar.Schedule != null)
                Calendar.Schedule.NotifyChange(e);
        }

        #region Serialization

        public Gvent(Calendar calendar) 
        {
            this.Calendar = calendar;
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            if (reader.MoveToContent() == XmlNodeType.Element && reader.LocalName == "Event")
            {
                _Id = reader["Id"];
                _Title = reader["Title"];
                _Location = reader["Location"];
                _Start = DateTime.FromBinary(Int64.Parse(reader["Start"]));
                _Stop = DateTime.FromBinary(Int64.Parse(reader["Stop"]));
                _Url = reader["Url"];
                _Status = (GventStatus)Int32.Parse(reader["Status"]);                

                if (reader.ReadToDescendant("Reminder"))
                {
                    while ((reader.MoveToContent() == XmlNodeType.Element) && (reader.LocalName == "Reminder"))
                    {
                        var minder = new GVentMinder();
                        minder.ReadXml(reader);
                        Add(minder);
                    }
                }

                reader.Read();
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("Id", _Id);
            writer.WriteAttributeString("Title", _Title);
            writer.WriteAttributeString("Location", _Location);
            writer.WriteAttributeString("Start", _Start.ToBinary().ToString());
            writer.WriteAttributeString("Stop", _Stop.ToBinary().ToString());
            writer.WriteAttributeString("Url", _Url);
            writer.WriteAttributeString("Status", ((int)_Status).ToString());

            foreach (var reminder in _Minders)
            {
                writer.WriteStartElement("Reminder");
                reminder.WriteXml(writer);
                writer.WriteEndElement();
            }
        }

        #endregion
    }

    public enum GventStatus
    {
        Future,
        Soon,
        Now,
        Past,
        Dismissed
    }
}