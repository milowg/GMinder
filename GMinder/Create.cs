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

/// Special thanks to Dan at http://rowdypixel.com
/// for offering some code to get this started

using Google.Apis.Calendar.v3.Data;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ReflectiveCode.GMinder
{
    public partial class Create : PositionalForm
    {
        const char ENTER_KEYCHAR = (char)13;
        const char ESCAPE_KEYCHAR = (char)27;
        
        public Create() : base(null, "CreateWindowLocation")
        {
            InitializeComponent();

            foreach (var cal in Schedule.Current)
            {
                calendarList.Items.Add(cal);
                if (cal.Name == Properties.Settings.Default.LastQuickAdd)
                {
                    calendarList.SelectedItem = cal;
                    break;
                }
            }
            
            if (calendarList.Items.Count > 0 && calendarList.SelectedIndex < 0)
            {
                calendarList.SelectedIndex = 0;
            }
        }

        private void HandleKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ENTER_KEYCHAR)
                addButton.PerformClick();
            if (e.KeyChar == ESCAPE_KEYCHAR)
                Close();
        }

        private void HandleAddButton(object sender, EventArgs e)
        {
            var calendar = calendarList.SelectedItem as Calendar;
            if (calendar == null)
                return;
            
            try
            {
                Properties.Settings.Default.LastQuickAdd = calendar.Name;
                Properties.Settings.Default.Save();

                String quickTxt = String.Format("{0} {1}", newEventNameTextBox.Text, (dtPicker.Checked ? dtPicker.Value.ToShortDateString() : ""));
                calendar.Create(quickTxt);
                Close();
            }
            catch (Exception ex)
            {
                Logging.LogException(true, ex,
                    "Error adding event.",
                    "You may not have permission to edit the selected calendar."
                );
            }
        }

        private void calendarList_DrawItem(object sender, DrawItemEventArgs e)
        {
            Calendar calendar = (Calendar)((ComboBox)sender).Items[e.Index];
            string text = calendar.ToString();
            
            //Draw background first
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected &&
                !((e.State & DrawItemState.ComboBoxEdit) == DrawItemState.ComboBoxEdit))
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(calendarList.BackColor), e.Bounds);
            }

            //Next draw text
            Brush brush = new SolidBrush(calendar.Color);
            e.Graphics.DrawString(text, ((Control)sender).Font, brush, e.Bounds.X, e.Bounds.Y);
        }

    }
}