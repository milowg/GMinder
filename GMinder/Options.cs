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
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ReflectiveCode.GMinder
{
    public partial class Options : Form
    {
        public Options()
        {            
            InitializeComponent();         
        }

        private string GetDefaultSoundPath()
        {
            var win7_path = "C:\\Windows\\Media\\Windows Print Complete.wav";
            var xp_path = "C:\\WINDOWS\\Media\\Windows XP Print complete.wav";

            if (File.Exists(win7_path))
                return win7_path;
            if (File.Exists(xp_path))
                return xp_path;

            return "";

        }

        private void Options_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
                Properties.Settings.Default.Save();
            else
                Properties.Settings.Default.Reload();
        }

        private void soundPlay_Click(object sender, EventArgs e)
        {
            Sound.MakeSound(soundBrowseButton.FileName);
        }

        private void Options_Shown(object sender, EventArgs e)
        {
            if (this.soundPathTextBox.Text.Equals("First Run"))
                Properties.Settings.Default.SoundPath = GetDefaultSoundPath();
        }

        private void startAtLogin_CheckedChanged(object sender, EventArgs e)
        {
            AutoStarter.IsAutoStartEnabled = this.startAtLoginCheckBox.Checked;

            this.startAtLoginCheckBox.Checked = AutoStarter.IsAutoStartEnabled;
        }
    }
}