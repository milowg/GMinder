using Google.Apis.Calendar.v3.Data;
using System;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ReflectiveCode.GMinder
{
    public class GVentMinder 
    {
        #region Properties

        private Gvent _GVent;
        public Gvent Gvent
        {
            get { return _GVent; }
            set
            {
                if (_GVent == null)
                    _GVent = value;
                else throw new InvalidOperationException("A Gvent's owning Calendar cannot be changed");
            }
        }

        private TimeSpan _HowEarly;
        private bool _Done = false;
        public bool Done
        {
            get { return _Done; }
            set
            {
                if (_Done != value)
                {
                    _Done = value;
                    if (_Done && _GVent != null && _GVent.Status == GventStatus.Soon)
                    {
                        _GVent.Status = GventStatus.Future;
                        _GVent.Status = GventStatus.Soon;
                    }
                }
            }
        }

        public bool Processed { get; set; }

        #endregion

        public GVentMinder()
        {
        }

        public GVentMinder(EventReminder reminder)
        {
            if (reminder == null)
                throw new ArgumentNullException("entry");

            _HowEarly = TimeSpan.FromMinutes((double)reminder.Minutes);
        }

        public bool Update(EventReminder reminder)
        {
            if (_HowEarly != TimeSpan.FromMinutes((double)reminder.Minutes))
                return false;

            Processed = true;
            return true;
        }

        public void Update(DateTime nowTime)
        {
            if (Done)
                return;

            if (_GVent != null &&
                _GVent.Start - _HowEarly <= nowTime)
                Done = true;
            return;
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("Days", _HowEarly.Days.ToString());
            writer.WriteAttributeString("Hours", _HowEarly.Hours.ToString());
            writer.WriteAttributeString("Minutes", _HowEarly.Minutes.ToString());
            writer.WriteAttributeString("Done", _Done.ToString());
        }

        public void ReadXml(XmlReader reader)
        {
            int d = Int32.Parse(reader["Days"]);
            int h = Int32.Parse(reader["Hours"]);
            int m = Int32.Parse(reader["Minutes"]);
            _HowEarly = new TimeSpan(d, h, m, 0);
            _Done = bool.Parse(reader["Done"]);
            reader.Read();
        }
    }
}
