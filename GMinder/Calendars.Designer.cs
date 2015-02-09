namespace ReflectiveCode.GMinder
{
    partial class Calendars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendars));
            this.CalendarsFormTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.loginSettingsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.loginUsernameLabel = new System.Windows.Forms.Label();
            this.loginSetButton = new System.Windows.Forms.Button();
            this.calendarsGroupBox = new System.Windows.Forms.GroupBox();
            this.calendardsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.calendarNameLabel = new System.Windows.Forms.Label();
            this.calendarColorLabel = new System.Windows.Forms.Label();
            this.calendarUrlLabel = new System.Windows.Forms.Label();
            this.calendarsEditFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.calendarAddButton = new System.Windows.Forms.Button();
            this.calendarRemoveButton = new System.Windows.Forms.Button();
            this.calendarDownloadButton = new System.Windows.Forms.Button();
            this.calendarNameTextBox = new System.Windows.Forms.TextBox();
            this.calendarUrlTextBox = new System.Windows.Forms.TextBox();
            this.calendarList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.calendarColorBox = new ReflectiveCode.GMinder.Controls.ColorButton();
            this.okCancelFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.CalendarsFormTableLayoutPanel.SuspendLayout();
            this.loginGroupBox.SuspendLayout();
            this.loginSettingsFlowLayoutPanel.SuspendLayout();
            this.calendarsGroupBox.SuspendLayout();
            this.calendardsTableLayoutPanel.SuspendLayout();
            this.calendarsEditFlowLayoutPanel.SuspendLayout();
            this.okCancelFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalendarsFormTableLayoutPanel
            // 
            this.CalendarsFormTableLayoutPanel.ColumnCount = 1;
            this.CalendarsFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CalendarsFormTableLayoutPanel.Controls.Add(this.loginGroupBox, 0, 0);
            this.CalendarsFormTableLayoutPanel.Controls.Add(this.calendarsGroupBox, 0, 1);
            this.CalendarsFormTableLayoutPanel.Controls.Add(this.okCancelFlowLayoutPanel, 0, 2);
            this.CalendarsFormTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalendarsFormTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.CalendarsFormTableLayoutPanel.Name = "CalendarsFormTableLayoutPanel";
            this.CalendarsFormTableLayoutPanel.RowCount = 3;
            this.CalendarsFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CalendarsFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CalendarsFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CalendarsFormTableLayoutPanel.Size = new System.Drawing.Size(455, 354);
            this.CalendarsFormTableLayoutPanel.TabIndex = 0;
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.AutoSize = true;
            this.loginGroupBox.Controls.Add(this.loginSettingsFlowLayoutPanel);
            this.loginGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginGroupBox.Location = new System.Drawing.Point(3, 3);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(449, 61);
            this.loginGroupBox.TabIndex = 0;
            this.loginGroupBox.TabStop = false;
            this.loginGroupBox.Text = "Login";
            // 
            // loginSettingsFlowLayoutPanel
            // 
            this.loginSettingsFlowLayoutPanel.AutoSize = true;
            this.loginSettingsFlowLayoutPanel.Controls.Add(this.usernameLabel);
            this.loginSettingsFlowLayoutPanel.Controls.Add(this.loginUsernameLabel);
            this.loginSettingsFlowLayoutPanel.Controls.Add(this.loginSetButton);
            this.loginSettingsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginSettingsFlowLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.loginSettingsFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.loginSettingsFlowLayoutPanel.Name = "loginSettingsFlowLayoutPanel";
            this.loginSettingsFlowLayoutPanel.Size = new System.Drawing.Size(443, 42);
            this.loginSettingsFlowLayoutPanel.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(3, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            // 
            // loginUsernameLabel
            // 
            this.loginUsernameLabel.AutoSize = true;
            this.loginSettingsFlowLayoutPanel.SetFlowBreak(this.loginUsernameLabel, true);
            this.loginUsernameLabel.Location = new System.Drawing.Point(67, 0);
            this.loginUsernameLabel.Name = "loginUsernameLabel";
            this.loginUsernameLabel.Size = new System.Drawing.Size(53, 13);
            this.loginUsernameLabel.TabIndex = 1;
            this.loginUsernameLabel.Text = "username";
            // 
            // loginSetButton
            // 
            this.loginSetButton.Location = new System.Drawing.Point(3, 16);
            this.loginSetButton.Name = "loginSetButton";
            this.loginSetButton.Size = new System.Drawing.Size(75, 23);
            this.loginSetButton.TabIndex = 2;
            this.loginSetButton.Text = "Set";
            this.loginSetButton.UseVisualStyleBackColor = true;
            this.loginSetButton.Click += new System.EventHandler(this.loginSet_Click);
            // 
            // calendarsGroupBox
            // 
            this.calendarsGroupBox.Controls.Add(this.calendardsTableLayoutPanel);
            this.calendarsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarsGroupBox.Location = new System.Drawing.Point(3, 70);
            this.calendarsGroupBox.Name = "calendarsGroupBox";
            this.calendarsGroupBox.Size = new System.Drawing.Size(449, 252);
            this.calendarsGroupBox.TabIndex = 1;
            this.calendarsGroupBox.TabStop = false;
            this.calendarsGroupBox.Text = "Calendars";
            // 
            // calendardsTableLayoutPanel
            // 
            this.calendardsTableLayoutPanel.ColumnCount = 2;
            this.calendardsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.calendardsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.calendardsTableLayoutPanel.Controls.Add(this.calendarNameLabel, 0, 1);
            this.calendardsTableLayoutPanel.Controls.Add(this.calendarColorLabel, 0, 3);
            this.calendardsTableLayoutPanel.Controls.Add(this.calendarUrlLabel, 0, 2);
            this.calendardsTableLayoutPanel.Controls.Add(this.calendarsEditFlowLayoutPanel, 0, 4);
            this.calendardsTableLayoutPanel.Controls.Add(this.calendarNameTextBox, 1, 1);
            this.calendardsTableLayoutPanel.Controls.Add(this.calendarUrlTextBox, 1, 2);
            this.calendardsTableLayoutPanel.Controls.Add(this.calendarList, 0, 0);
            this.calendardsTableLayoutPanel.Controls.Add(this.calendarColorBox, 1, 3);
            this.calendardsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendardsTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.calendardsTableLayoutPanel.Name = "calendardsTableLayoutPanel";
            this.calendardsTableLayoutPanel.RowCount = 5;
            this.calendardsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.calendardsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.calendardsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.calendardsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.calendardsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.calendardsTableLayoutPanel.Size = new System.Drawing.Size(443, 233);
            this.calendardsTableLayoutPanel.TabIndex = 0;
            // 
            // calendarNameLabel
            // 
            this.calendarNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.calendarNameLabel.AutoSize = true;
            this.calendarNameLabel.Location = new System.Drawing.Point(3, 123);
            this.calendarNameLabel.Name = "calendarNameLabel";
            this.calendarNameLabel.Size = new System.Drawing.Size(35, 13);
            this.calendarNameLabel.TabIndex = 1;
            this.calendarNameLabel.Text = "Name";
            // 
            // calendarColorLabel
            // 
            this.calendarColorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.calendarColorLabel.AutoSize = true;
            this.calendarColorLabel.Location = new System.Drawing.Point(3, 177);
            this.calendarColorLabel.Name = "calendarColorLabel";
            this.calendarColorLabel.Size = new System.Drawing.Size(31, 13);
            this.calendarColorLabel.TabIndex = 5;
            this.calendarColorLabel.Text = "Color";
            // 
            // calendarUrlLabel
            // 
            this.calendarUrlLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.calendarUrlLabel.AutoSize = true;
            this.calendarUrlLabel.Location = new System.Drawing.Point(3, 149);
            this.calendarUrlLabel.Name = "calendarUrlLabel";
            this.calendarUrlLabel.Size = new System.Drawing.Size(20, 13);
            this.calendarUrlLabel.TabIndex = 3;
            this.calendarUrlLabel.Text = "Url";
            // 
            // calendarsEditFlowLayoutPanel
            // 
            this.calendarsEditFlowLayoutPanel.AutoSize = true;
            this.calendardsTableLayoutPanel.SetColumnSpan(this.calendarsEditFlowLayoutPanel, 2);
            this.calendarsEditFlowLayoutPanel.Controls.Add(this.calendarAddButton);
            this.calendarsEditFlowLayoutPanel.Controls.Add(this.calendarRemoveButton);
            this.calendarsEditFlowLayoutPanel.Controls.Add(this.calendarDownloadButton);
            this.calendarsEditFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.calendarsEditFlowLayoutPanel.Location = new System.Drawing.Point(3, 201);
            this.calendarsEditFlowLayoutPanel.Name = "calendarsEditFlowLayoutPanel";
            this.calendarsEditFlowLayoutPanel.Size = new System.Drawing.Size(437, 29);
            this.calendarsEditFlowLayoutPanel.TabIndex = 7;
            // 
            // calendarAddButton
            // 
            this.calendarAddButton.Location = new System.Drawing.Point(3, 3);
            this.calendarAddButton.Name = "calendarAddButton";
            this.calendarAddButton.Size = new System.Drawing.Size(84, 23);
            this.calendarAddButton.TabIndex = 0;
            this.calendarAddButton.Text = "Add";
            this.calendarAddButton.UseVisualStyleBackColor = true;
            this.calendarAddButton.Click += new System.EventHandler(this.calendarAdd_Click);
            // 
            // calendarRemoveButton
            // 
            this.calendarRemoveButton.Location = new System.Drawing.Point(93, 3);
            this.calendarRemoveButton.Name = "calendarRemoveButton";
            this.calendarRemoveButton.Size = new System.Drawing.Size(84, 23);
            this.calendarRemoveButton.TabIndex = 1;
            this.calendarRemoveButton.Text = "Remove";
            this.calendarRemoveButton.UseVisualStyleBackColor = true;
            this.calendarRemoveButton.Click += new System.EventHandler(this.calendarRemove_Click);
            // 
            // calendarDownloadButton
            // 
            this.calendarDownloadButton.Location = new System.Drawing.Point(183, 3);
            this.calendarDownloadButton.Name = "calendarDownloadButton";
            this.calendarDownloadButton.Size = new System.Drawing.Size(84, 23);
            this.calendarDownloadButton.TabIndex = 2;
            this.calendarDownloadButton.Text = "Download";
            this.calendarDownloadButton.UseVisualStyleBackColor = true;
            this.calendarDownloadButton.Click += new System.EventHandler(this.calendarDownload_Click);
            // 
            // calendarNameTextBox
            // 
            this.calendarNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendarNameTextBox.Location = new System.Drawing.Point(44, 120);
            this.calendarNameTextBox.Name = "calendarNameTextBox";
            this.calendarNameTextBox.Size = new System.Drawing.Size(396, 20);
            this.calendarNameTextBox.TabIndex = 2;
            this.calendarNameTextBox.TextChanged += new System.EventHandler(this.calendarName_TextChanged);
            // 
            // calendarUrlTextBox
            // 
            this.calendarUrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendarUrlTextBox.Location = new System.Drawing.Point(44, 146);
            this.calendarUrlTextBox.Name = "calendarUrlTextBox";
            this.calendarUrlTextBox.Size = new System.Drawing.Size(396, 20);
            this.calendarUrlTextBox.TabIndex = 4;
            this.calendarUrlTextBox.TextChanged += new System.EventHandler(this.calendarUrl_TextChanged);
            // 
            // calendarList
            // 
            this.calendarList.CheckBoxes = true;
            this.calendarList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.calendardsTableLayoutPanel.SetColumnSpan(this.calendarList, 2);
            this.calendarList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarList.FullRowSelect = true;
            this.calendarList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.calendarList.LabelWrap = false;
            this.calendarList.Location = new System.Drawing.Point(3, 3);
            this.calendarList.MultiSelect = false;
            this.calendarList.Name = "calendarList";
            this.calendarList.Size = new System.Drawing.Size(437, 111);
            this.calendarList.TabIndex = 0;
            this.calendarList.UseCompatibleStateImageBehavior = false;
            this.calendarList.View = System.Windows.Forms.View.Details;
            this.calendarList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.calendarList_ItemChecked);
            this.calendarList.SelectedIndexChanged += new System.EventHandler(this.calendarList_SelectedIndexChanged);
            this.calendarList.ClientSizeChanged += new System.EventHandler(this.calendarList_ClientSizeChanged);
            this.calendarList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calendarList_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Calendar";
            this.columnHeader1.Width = 145;
            // 
            // calendarColorBox
            // 
            this.calendarColorBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendarColorBox.BackColor = System.Drawing.Color.Black;
            this.calendarColorBox.Color = System.Drawing.Color.Black;
            this.calendarColorBox.ColorDialog = null;
            this.calendarColorBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.calendarColorBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.calendarColorBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendarColorBox.Location = new System.Drawing.Point(44, 172);
            this.calendarColorBox.Name = "calendarColorBox";
            this.calendarColorBox.Size = new System.Drawing.Size(396, 23);
            this.calendarColorBox.TabIndex = 6;
            this.calendarColorBox.UseVisualStyleBackColor = false;
            this.calendarColorBox.Click += new System.EventHandler(this.calendarColor_Click);
            // 
            // okCancelFlowLayoutPanel
            // 
            this.okCancelFlowLayoutPanel.AutoSize = true;
            this.okCancelFlowLayoutPanel.Controls.Add(this.cancelButton);
            this.okCancelFlowLayoutPanel.Controls.Add(this.okButton);
            this.okCancelFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.okCancelFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.okCancelFlowLayoutPanel.Location = new System.Drawing.Point(0, 325);
            this.okCancelFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.okCancelFlowLayoutPanel.Name = "okCancelFlowLayoutPanel";
            this.okCancelFlowLayoutPanel.Size = new System.Drawing.Size(455, 29);
            this.okCancelFlowLayoutPanel.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(377, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(296, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // Calendars
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(455, 354);
            this.Controls.Add(this.CalendarsFormTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calendars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendars";
            this.CalendarsFormTableLayoutPanel.ResumeLayout(false);
            this.CalendarsFormTableLayoutPanel.PerformLayout();
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.loginSettingsFlowLayoutPanel.ResumeLayout(false);
            this.loginSettingsFlowLayoutPanel.PerformLayout();
            this.calendarsGroupBox.ResumeLayout(false);
            this.calendardsTableLayoutPanel.ResumeLayout(false);
            this.calendardsTableLayoutPanel.PerformLayout();
            this.calendarsEditFlowLayoutPanel.ResumeLayout(false);
            this.okCancelFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CalendarsFormTableLayoutPanel;
        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.FlowLayoutPanel loginSettingsFlowLayoutPanel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label loginUsernameLabel;
        private System.Windows.Forms.Button loginSetButton;
        private System.Windows.Forms.GroupBox calendarsGroupBox;
        private System.Windows.Forms.FlowLayoutPanel okCancelFlowLayoutPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TableLayoutPanel calendardsTableLayoutPanel;
        private System.Windows.Forms.Label calendarNameLabel;
        private System.Windows.Forms.Label calendarColorLabel;
        private System.Windows.Forms.Label calendarUrlLabel;
        private System.Windows.Forms.FlowLayoutPanel calendarsEditFlowLayoutPanel;
        private System.Windows.Forms.Button calendarAddButton;
        private System.Windows.Forms.Button calendarRemoveButton;
        private System.Windows.Forms.Button calendarDownloadButton;
        private System.Windows.Forms.TextBox calendarNameTextBox;
        private System.Windows.Forms.TextBox calendarUrlTextBox;
        private System.Windows.Forms.ListView calendarList;
        private Controls.ColorButton calendarColorBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}