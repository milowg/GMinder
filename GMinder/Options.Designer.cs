namespace ReflectiveCode.GMinder
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.refreshRateLabel = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.PreloadDaysLabel = new System.Windows.Forms.Label();
            this.soonColorDialog = new System.Windows.Forms.ColorDialog();
            this.eventsSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.eventSettingsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SoonAlertOptionsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.soonPopupCheckBox = new System.Windows.Forms.CheckBox();
            this.soonSoundCheckBox = new System.Windows.Forms.CheckBox();
            this.soonVerbalCheckBox = new System.Windows.Forms.CheckBox();
            this.soonTimeInteger = new ReflectiveCode.GMinder.Controls.IntegerUpDown();
            this.soonMinutesLabel = new System.Windows.Forms.Label();
            this.futureEventsColorButton = new ReflectiveCode.GMinder.Controls.ColorButton();
            this.FutureEventsLabel = new System.Windows.Forms.Label();
            this.SoonEventsLabel = new System.Windows.Forms.Label();
            this.NowEventsLabel = new System.Windows.Forms.Label();
            this.PastEventsLabel = new System.Windows.Forms.Label();
            this.NowAlertOptionsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.nowPopupCheckBox = new System.Windows.Forms.CheckBox();
            this.nowSoundCheckBox = new System.Windows.Forms.CheckBox();
            this.nowVerbalCheckBox = new System.Windows.Forms.CheckBox();
            this.pastDismissOptionFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pastDismissCheckBox = new System.Windows.Forms.CheckBox();
            this.SoonEventsColorButton = new ReflectiveCode.GMinder.Controls.ColorButton();
            this.nowEventsColorButton = new ReflectiveCode.GMinder.Controls.ColorButton();
            this.pastEventsColorButton = new ReflectiveCode.GMinder.Controls.ColorButton();
            this.soundSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.soundSettingsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.soundPlayButton = new System.Windows.Forms.Button();
            this.soundBrowseButton = new ReflectiveCode.GMinder.Controls.OpenFileButton();
            this.openSoundFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.soundPathTextBox = new System.Windows.Forms.TextBox();
            this.agendaSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.agendaSettingsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.refreshRateInteger = new ReflectiveCode.GMinder.Controls.IntegerUpDown();
            this.preloadDaysInteger = new ReflectiveCode.GMinder.Controls.IntegerUpDown();
            this.doPingCheckBox = new System.Windows.Forms.CheckBox();
            this.onTopCheckBox = new System.Windows.Forms.CheckBox();
            this.startAtLoginCheckBox = new System.Windows.Forms.CheckBox();
            this.optionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.okCancelFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.eventsSettingsGroupBox.SuspendLayout();
            this.eventSettingsTableLayoutPanel.SuspendLayout();
            this.SoonAlertOptionsFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soonTimeInteger)).BeginInit();
            this.NowAlertOptionsFlowLayoutPanel.SuspendLayout();
            this.pastDismissOptionFlowLayoutPanel.SuspendLayout();
            this.soundSettingsGroupBox.SuspendLayout();
            this.soundSettingsTableLayoutPanel.SuspendLayout();
            this.agendaSettingsGroupBox.SuspendLayout();
            this.agendaSettingsFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshRateInteger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preloadDaysInteger)).BeginInit();
            this.optionsTableLayoutPanel.SuspendLayout();
            this.okCancelFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // refreshRateLabel
            // 
            this.refreshRateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.refreshRateLabel.AutoSize = true;
            this.agendaSettingsFlowLayoutPanel.SetFlowBreak(this.refreshRateLabel, true);
            this.refreshRateLabel.Location = new System.Drawing.Point(38, 6);
            this.refreshRateLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.refreshRateLabel.Name = "refreshRateLabel";
            this.refreshRateLabel.Size = new System.Drawing.Size(110, 13);
            this.refreshRateLabel.TabIndex = 1;
            this.refreshRateLabel.Text = "Refresh rate (minutes)";
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(308, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // PreloadDaysLabel
            // 
            this.PreloadDaysLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PreloadDaysLabel.AutoSize = true;
            this.agendaSettingsFlowLayoutPanel.SetFlowBreak(this.PreloadDaysLabel, true);
            this.PreloadDaysLabel.Location = new System.Drawing.Point(38, 32);
            this.PreloadDaysLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.PreloadDaysLabel.Name = "PreloadDaysLabel";
            this.PreloadDaysLabel.Size = new System.Drawing.Size(119, 13);
            this.PreloadDaysLabel.TabIndex = 3;
            this.PreloadDaysLabel.Text = "Preload how many days";
            // 
            // eventsSettingsGroupBox
            // 
            this.eventsSettingsGroupBox.AutoSize = true;
            this.eventsSettingsGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eventsSettingsGroupBox.Controls.Add(this.eventSettingsTableLayoutPanel);
            this.eventsSettingsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.eventsSettingsGroupBox.Location = new System.Drawing.Point(3, 149);
            this.eventsSettingsGroupBox.Name = "eventsSettingsGroupBox";
            this.eventsSettingsGroupBox.Size = new System.Drawing.Size(467, 160);
            this.eventsSettingsGroupBox.TabIndex = 1;
            this.eventsSettingsGroupBox.TabStop = false;
            this.eventsSettingsGroupBox.Text = "Events";
            // 
            // eventSettingsTableLayoutPanel
            // 
            this.eventSettingsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventSettingsTableLayoutPanel.AutoSize = true;
            this.eventSettingsTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eventSettingsTableLayoutPanel.ColumnCount = 3;
            this.eventSettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.eventSettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.eventSettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.eventSettingsTableLayoutPanel.Controls.Add(this.SoonAlertOptionsFlowLayoutPanel, 2, 1);
            this.eventSettingsTableLayoutPanel.Controls.Add(this.futureEventsColorButton, 1, 0);
            this.eventSettingsTableLayoutPanel.Controls.Add(this.FutureEventsLabel, 0, 0);
            this.eventSettingsTableLayoutPanel.Controls.Add(this.SoonEventsLabel, 0, 1);
            this.eventSettingsTableLayoutPanel.Controls.Add(this.NowEventsLabel, 0, 2);
            this.eventSettingsTableLayoutPanel.Controls.Add(this.PastEventsLabel, 0, 3);
            this.eventSettingsTableLayoutPanel.Controls.Add(this.NowAlertOptionsFlowLayoutPanel, 2, 2);
            this.eventSettingsTableLayoutPanel.Controls.Add(this.pastDismissOptionFlowLayoutPanel, 2, 3);
            this.eventSettingsTableLayoutPanel.Controls.Add(this.SoonEventsColorButton, 1, 1);
            this.eventSettingsTableLayoutPanel.Controls.Add(this.nowEventsColorButton, 1, 2);
            this.eventSettingsTableLayoutPanel.Controls.Add(this.pastEventsColorButton, 1, 3);
            this.eventSettingsTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.eventSettingsTableLayoutPanel.Name = "eventSettingsTableLayoutPanel";
            this.eventSettingsTableLayoutPanel.RowCount = 4;
            this.eventSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.eventSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.eventSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.eventSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.eventSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.eventSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.eventSettingsTableLayoutPanel.Size = new System.Drawing.Size(461, 125);
            this.eventSettingsTableLayoutPanel.TabIndex = 0;
            // 
            // SoonAlertOptionsFlowLayoutPanel
            // 
            this.SoonAlertOptionsFlowLayoutPanel.AutoSize = true;
            this.SoonAlertOptionsFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SoonAlertOptionsFlowLayoutPanel.Controls.Add(this.soonPopupCheckBox);
            this.SoonAlertOptionsFlowLayoutPanel.Controls.Add(this.soonSoundCheckBox);
            this.SoonAlertOptionsFlowLayoutPanel.Controls.Add(this.soonVerbalCheckBox);
            this.SoonAlertOptionsFlowLayoutPanel.Controls.Add(this.soonTimeInteger);
            this.SoonAlertOptionsFlowLayoutPanel.Controls.Add(this.soonMinutesLabel);
            this.SoonAlertOptionsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SoonAlertOptionsFlowLayoutPanel.Location = new System.Drawing.Point(146, 34);
            this.SoonAlertOptionsFlowLayoutPanel.Name = "SoonAlertOptionsFlowLayoutPanel";
            this.SoonAlertOptionsFlowLayoutPanel.Size = new System.Drawing.Size(312, 26);
            this.SoonAlertOptionsFlowLayoutPanel.TabIndex = 4;
            // 
            // soonPopupCheckBox
            // 
            this.soonPopupCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.soonPopupCheckBox.AutoSize = true;
            this.soonPopupCheckBox.Checked = global::ReflectiveCode.GMinder.Properties.Settings.Default.SoonPopup;
            this.soonPopupCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.soonPopupCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ReflectiveCode.GMinder.Properties.Settings.Default, "SoonPopup", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.soonPopupCheckBox.Location = new System.Drawing.Point(3, 4);
            this.soonPopupCheckBox.Name = "soonPopupCheckBox";
            this.soonPopupCheckBox.Size = new System.Drawing.Size(57, 17);
            this.soonPopupCheckBox.TabIndex = 0;
            this.soonPopupCheckBox.Text = "Popup";
            this.soonPopupCheckBox.UseVisualStyleBackColor = true;
            // 
            // soonSoundCheckBox
            // 
            this.soonSoundCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.soonSoundCheckBox.AutoSize = true;
            this.soonSoundCheckBox.Checked = global::ReflectiveCode.GMinder.Properties.Settings.Default.SoonSound;
            this.soonSoundCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.soonSoundCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ReflectiveCode.GMinder.Properties.Settings.Default, "SoonSound", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.soonSoundCheckBox.Location = new System.Drawing.Point(66, 4);
            this.soonSoundCheckBox.Name = "soonSoundCheckBox";
            this.soonSoundCheckBox.Size = new System.Drawing.Size(57, 17);
            this.soonSoundCheckBox.TabIndex = 1;
            this.soonSoundCheckBox.Text = "Sound";
            this.soonSoundCheckBox.UseVisualStyleBackColor = true;
            // 
            // soonVerbalCheckBox
            // 
            this.soonVerbalCheckBox.AutoSize = true;
            this.soonVerbalCheckBox.Checked = global::ReflectiveCode.GMinder.Properties.Settings.Default.SoonVerbal;
            this.soonVerbalCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ReflectiveCode.GMinder.Properties.Settings.Default, "SoonVerbal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.soonVerbalCheckBox.Location = new System.Drawing.Point(129, 3);
            this.soonVerbalCheckBox.Name = "soonVerbalCheckBox";
            this.soonVerbalCheckBox.Size = new System.Drawing.Size(56, 17);
            this.soonVerbalCheckBox.TabIndex = 4;
            this.soonVerbalCheckBox.Text = "Verbal";
            this.soonVerbalCheckBox.UseVisualStyleBackColor = true;
            // 
            // soonTimeInteger
            // 
            this.soonTimeInteger.AutoSize = true;
            this.soonTimeInteger.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::ReflectiveCode.GMinder.Properties.Settings.Default, "SoonTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.soonTimeInteger.Location = new System.Drawing.Point(191, 3);
            this.soonTimeInteger.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.soonTimeInteger.Name = "soonTimeInteger";
            this.soonTimeInteger.Size = new System.Drawing.Size(47, 20);
            this.soonTimeInteger.TabIndex = 2;
            this.soonTimeInteger.Value = global::ReflectiveCode.GMinder.Properties.Settings.Default.SoonTime;
            // 
            // soonMinutesLabel
            // 
            this.soonMinutesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.soonMinutesLabel.AutoSize = true;
            this.soonMinutesLabel.Location = new System.Drawing.Point(242, 6);
            this.soonMinutesLabel.Margin = new System.Windows.Forms.Padding(1, 0, 3, 0);
            this.soonMinutesLabel.Name = "soonMinutesLabel";
            this.soonMinutesLabel.Size = new System.Drawing.Size(43, 13);
            this.soonMinutesLabel.TabIndex = 3;
            this.soonMinutesLabel.Text = "minutes";
            // 
            // futureEventsColorButton
            // 
            this.futureEventsColorButton.AutoSize = true;
            this.futureEventsColorButton.BackColor = System.Drawing.Color.White;
            this.futureEventsColorButton.Color = global::ReflectiveCode.GMinder.Properties.Settings.Default.FutureColor;
            this.futureEventsColorButton.ColorDialog = this.soonColorDialog;
            this.futureEventsColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.futureEventsColorButton.DataBindings.Add(new System.Windows.Forms.Binding("Color", global::ReflectiveCode.GMinder.Properties.Settings.Default, "FutureColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.futureEventsColorButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.futureEventsColorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.futureEventsColorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.futureEventsColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.futureEventsColorButton.Location = new System.Drawing.Point(46, 3);
            this.futureEventsColorButton.Name = "futureEventsColorButton";
            this.futureEventsColorButton.Size = new System.Drawing.Size(94, 25);
            this.futureEventsColorButton.TabIndex = 1;
            this.futureEventsColorButton.Text = "Color";
            this.futureEventsColorButton.UseVisualStyleBackColor = false;
            // 
            // FutureEventsLabel
            // 
            this.FutureEventsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FutureEventsLabel.AutoSize = true;
            this.FutureEventsLabel.Location = new System.Drawing.Point(3, 9);
            this.FutureEventsLabel.Name = "FutureEventsLabel";
            this.FutureEventsLabel.Size = new System.Drawing.Size(37, 13);
            this.FutureEventsLabel.TabIndex = 0;
            this.FutureEventsLabel.Text = "Future";
            // 
            // SoonEventsLabel
            // 
            this.SoonEventsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SoonEventsLabel.AutoSize = true;
            this.SoonEventsLabel.Location = new System.Drawing.Point(3, 40);
            this.SoonEventsLabel.Name = "SoonEventsLabel";
            this.SoonEventsLabel.Size = new System.Drawing.Size(32, 13);
            this.SoonEventsLabel.TabIndex = 2;
            this.SoonEventsLabel.Text = "Soon";
            // 
            // NowEventsLabel
            // 
            this.NowEventsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NowEventsLabel.AutoSize = true;
            this.NowEventsLabel.Location = new System.Drawing.Point(3, 72);
            this.NowEventsLabel.Name = "NowEventsLabel";
            this.NowEventsLabel.Size = new System.Drawing.Size(29, 13);
            this.NowEventsLabel.TabIndex = 5;
            this.NowEventsLabel.Text = "Now";
            // 
            // PastEventsLabel
            // 
            this.PastEventsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PastEventsLabel.AutoSize = true;
            this.PastEventsLabel.Location = new System.Drawing.Point(3, 103);
            this.PastEventsLabel.Name = "PastEventsLabel";
            this.PastEventsLabel.Size = new System.Drawing.Size(28, 13);
            this.PastEventsLabel.TabIndex = 8;
            this.PastEventsLabel.Text = "Past";
            // 
            // NowAlertOptionsFlowLayoutPanel
            // 
            this.NowAlertOptionsFlowLayoutPanel.AutoSize = true;
            this.NowAlertOptionsFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NowAlertOptionsFlowLayoutPanel.Controls.Add(this.nowPopupCheckBox);
            this.NowAlertOptionsFlowLayoutPanel.Controls.Add(this.nowSoundCheckBox);
            this.NowAlertOptionsFlowLayoutPanel.Controls.Add(this.nowVerbalCheckBox);
            this.NowAlertOptionsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NowAlertOptionsFlowLayoutPanel.Location = new System.Drawing.Point(146, 66);
            this.NowAlertOptionsFlowLayoutPanel.Name = "NowAlertOptionsFlowLayoutPanel";
            this.NowAlertOptionsFlowLayoutPanel.Size = new System.Drawing.Size(312, 23);
            this.NowAlertOptionsFlowLayoutPanel.TabIndex = 7;
            this.NowAlertOptionsFlowLayoutPanel.WrapContents = false;
            // 
            // nowPopupCheckBox
            // 
            this.nowPopupCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nowPopupCheckBox.AutoSize = true;
            this.nowPopupCheckBox.Checked = global::ReflectiveCode.GMinder.Properties.Settings.Default.NowPopup;
            this.nowPopupCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nowPopupCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ReflectiveCode.GMinder.Properties.Settings.Default, "NowPopup", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nowPopupCheckBox.Location = new System.Drawing.Point(3, 3);
            this.nowPopupCheckBox.Name = "nowPopupCheckBox";
            this.nowPopupCheckBox.Size = new System.Drawing.Size(57, 17);
            this.nowPopupCheckBox.TabIndex = 0;
            this.nowPopupCheckBox.Text = "Popup";
            this.nowPopupCheckBox.UseVisualStyleBackColor = true;
            // 
            // nowSoundCheckBox
            // 
            this.nowSoundCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nowSoundCheckBox.AutoSize = true;
            this.nowSoundCheckBox.Checked = global::ReflectiveCode.GMinder.Properties.Settings.Default.NowSound;
            this.nowSoundCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nowSoundCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ReflectiveCode.GMinder.Properties.Settings.Default, "NowSound", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NowAlertOptionsFlowLayoutPanel.SetFlowBreak(this.nowSoundCheckBox, true);
            this.nowSoundCheckBox.Location = new System.Drawing.Point(66, 3);
            this.nowSoundCheckBox.Name = "nowSoundCheckBox";
            this.nowSoundCheckBox.Size = new System.Drawing.Size(57, 17);
            this.nowSoundCheckBox.TabIndex = 1;
            this.nowSoundCheckBox.Text = "Sound";
            this.nowSoundCheckBox.UseVisualStyleBackColor = true;
            // 
            // nowVerbalCheckBox
            // 
            this.nowVerbalCheckBox.AutoSize = true;
            this.nowVerbalCheckBox.Checked = global::ReflectiveCode.GMinder.Properties.Settings.Default.NowVerbal;
            this.nowVerbalCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ReflectiveCode.GMinder.Properties.Settings.Default, "NowVerbal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nowVerbalCheckBox.Location = new System.Drawing.Point(129, 3);
            this.nowVerbalCheckBox.Name = "nowVerbalCheckBox";
            this.nowVerbalCheckBox.Size = new System.Drawing.Size(56, 17);
            this.nowVerbalCheckBox.TabIndex = 2;
            this.nowVerbalCheckBox.Text = "Verbal";
            this.nowVerbalCheckBox.UseVisualStyleBackColor = true;
            // 
            // pastDismissOptionFlowLayoutPanel
            // 
            this.pastDismissOptionFlowLayoutPanel.AutoSize = true;
            this.pastDismissOptionFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pastDismissOptionFlowLayoutPanel.Controls.Add(this.pastDismissCheckBox);
            this.pastDismissOptionFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pastDismissOptionFlowLayoutPanel.Location = new System.Drawing.Point(146, 97);
            this.pastDismissOptionFlowLayoutPanel.Name = "pastDismissOptionFlowLayoutPanel";
            this.pastDismissOptionFlowLayoutPanel.Size = new System.Drawing.Size(312, 23);
            this.pastDismissOptionFlowLayoutPanel.TabIndex = 10;
            // 
            // pastDismissCheckBox
            // 
            this.pastDismissCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pastDismissCheckBox.AutoSize = true;
            this.pastDismissCheckBox.Checked = global::ReflectiveCode.GMinder.Properties.Settings.Default.PastDismiss;
            this.pastDismissCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ReflectiveCode.GMinder.Properties.Settings.Default, "PastDismiss", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pastDismissCheckBox.Location = new System.Drawing.Point(3, 3);
            this.pastDismissCheckBox.Name = "pastDismissCheckBox";
            this.pastDismissCheckBox.Size = new System.Drawing.Size(61, 17);
            this.pastDismissCheckBox.TabIndex = 0;
            this.pastDismissCheckBox.Text = "Dismiss";
            this.pastDismissCheckBox.UseVisualStyleBackColor = true;
            // 
            // SoonEventsColorButton
            // 
            this.SoonEventsColorButton.AutoSize = true;
            this.SoonEventsColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SoonEventsColorButton.Color = global::ReflectiveCode.GMinder.Properties.Settings.Default.SoonColor;
            this.SoonEventsColorButton.ColorDialog = this.soonColorDialog;
            this.SoonEventsColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SoonEventsColorButton.DataBindings.Add(new System.Windows.Forms.Binding("Color", global::ReflectiveCode.GMinder.Properties.Settings.Default, "SoonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SoonEventsColorButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SoonEventsColorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SoonEventsColorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SoonEventsColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SoonEventsColorButton.Location = new System.Drawing.Point(46, 34);
            this.SoonEventsColorButton.Name = "SoonEventsColorButton";
            this.SoonEventsColorButton.Size = new System.Drawing.Size(94, 25);
            this.SoonEventsColorButton.TabIndex = 3;
            this.SoonEventsColorButton.Text = "Color";
            this.SoonEventsColorButton.UseVisualStyleBackColor = false;
            // 
            // nowEventsColorButton
            // 
            this.nowEventsColorButton.AutoSize = true;
            this.nowEventsColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nowEventsColorButton.Color = global::ReflectiveCode.GMinder.Properties.Settings.Default.NowColor;
            this.nowEventsColorButton.ColorDialog = this.soonColorDialog;
            this.nowEventsColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nowEventsColorButton.DataBindings.Add(new System.Windows.Forms.Binding("Color", global::ReflectiveCode.GMinder.Properties.Settings.Default, "NowColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nowEventsColorButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.nowEventsColorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nowEventsColorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nowEventsColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nowEventsColorButton.Location = new System.Drawing.Point(46, 66);
            this.nowEventsColorButton.Name = "nowEventsColorButton";
            this.nowEventsColorButton.Size = new System.Drawing.Size(94, 25);
            this.nowEventsColorButton.TabIndex = 6;
            this.nowEventsColorButton.Text = "Color";
            this.nowEventsColorButton.UseVisualStyleBackColor = false;
            // 
            // pastEventsColorButton
            // 
            this.pastEventsColorButton.AutoSize = true;
            this.pastEventsColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.pastEventsColorButton.Color = global::ReflectiveCode.GMinder.Properties.Settings.Default.PastColor;
            this.pastEventsColorButton.ColorDialog = this.soonColorDialog;
            this.pastEventsColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pastEventsColorButton.DataBindings.Add(new System.Windows.Forms.Binding("Color", global::ReflectiveCode.GMinder.Properties.Settings.Default, "PastColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pastEventsColorButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pastEventsColorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.pastEventsColorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.pastEventsColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pastEventsColorButton.Location = new System.Drawing.Point(46, 97);
            this.pastEventsColorButton.Name = "pastEventsColorButton";
            this.pastEventsColorButton.Size = new System.Drawing.Size(94, 25);
            this.pastEventsColorButton.TabIndex = 9;
            this.pastEventsColorButton.Text = "Color";
            this.pastEventsColorButton.UseVisualStyleBackColor = false;
            // 
            // soundSettingsGroupBox
            // 
            this.soundSettingsGroupBox.AutoSize = true;
            this.soundSettingsGroupBox.Controls.Add(this.soundSettingsTableLayoutPanel);
            this.soundSettingsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.soundSettingsGroupBox.Location = new System.Drawing.Point(3, 315);
            this.soundSettingsGroupBox.Name = "soundSettingsGroupBox";
            this.soundSettingsGroupBox.Size = new System.Drawing.Size(467, 48);
            this.soundSettingsGroupBox.TabIndex = 2;
            this.soundSettingsGroupBox.TabStop = false;
            this.soundSettingsGroupBox.Text = "Sound";
            // 
            // soundSettingsTableLayoutPanel
            // 
            this.soundSettingsTableLayoutPanel.AutoSize = true;
            this.soundSettingsTableLayoutPanel.ColumnCount = 3;
            this.soundSettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.soundSettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.soundSettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.soundSettingsTableLayoutPanel.Controls.Add(this.soundPlayButton, 0, 1);
            this.soundSettingsTableLayoutPanel.Controls.Add(this.soundBrowseButton, 1, 1);
            this.soundSettingsTableLayoutPanel.Controls.Add(this.soundPathTextBox, 2, 1);
            this.soundSettingsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.soundSettingsTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.soundSettingsTableLayoutPanel.Name = "soundSettingsTableLayoutPanel";
            this.soundSettingsTableLayoutPanel.RowCount = 2;
            this.soundSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.soundSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.soundSettingsTableLayoutPanel.Size = new System.Drawing.Size(461, 29);
            this.soundSettingsTableLayoutPanel.TabIndex = 0;
            // 
            // soundPlayButton
            // 
            this.soundPlayButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.soundPlayButton.AutoSize = true;
            this.soundPlayButton.Location = new System.Drawing.Point(3, 3);
            this.soundPlayButton.Name = "soundPlayButton";
            this.soundPlayButton.Size = new System.Drawing.Size(75, 23);
            this.soundPlayButton.TabIndex = 0;
            this.soundPlayButton.Text = "Play";
            this.soundPlayButton.UseVisualStyleBackColor = true;
            this.soundPlayButton.Click += new System.EventHandler(this.soundPlay_Click);
            // 
            // soundBrowseButton
            // 
            this.soundBrowseButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.soundBrowseButton.AutoSize = true;
            this.soundBrowseButton.FileName = "First Run";
            this.soundBrowseButton.Location = new System.Drawing.Point(84, 3);
            this.soundBrowseButton.Name = "soundBrowseButton";
            this.soundBrowseButton.OpenFileDialog = this.openSoundFileDialog;
            this.soundBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.soundBrowseButton.TabIndex = 1;
            this.soundBrowseButton.Text = "Browse";
            this.soundBrowseButton.TextBox = this.soundPathTextBox;
            this.soundBrowseButton.UseVisualStyleBackColor = true;
            // 
            // openSoundFileDialog
            // 
            this.openSoundFileDialog.FileName = "openSoundFileDialog";
            this.openSoundFileDialog.Filter = "Wave|*.wav|All files|*.*";
            this.openSoundFileDialog.Title = "Sound File";
            // 
            // soundPathTextBox
            // 
            this.soundPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.soundPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ReflectiveCode.GMinder.Properties.Settings.Default, "SoundPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.soundPathTextBox.Location = new System.Drawing.Point(165, 4);
            this.soundPathTextBox.Name = "soundPathTextBox";
            this.soundPathTextBox.Size = new System.Drawing.Size(293, 20);
            this.soundPathTextBox.TabIndex = 2;
            this.soundPathTextBox.Text = global::ReflectiveCode.GMinder.Properties.Settings.Default.SoundPath;
            // 
            // agendaSettingsGroupBox
            // 
            this.agendaSettingsGroupBox.AutoSize = true;
            this.agendaSettingsGroupBox.Controls.Add(this.agendaSettingsFlowLayoutPanel);
            this.agendaSettingsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.agendaSettingsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.agendaSettingsGroupBox.Name = "agendaSettingsGroupBox";
            this.agendaSettingsGroupBox.Size = new System.Drawing.Size(467, 140);
            this.agendaSettingsGroupBox.TabIndex = 0;
            this.agendaSettingsGroupBox.TabStop = false;
            this.agendaSettingsGroupBox.Text = "Agenda";
            // 
            // agendaSettingsFlowLayoutPanel
            // 
            this.agendaSettingsFlowLayoutPanel.AutoSize = true;
            this.agendaSettingsFlowLayoutPanel.Controls.Add(this.startAtLoginCheckBox);
            this.agendaSettingsFlowLayoutPanel.Controls.Add(this.onTopCheckBox);
            this.agendaSettingsFlowLayoutPanel.Controls.Add(this.refreshRateInteger);
            this.agendaSettingsFlowLayoutPanel.Controls.Add(this.refreshRateLabel);
            this.agendaSettingsFlowLayoutPanel.Controls.Add(this.preloadDaysInteger);
            this.agendaSettingsFlowLayoutPanel.Controls.Add(this.PreloadDaysLabel);
            this.agendaSettingsFlowLayoutPanel.Controls.Add(this.doPingCheckBox);
            this.agendaSettingsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.agendaSettingsFlowLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.agendaSettingsFlowLayoutPanel.Name = "agendaSettingsFlowLayoutPanel";
            this.agendaSettingsFlowLayoutPanel.Size = new System.Drawing.Size(461, 121);
            this.agendaSettingsFlowLayoutPanel.TabIndex = 0;
            // 
            // refreshRateInteger
            // 
            this.refreshRateInteger.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.refreshRateInteger.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::ReflectiveCode.GMinder.Properties.Settings.Default, "RefreshRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.refreshRateInteger.Location = new System.Drawing.Point(3, 3);
            this.refreshRateInteger.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.refreshRateInteger.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.refreshRateInteger.Name = "refreshRateInteger";
            this.refreshRateInteger.Size = new System.Drawing.Size(35, 20);
            this.refreshRateInteger.TabIndex = 0;
            this.refreshRateInteger.Value = global::ReflectiveCode.GMinder.Properties.Settings.Default.RefreshRate;
            // 
            // preloadDaysInteger
            // 
            this.preloadDaysInteger.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.preloadDaysInteger.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::ReflectiveCode.GMinder.Properties.Settings.Default, "LoadDays", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.preloadDaysInteger.Location = new System.Drawing.Point(3, 29);
            this.preloadDaysInteger.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.preloadDaysInteger.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.preloadDaysInteger.Name = "preloadDaysInteger";
            this.preloadDaysInteger.Size = new System.Drawing.Size(35, 20);
            this.preloadDaysInteger.TabIndex = 2;
            this.preloadDaysInteger.Value = global::ReflectiveCode.GMinder.Properties.Settings.Default.LoadDays;
            // 
            // doPingCheckBox
            // 
            this.doPingCheckBox.AutoSize = true;
            this.doPingCheckBox.Checked = global::ReflectiveCode.GMinder.Properties.Settings.Default.DoPing;
            this.doPingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.doPingCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ReflectiveCode.GMinder.Properties.Settings.Default, "DoPing", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.agendaSettingsFlowLayoutPanel.SetFlowBreak(this.doPingCheckBox, true);
            this.doPingCheckBox.Location = new System.Drawing.Point(3, 55);
            this.doPingCheckBox.Name = "doPingCheckBox";
            this.doPingCheckBox.Size = new System.Drawing.Size(423, 17);
            this.doPingCheckBox.TabIndex = 5;
            this.doPingCheckBox.Text = "Test connectivity before downloading events (disable if your events won\'t downloa" +
    "d)";
            this.doPingCheckBox.UseVisualStyleBackColor = true;
            // 
            // onTopCheckBox
            // 
            this.onTopCheckBox.AutoSize = true;
            this.onTopCheckBox.Checked = global::ReflectiveCode.GMinder.Properties.Settings.Default.OnTop;
            this.onTopCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.onTopCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ReflectiveCode.GMinder.Properties.Settings.Default, "OnTop", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.agendaSettingsFlowLayoutPanel.SetFlowBreak(this.onTopCheckBox, true);
            this.onTopCheckBox.Location = new System.Drawing.Point(3, 78);
            this.onTopCheckBox.Name = "onTopCheckBox";
            this.onTopCheckBox.Size = new System.Drawing.Size(92, 17);
            this.onTopCheckBox.TabIndex = 4;
            this.onTopCheckBox.Text = "Always on top";
            this.onTopCheckBox.UseVisualStyleBackColor = true;
            // 
            // startAtLoginCheckBox
            // 
            this.startAtLoginCheckBox.AutoSize = true;
            this.agendaSettingsFlowLayoutPanel.SetFlowBreak(this.startAtLoginCheckBox, true);
            this.startAtLoginCheckBox.Location = new System.Drawing.Point(3, 101);
            this.startAtLoginCheckBox.Name = "startAtLoginCheckBox";
            this.startAtLoginCheckBox.Size = new System.Drawing.Size(132, 17);
            this.startAtLoginCheckBox.TabIndex = 6;
            this.startAtLoginCheckBox.Text = "Start at Windows login";
            this.startAtLoginCheckBox.UseVisualStyleBackColor = true;
            this.startAtLoginCheckBox.CheckedChanged += new System.EventHandler(this.startAtLogin_CheckedChanged);
            // 
            // optionsTableLayoutPanel
            // 
            this.optionsTableLayoutPanel.AutoSize = true;
            this.optionsTableLayoutPanel.ColumnCount = 1;
            this.optionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.optionsTableLayoutPanel.Controls.Add(this.agendaSettingsGroupBox, 0, 0);
            this.optionsTableLayoutPanel.Controls.Add(this.eventsSettingsGroupBox, 0, 1);
            this.optionsTableLayoutPanel.Controls.Add(this.soundSettingsGroupBox, 0, 2);
            this.optionsTableLayoutPanel.Controls.Add(this.okCancelFlowLayoutPanel, 0, 3);
            this.optionsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.optionsTableLayoutPanel.Name = "optionsTableLayoutPanel";
            this.optionsTableLayoutPanel.RowCount = 5;
            this.optionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.optionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.optionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.optionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.optionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.optionsTableLayoutPanel.Size = new System.Drawing.Size(473, 408);
            this.optionsTableLayoutPanel.TabIndex = 0;
            // 
            // okCancelFlowLayoutPanel
            // 
            this.okCancelFlowLayoutPanel.AutoSize = true;
            this.okCancelFlowLayoutPanel.Controls.Add(this.buttonCancel);
            this.okCancelFlowLayoutPanel.Controls.Add(this.buttonOk);
            this.okCancelFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okCancelFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.okCancelFlowLayoutPanel.Location = new System.Drawing.Point(3, 369);
            this.okCancelFlowLayoutPanel.Name = "okCancelFlowLayoutPanel";
            this.okCancelFlowLayoutPanel.Size = new System.Drawing.Size(467, 28);
            this.okCancelFlowLayoutPanel.TabIndex = 3;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(389, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(473, 408);
            this.Controls.Add(this.optionsTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Options_FormClosed);
            this.Shown += new System.EventHandler(this.Options_Shown);
            this.eventsSettingsGroupBox.ResumeLayout(false);
            this.eventsSettingsGroupBox.PerformLayout();
            this.eventSettingsTableLayoutPanel.ResumeLayout(false);
            this.eventSettingsTableLayoutPanel.PerformLayout();
            this.SoonAlertOptionsFlowLayoutPanel.ResumeLayout(false);
            this.SoonAlertOptionsFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soonTimeInteger)).EndInit();
            this.NowAlertOptionsFlowLayoutPanel.ResumeLayout(false);
            this.NowAlertOptionsFlowLayoutPanel.PerformLayout();
            this.pastDismissOptionFlowLayoutPanel.ResumeLayout(false);
            this.pastDismissOptionFlowLayoutPanel.PerformLayout();
            this.soundSettingsGroupBox.ResumeLayout(false);
            this.soundSettingsGroupBox.PerformLayout();
            this.soundSettingsTableLayoutPanel.ResumeLayout(false);
            this.soundSettingsTableLayoutPanel.PerformLayout();
            this.agendaSettingsGroupBox.ResumeLayout(false);
            this.agendaSettingsGroupBox.PerformLayout();
            this.agendaSettingsFlowLayoutPanel.ResumeLayout(false);
            this.agendaSettingsFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshRateInteger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preloadDaysInteger)).EndInit();
            this.optionsTableLayoutPanel.ResumeLayout(false);
            this.optionsTableLayoutPanel.PerformLayout();
            this.okCancelFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label refreshRateLabel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label PreloadDaysLabel;
        private System.Windows.Forms.GroupBox eventsSettingsGroupBox;
        private System.Windows.Forms.GroupBox soundSettingsGroupBox;
        private System.Windows.Forms.TextBox soundPathTextBox;
        private System.Windows.Forms.Button soundPlayButton;
        private ReflectiveCode.GMinder.Controls.OpenFileButton soundBrowseButton;
        private System.Windows.Forms.ColorDialog soonColorDialog;
        private System.Windows.Forms.OpenFileDialog openSoundFileDialog;
        private ReflectiveCode.GMinder.Controls.IntegerUpDown refreshRateInteger;
        private ReflectiveCode.GMinder.Controls.IntegerUpDown preloadDaysInteger;
        private System.Windows.Forms.TableLayoutPanel soundSettingsTableLayoutPanel;
        private System.Windows.Forms.GroupBox agendaSettingsGroupBox;
        private System.Windows.Forms.FlowLayoutPanel agendaSettingsFlowLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel optionsTableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel okCancelFlowLayoutPanel;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TableLayoutPanel eventSettingsTableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel SoonAlertOptionsFlowLayoutPanel;
        private System.Windows.Forms.CheckBox soonPopupCheckBox;
        private System.Windows.Forms.CheckBox soonSoundCheckBox;
        private ReflectiveCode.GMinder.Controls.IntegerUpDown soonTimeInteger;
        private System.Windows.Forms.Label soonMinutesLabel;
        private ReflectiveCode.GMinder.Controls.ColorButton futureEventsColorButton;
        private System.Windows.Forms.Label FutureEventsLabel;
        private System.Windows.Forms.Label SoonEventsLabel;
        private System.Windows.Forms.Label NowEventsLabel;
        private System.Windows.Forms.Label PastEventsLabel;
        private System.Windows.Forms.FlowLayoutPanel NowAlertOptionsFlowLayoutPanel;
        private System.Windows.Forms.CheckBox nowPopupCheckBox;
        private System.Windows.Forms.CheckBox nowSoundCheckBox;
        private System.Windows.Forms.FlowLayoutPanel pastDismissOptionFlowLayoutPanel;
        private System.Windows.Forms.CheckBox pastDismissCheckBox;
        private ReflectiveCode.GMinder.Controls.ColorButton SoonEventsColorButton;
        private ReflectiveCode.GMinder.Controls.ColorButton nowEventsColorButton;
        private ReflectiveCode.GMinder.Controls.ColorButton pastEventsColorButton;
        private System.Windows.Forms.CheckBox onTopCheckBox;
        private System.Windows.Forms.CheckBox doPingCheckBox;
        private System.Windows.Forms.CheckBox soonVerbalCheckBox;
        private System.Windows.Forms.CheckBox nowVerbalCheckBox;
        private System.Windows.Forms.CheckBox startAtLoginCheckBox;
    }
}