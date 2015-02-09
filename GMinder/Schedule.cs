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

namespace ReflectiveCode.GMinder
{
    public class Schedule : IEnumerable<Calendar>
    {
        #region Schedule Singleton

        private static Schedule _Current = new Schedule();
        public static Schedule Current { get { return _Current; } }

        #endregion

        private Schedule() { }

        private List<Calendar> _Calendars = new List<Calendar>();

        public int Count { get { return _Calendars.Count; } }

        public void Add(Calendar calendar)
        {
            if (_Calendars.Contains(calendar))
                return;

            calendar.Schedule = this;
            _Calendars.Add(calendar);
            foreach (var gvent in calendar)
                NotifyChange(new GventEventArgs(gvent, GventChanges.Added));
        }

        public void Remove(Calendar calendar)
        {
            if (!_Calendars.Contains(calendar))
                return;

            calendar.Clear();
            _Calendars.Remove(calendar);
        }

        public bool Contains(Calendar calendar)
        {
            return _Calendars.Contains(calendar);
        }

        public void DownloadUpdates(int days)
        {
            if (!Properties.Settings.Default.DoPing || Network.PingTest())
            {
                foreach (var calendar in _Calendars.ToArray())
                    calendar.DownloadUpdates(days);
            }
            else
            {
                foreach (var calendar in _Calendars.ToArray())
                    calendar.DownloadError = true;
            }
        }

        public void ProcessUpdates()
        {
            OnBeginningUpdate(new EventArgs());
            foreach (var calendar in _Calendars.ToArray())
                calendar.ProcessUpdates();
            OnEndingUpdate(new EventArgs());
        }

        public void UpdateStatus(DateTime now, DateTime soon)
        {
            OnBeginningUpdate(new EventArgs());
            foreach (var calendar in _Calendars.ToArray())
                calendar.UpdateStatus(now, soon);
            OnEndingUpdate(new EventArgs());
        }

        public void Reset()
        {
            OnBeginningUpdate(new EventArgs());
            foreach (var calendar in _Calendars.ToArray())
                calendar.Clear();
            OnEndingUpdate(new EventArgs());
        }

        public void Redraw()
        {
            OnRedrawing(new EventArgs());
        }

        public void NotifyChange(GventEventArgs e)
        {
            switch (e.Changes)
            {
                case GventChanges.Added:
                    OnGventAdded(e);
                    break;
                case GventChanges.Deleted:
                    OnGventRemoved(e);
                    break;
                default:
                    OnGventChanged(e);
                    break;
            }
        }

        #region Events

        public event EventHandler Redrawing;
        public event EventHandler BeginningUpdate;
        public event EventHandler EndingUpdate;
        public event EventHandler<GventEventArgs> GventAdded;
        public event EventHandler<GventEventArgs> GventChanged;
        public event EventHandler<GventEventArgs> GventRemoved;

        protected virtual void OnRedrawing(EventArgs e)
        {
            if (Redrawing != null)
                Redrawing(this, e);
        }
        protected virtual void OnBeginningUpdate(EventArgs e)
        {
            if (BeginningUpdate != null)
                BeginningUpdate(this, e);
        }
        protected virtual void OnEndingUpdate(EventArgs e)
        {
            if (EndingUpdate != null)
                EndingUpdate(this, e);
        }
        protected virtual void OnGventAdded(GventEventArgs e)
        {
            if (GventAdded != null)
                GventAdded(this, e);
        }
        protected virtual void OnGventChanged(GventEventArgs e)
        {
            if (GventChanged != null)
                GventChanged(this, e);
        }
        protected virtual void OnGventRemoved(GventEventArgs e)
        {
            if (GventRemoved != null)
                GventRemoved(this, e);
        }

        #endregion

        #region Serialization

        public void Load()
        {
            Calendar[] calendars = null;
            try
            {
                calendars = Storage.LoadObject<Calendar[]>("calendar.xml");
            }
            catch (Exception e)
            {
                Logging.LogException(true, e, "Unable to load saved calendars and events");
            }

            if (calendars != null)
                foreach (var calendar in calendars)
                    Add(calendar);
        }

        public void Save()
        {
            try
            {
                Storage.SaveObject("calendar.xml", _Calendars.ToArray());
            }
            catch (Exception e)
            {
                Logging.LogException(true, e, "Unable to save calendars and events");
            }
        }

        #endregion

        #region Enumerator

        public IEnumerator<Calendar> GetEnumerator()
        {
            return _Calendars.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _Calendars.GetEnumerator();
        }

        #endregion
    }
}
