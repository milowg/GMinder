using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ReflectiveCode.GMinder.Controls
{
    public class Agenda : ListView
    {
        private ColumnHeader _WhatColumn = new ColumnHeader();
        private ColumnHeader _WhenColumn = new ColumnHeader();
        private Dictionary<string, ListViewGroup> _Groups = new Dictionary<string, ListViewGroup>();
        private Dictionary<DateTime, ListViewItem> _Headers = new Dictionary<DateTime, ListViewItem>();
        private Dictionary<Gvent, ListViewItem> _Gvents = new Dictionary<Gvent, ListViewItem>();

        delegate void BeginUpdateCallback();
        delegate void EndUpdateCallback();

        public Agenda()
        {
            _WhatColumn.Text = "What";
            _WhatColumn.TextAlign = HorizontalAlignment.Left;

            _WhenColumn.Text = "When";
            _WhenColumn.TextAlign = HorizontalAlignment.Right;

            Columns.AddRange(new ColumnHeader[] { _WhatColumn, _WhenColumn });

            FullRowSelect = true;
            HeaderStyle = ColumnHeaderStyle.None;
            HideSelection = false;
            MultiSelect = false;
            View = View.Details;
            ListViewItemSorter = new AgendaComparer();
            ForeColor = Color.Black;

            Schedule.Current.Redrawing += (sender, e) => Reset();
            Schedule.Current.BeginningUpdate += (sender, e) => SafeBeginUpdate();
            Schedule.Current.EndingUpdate += (sender, e) => SafeEndUpdate();
            Schedule.Current.GventAdded += (sender, e) => Add(e.Gvent);
            Schedule.Current.GventRemoved += (sender, e) => Remove(e.Gvent);
            Schedule.Current.GventChanged += (sender, e) => UpdateGvent(e.Gvent, e.Changes);

            Reset();
        }

        /// <summary>
        /// Add a new gvent to the agenda list
        /// </summary>
        /// <param name="gvent">gvent to add</param>
        public void Add(Gvent gvent)
        {
            if (gvent.Status == GventStatus.Dismissed)
                return;

            // Create a new Item for the gvent
            var item = new ListViewItem();
            _Gvents.Add(gvent, item);
            item.Tag = gvent;

            // Set the item's text and color
            ItemUpdate(item);

            // Add the item to the list
            Add(item);
        }

        /// <summary>
        /// Adds an item to the list,
        /// along with an appropriate header and group
        /// </summary>
        /// <param name="item">item to add</param>
        private void Add(ListViewItem item)
        {
            var gvent = GetGventFromItem(item);

            // Get matching header
            var header = GetHeader(gvent.Start);

            // Add the item into the list
            item.Group = header.Group;
            Items.Add(item);
        }

        private ListViewItem GetHeader(DateTime time)
        {
            // Get existing header
            ListViewItem header = null;
            if (_Headers.ContainsKey(time.Date))
                header = _Headers[time.Date];

            // Create new header if needed
            if (header == null)
            {
                // Create item
                header = new ListViewItem();
                _Headers.Add(time.Date, header);
                header.Tag = time.Date;

                // Set item appearance
                header.Text = time.DayOfWeek.ToString();
                header.SubItems.Add(time.ToString("m"));
                header.Font = new Font(header.Font, FontStyle.Bold);

                // Set group
                header.Group = GetGroup(time);

                // Add header to list
                Items.Add(header);
            }

            return header;
        }

        private ListViewGroup GetGroup(DateTime time)
        {
            // Determine the text to use on the group
            string text = GetGroupText(time);

            // Get existing group
            ListViewGroup group = null;
            if (_Groups.ContainsKey(text))
                group = _Groups[text];

            // Create new group, if needed
            if (group == null)
            {
                // Declare a new group
                group = new ListViewGroup();
                _Groups.Add(text, group);
                group.Tag = time;
                group.Header = text;


                // Insert group in the correct order
                int index = 0;
                while (index < Groups.Count)
                {
                    DateTime other = (DateTime)Groups[index].Tag;
                    if (other > time)
                        break;
                    index++;
                }
                Groups.Insert(index, group);
            }

            return group;
        }

        private void Remove(ListViewItem item)
        {
            if (item != null)
            {
                bool selected = item.Selected;

                // Remove the header if the item is alone on that day

                int index = Items.IndexOf(item);
                if (index > 0 && IsHeader(Items[index - 1]))
                {
                    if (index + 1 >= Items.Count || IsHeader(Items[index + 1]))
                    {
                        RemoveHeader(Items[index - 1]);
                    }
                }

                // Remove the Item

                item.Group = null;
                Items.Remove(item);

                // Select the next Gvent in the agenda

                while (selected && index < Items.Count)
                {
                    if (IsGvent(Items[index]))
                    {
                        Items[index].Selected = true;
                        Items[index].EnsureVisible();
                        break;
                    }
                    index++;
                }
            }
        }

        private void Remove(Gvent gvent)
        {
            if (_Gvents.ContainsKey(gvent))
            {
                ListViewItem item = _Gvents[gvent];

                Remove(item);
                item.Tag = null;
                _Gvents.Remove(gvent);
            }
        }

        private void RemoveHeader(ListViewItem item)
        {
            if (IsHeader(item))
            {
                _Headers.Remove(GetDateFromItem(item));
                item.Group = null;
                item.Tag = null;
                Items.Remove(item);
            }
        }

        private static bool IsGvent(ListViewItem item)
        {
            if (item != null && item.Tag != null && item.Tag is Gvent)
                return true;
            else
                return false;
        }

        private static bool IsHeader(ListViewItem item)
        {
            if (item != null && item.Tag != null && item.Tag is DateTime)
                return true;
            else
                return false;
        }

        private static Gvent GetGventFromItem(ListViewItem item)
        {
            if (IsGvent(item))
                return item.Tag as Gvent;
            else
                return null;
        }

        private static DateTime GetDateFromItem(ListViewItem item)
        {
            if (IsHeader(item))
                return (DateTime)item.Tag;
            else
                return default(DateTime);
        }

        public void Reset()
        {
            BeginUpdate();

            // Remove old contents

            Items.Clear();
            Groups.Clear();

            foreach (ListViewItem item in _Gvents.Values)
            {
                item.Tag = null;
                item.Group = null;
            }

            foreach (ListViewItem item in _Headers.Values)
            {
                item.Tag = null;
                item.Group = null;
            }

            foreach (ListViewGroup group in _Groups.Values)
                group.Tag = null;

            _Gvents.Clear();
            _Headers.Clear();
            _Groups.Clear();

            // Insert new contents
            foreach (var calendar in Schedule.Current)
                foreach (var gvent in calendar)
                    Add(gvent);

            //Sort();
            EndUpdate();
        }

        private void UpdateGvent(Gvent gvent, GventChanges change)
        {
            switch (change)
            {
                case GventChanges.Start:
                case GventChanges.Stop:
                    if (_Gvents.ContainsKey(gvent))
                    {
                        ListViewItem item = _Gvents[gvent];
                        Remove(item);
                        Add(item);
                    }
                    return;

                case GventChanges.Color:
                case GventChanges.Title:
                    if (_Gvents.ContainsKey(gvent))
                        ItemUpdate(_Gvents[gvent]);
                    return;

                case GventChanges.Status:
                    if (gvent.Status == GventStatus.Dismissed)
                        Remove(gvent);
                    else if (_Gvents.ContainsKey(gvent))
                        ItemUpdate(_Gvents[gvent]);
                    return;
            }
        }

        private static void ItemUpdate(ListViewItem item)
        {
            if (IsGvent(item))
            {
                Gvent gvent = item.Tag as Gvent;

                item.Text = gvent.Title;

                string time;
                if (!gvent.AllDay)
                {
                    time = gvent.Start.ToString("t");
                }
                else
                    time = gvent.LengthString;

                if (item.SubItems.Count > 1)
                    item.SubItems[1].Text = time;
                else
                    item.SubItems.Add(time);
                item.ForeColor = gvent.Calendar.Color;

                switch (gvent.Status)
                {
                    case GventStatus.Future:
                        item.BackColor = Properties.Settings.Default.FutureColor;
                        break;
                    case GventStatus.Soon:
                        item.BackColor = Properties.Settings.Default.SoonColor;
                        break;
                    case GventStatus.Now:
                        item.BackColor = Properties.Settings.Default.NowColor;
                        break;
                    case GventStatus.Past:
                        item.BackColor = Properties.Settings.Default.PastColor;
                        break;
                }
            }
        }

        private static string GetGroupText(DateTime time)
        {
            int days = ((TimeSpan)(time.Date - DateTime.Today)).Days;
            int weeks = (days + (int)DateTime.Today.DayOfWeek) / 7;
            int months = (time.Year * 12 + time.Month) - (DateTime.Today.Year * 12 + DateTime.Today.Month);

            if (days < 0)
                return "Past";
            if (days == 0)
                return "Today";
            if (days == 1)
                return "Tomorrow";
            if (weeks == 0)
                return String.Format("{0} Days", days);
            if (weeks == 1)
                return "Next Week";
            if (months == 0)
                return String.Format("{0} Weeks", weeks);
            if (months == 1)
                return String.Format("Next Month");

            return String.Format("{0} Months", months);
        }

        public Gvent Selected
        {
            get
            {
                if (SelectedItems.Count > 0 && IsGvent(SelectedItems[0]))
                    return GetGventFromItem(SelectedItems[0]);
                else return null;
            }
        }


        #region Threadsafe Agenda Access

        public void SafeBeginUpdate()
        {
            if (this.InvokeRequired)
            {
                BeginUpdateCallback d = new BeginUpdateCallback(SafeBeginUpdate);
                this.Invoke(d);
            }
            else
            {
                this.BeginUpdate();
            }
        }

        public void SafeEndUpdate()
        {
            if (this.InvokeRequired)
            {
                EndUpdateCallback d = new EndUpdateCallback(SafeEndUpdate);
                this.Invoke(d);
            }
            else
            {
                this.EndUpdate();
            }
        }

        #endregion


        #region Events

        public event EventHandler SelectedChanged;

        protected virtual void OnSelectedChanged(EventArgs e)
        {
            if (SelectedChanged != null)
                SelectedChanged(this, e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            BeginUpdate();
            int width = ClientSize.Width;
            _WhatColumn.Width = (int)(width * 0.7);
            _WhenColumn.Width = (int)(width * 0.3);
            EndUpdate();
            base.OnSizeChanged(e);
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            OnSelectedChanged(new EventArgs());
            base.OnSelectedIndexChanged(e);
        }

        protected override void OnItemActivate(EventArgs e)
        {
            if (Selected != null)
                Selected.OpenBrowser();

            base.OnItemActivate(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (Selected != null)
                if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                    Selected.Dismiss();
            base.OnKeyDown(e);
        }

        #endregion
    }
}
