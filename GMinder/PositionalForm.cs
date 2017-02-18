using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReflectiveCode.GMinder
{
    /// <summary>
    /// Form that remembers its previous location and (optionally) size
    /// </summary>
    public class PositionalForm : Form
    {
        private String _windowSizeSetting = null;
        private String _windowLocationSetting = null;
        private bool _locationLoaded = false;

        //Default constructor for use in Form Designer
        public PositionalForm() { }

        //Requires settings properties to remember and save last position
        public PositionalForm(String windowSizeSetting, String windowLocationSetting)
        {
            _windowLocationSetting = windowLocationSetting;
            _windowSizeSetting = windowSizeSetting;
        }

        #region Saving and Loading
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //Load Window Location
            if (_windowLocationSetting != null && Properties.Settings.Default[_windowLocationSetting] != null)
            {
                this.Location = (Point)Properties.Settings.Default[_windowLocationSetting];
                EnsureVisible();
            }

            //Check Window Size settings if we need to
            if (_windowSizeSetting != null)
            {
                if (Properties.Settings.Default[_windowSizeSetting] != null)
                {
                    this.Size = (Size)Properties.Settings.Default[_windowSizeSetting];
                    //Set minimum size
                    if (this.Size.Width < 10 || this.Size.Height < 10)
                    {
                        this.Size = new System.Drawing.Size(
                            Math.Max(this.Size.Width, 10),
                            Math.Max(this.Size.Height, 10));
                    }
                }
            }
            _locationLoaded = true;

        }

        private void EnsureVisible()
        {
            foreach (var screen in Screen.AllScreens)
            {
                if (screen.Bounds.IntersectsWith(this.Bounds))
                {
                    return;
                }
            }
            //If we got this far we are not on a visible screen, so we show at 0,0
            this.Location = new System.Drawing.Point(0, 0);
        }

        private void SaveWindowLocation()
        {
            if (!_locationLoaded)
            {
                return;
            }

            // Copy window location to app settings
            Properties.Settings.Default[_windowLocationSetting] = this.Location;

            if (_windowSizeSetting != null)
            {
                // Copy window size to app settings
                if (this.WindowState == FormWindowState.Normal)
                {
                    Properties.Settings.Default[_windowSizeSetting] = this.Size;
                }
                else
                {
                    Properties.Settings.Default[_windowSizeSetting] = this.RestoreBounds.Size;
                }
            }

            // Save settings
            Properties.Settings.Default.Save();
        }
        #endregion

        #region Events
        protected override void OnMove(EventArgs e)
        {
            base.OnMove(e);
            SaveWindowLocation();
        }

        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);
            SaveWindowLocation();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            SaveWindowLocation();
        }
        #endregion
    }
}
