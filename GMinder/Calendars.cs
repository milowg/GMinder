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
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ReflectiveCode.GMinder
{
    public partial class Calendars : Form
    {
        private List<Calendar> calendars = new List<Calendar>();

        private Dictionary<Calendar, string> calendarNames = new Dictionary<Calendar, string>();
        private Dictionary<Calendar, string> calendarUrls = new Dictionary<Calendar, string>();
        private Dictionary<Calendar, Color> calendarColors = new Dictionary<Calendar, Color>();
        private Dictionary<Calendar, bool> calendarActive = new Dictionary<Calendar, bool>();

        public Calendars()
        {
            InitializeComponent();

            loginUsernameLabel.Text = Properties.Login.Default.Username;

            columnHeader1.Width = calendarList.ClientSize.Width;

            LoadCalendars();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            // Update and remove existing calendars

            foreach (var calendar in new List<Calendar>(Schedule.Current))
            {
                if (calendars.Contains(calendar))
                {
                    calendar.Name = calendarNames[calendar];
                    calendar.Url = calendarUrls[calendar];
                    calendar.Color = calendarColors[calendar];
                    calendar.Enabled = calendarActive[calendar];
                }
                else
                {
                    Schedule.Current.Remove(calendar);
                }
            }

            // Add new calendars

            foreach (Calendar calendar in calendars)
            {
                if (!Schedule.Current.Contains(calendar))
                {
                    calendar.Name = calendarNames[calendar];
                    calendar.Url = calendarUrls[calendar];
                    calendar.Color = calendarColors[calendar];
                    calendar.Enabled = calendarActive[calendar];
                    Schedule.Current.Add(calendar);
                }
            }

            Schedule.Current.Save();
        }


        #region Login

        private void loginSet_Click(object sender, EventArgs e)
        {
            Account login = new Account();
            login.ShowDialog(this);
            login.Dispose();
            loginUsernameLabel.Text = Properties.Login.Default.Username;
        }

        #endregion


        #region Calendars

        private void LoadCalendars()
        {
            calendarList.BeginUpdate();

            foreach (Calendar calendar in Schedule.Current)
            {
                calendars.Add(calendar);

                calendarNames.Add(calendar, calendar.Name);
                calendarUrls.Add(calendar, calendar.Url);
                calendarColors.Add(calendar, calendar.Color);
                calendarActive.Add(calendar, calendar.Enabled);

                AddItemFromCalendar(calendar);
            }

            calendarList.EndUpdate();
        }

        private void DownloadCalendars()
        {
            calendarDownloadButton.Text = "Downloading";
            calendarDownloadButton.Enabled = false;

            foreach (var newCal in Calendar.DownloadCalendars())
            {
                bool isNew = true;

                foreach (Calendar oldCal in calendars)
                {
                    if (newCal.Url == calendarUrls[oldCal])
                    {
                        isNew = false;
                        break;
                    }
                }

                if (isNew)
                {
                    calendars.Add(newCal);

                    calendarNames.Add(newCal, newCal.Name);
                    calendarUrls.Add(newCal, newCal.Url);
                    calendarColors.Add(newCal, newCal.Color);
                    calendarActive.Add(newCal, newCal.Enabled);

                    AddItemFromCalendar(newCal);
                }
            }

            calendarDownloadButton.Text = "Download";
            calendarDownloadButton.Enabled = true;
        }

        private ListViewItem GetSelectedItem()
        {
            if (calendarList.SelectedItems.Count > 0)
                return calendarList.SelectedItems[0];
            else
                return null;
        }

        private Calendar GetSelectedCalendar()
        {
            return GetCalendarFromItem(GetSelectedItem());
        }

        private static Calendar GetCalendarFromItem(ListViewItem item)
        {
            if (item != null)
                return item.Tag as Calendar;
            else
                return null;
        }

        private void UpdateFieldsFromCalendar(Calendar calendar)
        {
            if (calendar != null)
            {
                calendarNameTextBox.Text = calendarNames[calendar];
                calendarUrlTextBox.Text = calendarUrls[calendar];
                calendarColorBox.Color = calendarColors[calendar];
            }
            else
            {
                calendarNameTextBox.Text = string.Empty;
                calendarUrlTextBox.Text = string.Empty;
                calendarColorBox.Color = Color.Black;
            }
        }

        private void UpdateItemFromFields(ListViewItem item)
        {
            Calendar calendar = GetCalendarFromItem(item);
            if (calendar != null)
            {
                calendarNames[calendar] = calendarNameTextBox.Text;
                calendarUrls[calendar] = calendarUrlTextBox.Text;
                calendarColors[calendar] = calendarColorBox.Color;
                UpdateItemFromCalendar(item);
            }
        }

        private void UpdateItemFromCalendar(ListViewItem item)
        {
            Calendar calendar = GetCalendarFromItem(item);
            if (calendar != null)
            {
                item.Text = calendarNames[calendar];
                item.ForeColor = calendarColors[calendar];
                item.Checked = calendarActive[calendar];
            }
        }

        private void AddItemFromFields()
        {
            Calendar calendar = new Calendar();

            calendars.Add(calendar);
            calendarNames.Add(calendar, calendarNameTextBox.Text);
            calendarUrls.Add(calendar, calendarUrlTextBox.Text);
            calendarColors.Add(calendar, calendarColorBox.Color);
            calendarActive.Add(calendar, true);

            AddItemFromCalendar(calendar);
        }

        private void AddItemFromCalendar(Calendar calendar)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = calendar;
            UpdateItemFromCalendar(item);
            calendarList.Items.Add(item);
        }

        private void RemoveItem(ListViewItem item)
        {
            if (item != null)
            {
                Calendar calendar = GetCalendarFromItem(item);
                if (calendar != null)
                {
                    calendars.Remove(calendar);
                    calendarNames.Remove(calendar);
                    calendarUrls.Remove(calendar);
                    calendarColors.Remove(calendar);
                    calendarActive.Remove(calendar);
                }
                calendarList.Items.Remove(item);
            }
        }


        #region Events

        private void calendarAdd_Click(object sender, EventArgs e)
        {
            AddItemFromFields();
        }

        private void calendarDownload_Click(object sender, EventArgs e)
        {
            DownloadCalendars();
        }

        private void calendarRemove_Click(object sender, EventArgs e)
        {
            RemoveItem(GetSelectedItem());
        }

        private void calendarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFieldsFromCalendar(GetSelectedCalendar());
        }

        private void calendarList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (calendarList.Focused)
            {
                Calendar calendar = GetCalendarFromItem(e.Item);
                if (calendar != null)
                {
                    calendarActive[calendar] = e.Item.Checked;
                    UpdateItemFromCalendar(e.Item);
                }
            }
        }

        private void calendarName_TextChanged(object sender, EventArgs e)
        {
            if (calendarNameTextBox.Focused)
                UpdateItemFromFields(GetSelectedItem());
        }

        private void calendarUrl_TextChanged(object sender, EventArgs e)
        {
            if (calendarUrlTextBox.Focused)
                UpdateItemFromFields(GetSelectedItem());
        }

        private void calendarColor_Click(object sender, EventArgs e)
        {
            UpdateItemFromFields(GetSelectedItem());
        }

        private void calendarList_ClientSizeChanged(object sender, EventArgs e)
        {
            calendarList.BeginUpdate();
            columnHeader1.Width = calendarList.ClientSize.Width;
            calendarList.EndUpdate();
        }

        private void calendarList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                if (GetSelectedItem() != null)
                {
                    RemoveItem(GetSelectedItem());
                }
            }
            base.OnKeyDown(e);
        }        

        #endregion


        #endregion

    }
}