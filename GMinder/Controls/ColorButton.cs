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
using System.Drawing;
using System.Windows.Forms;

namespace ReflectiveCode.GMinder.Controls
{
    public class ColorButton : Button
    {
        [Category("Behavior")]
        [Browsable(true)]
        private ColorDialog colorDialog;
        public ColorDialog ColorDialog
        {
            get { return colorDialog; }
            set { colorDialog = value; }
        }

        [Category("Data")]
        [Browsable(true)]
        public Color Color
        {
            get { return this.BackColor; }
            set
            {
                this.BackColor = value;
                this.FlatAppearance.MouseDownBackColor = value;
                this.FlatAppearance.MouseOverBackColor = value;
            }
        }

        protected override void OnClick(EventArgs e)
        {
            ShowDialog();
            base.OnClick(e);
        }

        public DialogResult ShowDialog()
        {
            if (ColorDialog == null)
                ColorDialog = new ColorDialog();

            ColorDialog.Color = Color;
            DialogResult result = ColorDialog.ShowDialog(this);
            if (result == DialogResult.OK)
                Color = ColorDialog.Color;

            return result;
        }
    }
}