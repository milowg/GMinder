using ReflectiveCode.GMinder.Controls;

namespace ReflectiveCode.GMinder
{
    partial class Preview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preview));
            this.agenda = new Agenda();
            this.SuspendLayout();
            // 
            // agenda
            // 
            this.agenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.agenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agenda.ForeColor = System.Drawing.Color.Black;
            this.agenda.FullRowSelect = true;
            this.agenda.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.agenda.HideSelection = false;
            this.agenda.Location = new System.Drawing.Point(0, 0);
            this.agenda.MultiSelect = false;
            this.agenda.Name = "agenda";
            this.agenda.Size = new System.Drawing.Size(242, 192);
            this.agenda.TabIndex = 0;
            this.agenda.UseCompatibleStateImageBehavior = false;
            this.agenda.View = System.Windows.Forms.View.Details;
            // 
            // Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 192);
            this.ControlBox = false;
            this.Controls.Add(this.agenda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Preview";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private Agenda agenda;
    }
}