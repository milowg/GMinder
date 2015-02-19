namespace ReflectiveCode.GMinder
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.aboutTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.linkOldest = new System.Windows.Forms.LinkLabel();
            this.linkOlder = new System.Windows.Forms.LinkLabel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.linkLatest = new System.Windows.Forms.LinkLabel();
            this.aboutTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // aboutTableLayoutPanel
            // 
            this.aboutTableLayoutPanel.ColumnCount = 2;
            this.aboutTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.aboutTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.aboutTableLayoutPanel.Controls.Add(this.linkOldest, 1, 4);
            this.aboutTableLayoutPanel.Controls.Add(this.linkOlder, 1, 3);
            this.aboutTableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.aboutTableLayoutPanel.Controls.Add(this.productNameLabel, 1, 0);
            this.aboutTableLayoutPanel.Controls.Add(this.versionLabel, 1, 1);
            this.aboutTableLayoutPanel.Controls.Add(this.okButton, 1, 6);
            this.aboutTableLayoutPanel.Controls.Add(this.linkLatest, 1, 2);
            this.aboutTableLayoutPanel.Controls.Add(this.descriptionTextBox, 1, 5);
            this.aboutTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutTableLayoutPanel.Location = new System.Drawing.Point(9, 9);
            this.aboutTableLayoutPanel.Name = "aboutTableLayoutPanel";
            this.aboutTableLayoutPanel.RowCount = 7;
            this.aboutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.aboutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.aboutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.aboutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.aboutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.aboutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.aboutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.aboutTableLayoutPanel.Size = new System.Drawing.Size(481, 185);
            this.aboutTableLayoutPanel.TabIndex = 0;
            // 
            // linkOldest
            // 
            this.linkOldest.AutoSize = true;
            this.linkOldest.Location = new System.Drawing.Point(161, 80);
            this.linkOldest.Name = "linkOldest";
            this.linkOldest.Size = new System.Drawing.Size(170, 13);
            this.linkOldest.TabIndex = 27;
            this.linkOldest.TabStop = true;
            this.linkOldest.Text = "http://reflectivecode.com/gminder";
            // 
            // linkOlder
            // 
            this.linkOlder.AutoSize = true;
            this.linkOlder.Location = new System.Drawing.Point(161, 60);
            this.linkOlder.Name = "linkOlder";
            this.linkOlder.Size = new System.Drawing.Size(178, 13);
            this.linkOlder.TabIndex = 26;
            this.linkOlder.TabStop = true;
            this.linkOlder.Text = "https://code.google.com/p/gminder";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.InitialImage")));
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.aboutTableLayoutPanel.SetRowSpan(this.logoPictureBox, 7);
            this.logoPictureBox.Size = new System.Drawing.Size(152, 179);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // productNameLabel
            // 
            this.productNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productNameLabel.Location = new System.Drawing.Point(164, 0);
            this.productNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.productNameLabel.MaximumSize = new System.Drawing.Size(0, 17);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(314, 17);
            this.productNameLabel.TabIndex = 19;
            this.productNameLabel.Text = "Product Name";
            this.productNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // versionLabel
            // 
            this.versionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.versionLabel.Location = new System.Drawing.Point(164, 20);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.versionLabel.MaximumSize = new System.Drawing.Size(0, 17);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(314, 17);
            this.versionLabel.TabIndex = 0;
            this.versionLabel.Text = "Version";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionTextBox.Location = new System.Drawing.Point(164, 103);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.descriptionTextBox.Size = new System.Drawing.Size(314, 44);
            this.descriptionTextBox.TabIndex = 23;
            this.descriptionTextBox.TabStop = false;
            this.descriptionTextBox.Text = "Description";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(403, 159);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            // 
            // linkLatest
            // 
            this.linkLatest.AutoSize = true;
            this.linkLatest.Location = new System.Drawing.Point(161, 40);
            this.linkLatest.Name = "linkLatest";
            this.linkLatest.Size = new System.Drawing.Size(221, 13);
            this.linkLatest.TabIndex = 25;
            this.linkLatest.TabStop = true;
            this.linkLatest.Text = "http://milow.net/public/projects/gminder.html";
            // 
            // About
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 203);
            this.Controls.Add(this.aboutTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.aboutTableLayoutPanel.ResumeLayout(false);
            this.aboutTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel aboutTableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.LinkLabel linkLatest;
        private System.Windows.Forms.LinkLabel linkOldest;
        private System.Windows.Forms.LinkLabel linkOlder;
    }
}
