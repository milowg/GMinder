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
using System.ComponentModel;
using System.Windows.Forms;

namespace ReflectiveCode.GMinder.Controls
{
    public class OpenFileButton : Button
    {
        private string fileName;
        [Category("Data")]
        [Browsable(true)]
        [Description("Selected filename (including path)")]
        public string FileName
        {
            get 
            {
                if (TextBox == null)
                    return fileName;
                else
                    return TextBox.Text;
            }
            set
            {
                fileName = value;
                if (TextBox != null)
                    TextBox.Text = value;
            }
        }
	
        private TextBox fileNameTextBox;
        [Category("Behavior")]
        [Browsable(true)]
        [Description("Synchronize the selected filename with a textbox (optional)")]
        public TextBox TextBox
        {
            get { return fileNameTextBox; }
            set { fileNameTextBox = value; }
        }

        private OpenFileDialog openFileDialog;
        [Category("Behavior")]
        [Browsable(true)]
        [Description("Use a specific OpenFileDialog to choose a file upon click (optional)")]
        public OpenFileDialog OpenFileDialog
        {
            get { return openFileDialog; }
            set { openFileDialog = value; }
        }

        protected override void OnClick(EventArgs e)
        {
            ShowDialog();
            base.OnClick(e);
        }

        /// <summary>
        /// Presents the user with an OpenFileDialog
        /// </summary>
        public virtual DialogResult ShowDialog()
        {
            if (OpenFileDialog == null)
                OpenFileDialog = new OpenFileDialog();

            OpenFileDialog.FileName = FileName;

            DialogResult result = OpenFileDialog.ShowDialog(this);
            if (result == DialogResult.OK)
                FileName = OpenFileDialog.FileName;

            return result;
        }
    }
}