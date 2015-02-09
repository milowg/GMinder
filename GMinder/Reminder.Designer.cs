using ReflectiveCode.GMinder.Controls;

namespace ReflectiveCode.GMinder
{
    partial class GReminder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GReminder));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.calendarsTrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsTrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.resetTrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshTrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutTrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarRefresher = new System.ComponentModel.BackgroundWorker();
            this.eventWhere = new System.Windows.Forms.Label();
            this.eventWhat = new System.Windows.Forms.Label();
            this.eventWhen = new System.Windows.Forms.Label();
            this.reminderFormTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.agenda = new ReflectiveCode.GMinder.Controls.Agenda();
            this.reminderButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.newButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.dismissButton = new System.Windows.Forms.Button();
            this.snoozeLengthInteger = new ReflectiveCode.GMinder.Controls.IntegerUpDown();
            this.snoozeButton = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.Button();
            this.minuteTimer = new System.Windows.Forms.Timer(this.components);
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.snoozeTimer = new System.Windows.Forms.Timer(this.components);
            this.trayMenu.SuspendLayout();
            this.reminderFormTableLayoutPanel.SuspendLayout();
            this.reminderButtonsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snoozeLengthInteger)).BeginInit();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "GMinder";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HandleTrayClick);
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.HandleTrayDoubleClick);
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calendarsTrayMenuItem,
            this.optionsTrayMenuItem,
            this.trayMenuToolStripSeparator2,
            this.resetTrayMenuItem,
            this.refreshTrayMenuItem,
            this.addTrayMenuItem,
            this.trayMenuToolStripSeparator1,
            this.aboutTrayMenuItem,
            this.exitTrayMenuItem});
            this.trayMenu.Name = "contextMenuStrip1";
            this.trayMenu.Size = new System.Drawing.Size(157, 170);
            // 
            // calendarsTrayMenuItem
            // 
            this.calendarsTrayMenuItem.Name = "calendarsTrayMenuItem";
            this.calendarsTrayMenuItem.Size = new System.Drawing.Size(156, 22);
            this.calendarsTrayMenuItem.Text = "Calendars";
            this.calendarsTrayMenuItem.Click += new System.EventHandler(this.HandleTrayCalendars);
            // 
            // optionsTrayMenuItem
            // 
            this.optionsTrayMenuItem.Name = "optionsTrayMenuItem";
            this.optionsTrayMenuItem.Size = new System.Drawing.Size(156, 22);
            this.optionsTrayMenuItem.Text = "Options";
            this.optionsTrayMenuItem.Click += new System.EventHandler(this.HandleTrayOptions);
            // 
            // trayMenuToolStripSeparator2
            // 
            this.trayMenuToolStripSeparator2.Name = "trayMenuToolStripSeparator2";
            this.trayMenuToolStripSeparator2.Size = new System.Drawing.Size(153, 6);
            // 
            // resetTrayMenuItem
            // 
            this.resetTrayMenuItem.Name = "resetTrayMenuItem";
            this.resetTrayMenuItem.Size = new System.Drawing.Size(156, 22);
            this.resetTrayMenuItem.Text = "Clear Events";
            this.resetTrayMenuItem.Click += new System.EventHandler(this.HandleTrayReset);
            // 
            // refreshTrayMenuItem
            // 
            this.refreshTrayMenuItem.Name = "refreshTrayMenuItem";
            this.refreshTrayMenuItem.Size = new System.Drawing.Size(156, 22);
            this.refreshTrayMenuItem.Text = "Refresh Events";
            this.refreshTrayMenuItem.Click += new System.EventHandler(this.HandleTrayRefresh);
            // 
            // addTrayMenuItem
            // 
            this.addTrayMenuItem.Name = "addTrayMenuItem";
            this.addTrayMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addTrayMenuItem.Text = "Add Event";
            this.addTrayMenuItem.Click += new System.EventHandler(this.HandleAddButton);
            // 
            // trayMenuToolStripSeparator1
            // 
            this.trayMenuToolStripSeparator1.Name = "trayMenuToolStripSeparator1";
            this.trayMenuToolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // aboutTrayMenuItem
            // 
            this.aboutTrayMenuItem.Name = "aboutTrayMenuItem";
            this.aboutTrayMenuItem.Size = new System.Drawing.Size(156, 22);
            this.aboutTrayMenuItem.Text = "About GMinder";
            this.aboutTrayMenuItem.Click += new System.EventHandler(this.HandleTrayAbout);
            // 
            // exitTrayMenuItem
            // 
            this.exitTrayMenuItem.Name = "exitTrayMenuItem";
            this.exitTrayMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitTrayMenuItem.Text = "Exit";
            this.exitTrayMenuItem.Click += new System.EventHandler(this.HandleTrayExit);
            // 
            // calendarRefresher
            // 
            this.calendarRefresher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.HandleCalendarRefresherWork);
            this.calendarRefresher.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.HandleCalendarRefresherCompleted);
            // 
            // eventWhere
            // 
            this.eventWhere.AutoSize = true;
            this.eventWhere.Location = new System.Drawing.Point(3, 37);
            this.eventWhere.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.eventWhere.Name = "eventWhere";
            this.eventWhere.Size = new System.Drawing.Size(39, 13);
            this.eventWhere.TabIndex = 2;
            this.eventWhere.Text = "Where";
            // 
            // eventWhat
            // 
            this.eventWhat.AutoSize = true;
            this.eventWhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventWhat.Location = new System.Drawing.Point(3, 0);
            this.eventWhat.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.eventWhat.Name = "eventWhat";
            this.eventWhat.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.eventWhat.Size = new System.Drawing.Size(37, 18);
            this.eventWhat.TabIndex = 0;
            this.eventWhat.Text = "What";
            this.eventWhat.Click += new System.EventHandler(this.eventWhat_Click);
            // 
            // eventWhen
            // 
            this.eventWhen.AutoSize = true;
            this.eventWhen.Location = new System.Drawing.Point(3, 21);
            this.eventWhen.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.eventWhen.Name = "eventWhen";
            this.eventWhen.Size = new System.Drawing.Size(36, 13);
            this.eventWhen.TabIndex = 1;
            this.eventWhen.Text = "When";
            // 
            // reminderFormTableLayoutPanel
            // 
            this.reminderFormTableLayoutPanel.AutoSize = true;
            this.reminderFormTableLayoutPanel.ColumnCount = 1;
            this.reminderFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.reminderFormTableLayoutPanel.Controls.Add(this.eventWhat, 0, 0);
            this.reminderFormTableLayoutPanel.Controls.Add(this.eventWhere, 0, 2);
            this.reminderFormTableLayoutPanel.Controls.Add(this.agenda, 0, 3);
            this.reminderFormTableLayoutPanel.Controls.Add(this.eventWhen, 0, 1);
            this.reminderFormTableLayoutPanel.Controls.Add(this.reminderButtonsTableLayoutPanel, 0, 4);
            this.reminderFormTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reminderFormTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.reminderFormTableLayoutPanel.Name = "reminderFormTableLayoutPanel";
            this.reminderFormTableLayoutPanel.RowCount = 5;
            this.reminderFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.reminderFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.reminderFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.reminderFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.reminderFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.reminderFormTableLayoutPanel.Size = new System.Drawing.Size(459, 388);
            this.reminderFormTableLayoutPanel.TabIndex = 0;
            this.reminderFormTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.eventTable_Paint);
            // 
            // agenda
            // 
            this.agenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agenda.ForeColor = System.Drawing.Color.Black;
            this.agenda.FullRowSelect = true;
            this.agenda.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.agenda.HideSelection = false;
            this.agenda.Location = new System.Drawing.Point(0, 53);
            this.agenda.Margin = new System.Windows.Forms.Padding(0);
            this.agenda.MultiSelect = false;
            this.agenda.Name = "agenda";
            this.agenda.Size = new System.Drawing.Size(459, 306);
            this.agenda.TabIndex = 3;
            this.agenda.UseCompatibleStateImageBehavior = false;
            this.agenda.View = System.Windows.Forms.View.Details;
            this.agenda.SelectedChanged += new System.EventHandler(this.HandleAgendaSelectionChanged);
            this.agenda.SelectedIndexChanged += new System.EventHandler(this.agenda_SelectedIndexChanged);
            // 
            // reminderButtonsTableLayoutPanel
            // 
            this.reminderButtonsTableLayoutPanel.AutoSize = true;
            this.reminderButtonsTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reminderButtonsTableLayoutPanel.ColumnCount = 6;
            this.reminderButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.reminderButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.reminderButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.reminderButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.reminderButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.reminderButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.reminderButtonsTableLayoutPanel.Controls.Add(this.newButton, 0, 0);
            this.reminderButtonsTableLayoutPanel.Controls.Add(this.openButton, 1, 0);
            this.reminderButtonsTableLayoutPanel.Controls.Add(this.dismissButton, 2, 0);
            this.reminderButtonsTableLayoutPanel.Controls.Add(this.snoozeLengthInteger, 3, 0);
            this.reminderButtonsTableLayoutPanel.Controls.Add(this.snoozeButton, 4, 0);
            this.reminderButtonsTableLayoutPanel.Controls.Add(this.hideButton, 5, 0);
            this.reminderButtonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.reminderButtonsTableLayoutPanel.Location = new System.Drawing.Point(0, 359);
            this.reminderButtonsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.reminderButtonsTableLayoutPanel.Name = "reminderButtonsTableLayoutPanel";
            this.reminderButtonsTableLayoutPanel.RowCount = 1;
            this.reminderButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.reminderButtonsTableLayoutPanel.Size = new System.Drawing.Size(459, 29);
            this.reminderButtonsTableLayoutPanel.TabIndex = 4;
            // 
            // newButton
            // 
            this.newButton.AutoSize = true;
            this.newButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.newButton.Location = new System.Drawing.Point(3, 3);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(39, 23);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.HandleAddButton);
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openButton.AutoSize = true;
            this.openButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openButton.Location = new System.Drawing.Point(48, 3);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(43, 23);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.HandleOpenButton);
            // 
            // dismissButton
            // 
            this.dismissButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dismissButton.AutoSize = true;
            this.dismissButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dismissButton.Location = new System.Drawing.Point(97, 3);
            this.dismissButton.Name = "dismissButton";
            this.dismissButton.Size = new System.Drawing.Size(52, 23);
            this.dismissButton.TabIndex = 2;
            this.dismissButton.Text = "Dismiss";
            this.dismissButton.UseVisualStyleBackColor = true;
            this.dismissButton.Click += new System.EventHandler(this.HandleDismissClick);
            // 
            // snoozeLengthInteger
            // 
            this.snoozeLengthInteger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.snoozeLengthInteger.Location = new System.Drawing.Point(292, 6);
            this.snoozeLengthInteger.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.snoozeLengthInteger.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.snoozeLengthInteger.Name = "snoozeLengthInteger";
            this.snoozeLengthInteger.Size = new System.Drawing.Size(60, 20);
            this.snoozeLengthInteger.TabIndex = 3;
            this.snoozeLengthInteger.Value = 10;
            this.snoozeLengthInteger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleSnoozeKeyPress);
            // 
            // snoozeButton
            // 
            this.snoozeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.snoozeButton.AutoSize = true;
            this.snoozeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.snoozeButton.Location = new System.Drawing.Point(358, 3);
            this.snoozeButton.Name = "snoozeButton";
            this.snoozeButton.Size = new System.Drawing.Size(53, 23);
            this.snoozeButton.TabIndex = 4;
            this.snoozeButton.Text = "Snooze";
            this.snoozeButton.UseVisualStyleBackColor = true;
            this.snoozeButton.Click += new System.EventHandler(this.HandleSnoozeButton);
            // 
            // hideButton
            // 
            this.hideButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hideButton.AutoSize = true;
            this.hideButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hideButton.Location = new System.Drawing.Point(417, 3);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(39, 23);
            this.hideButton.TabIndex = 5;
            this.hideButton.Text = "Hide";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.HandleHideButton);
            // 
            // minuteTimer
            // 
            this.minuteTimer.Enabled = true;
            this.minuteTimer.Tick += new System.EventHandler(this.HandleMinuteTimerTick);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Tick += new System.EventHandler(this.HandleRefreshTimerTick);
            // 
            // snoozeTimer
            // 
            this.snoozeTimer.Tick += new System.EventHandler(this.HandleSnoozeTimerTick);
            // 
            // GReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 388);
            this.Controls.Add(this.reminderFormTableLayoutPanel);
            this.DataBindings.Add(new System.Windows.Forms.Binding("TopMost", global::ReflectiveCode.GMinder.Properties.Settings.Default, "OnTop", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GReminder";
            this.Text = "GMinder";
            this.TopMost = global::ReflectiveCode.GMinder.Properties.Settings.Default.OnTop;
            this.Load += new System.EventHandler(this.GReminder_Load);
            this.trayMenu.ResumeLayout(false);
            this.reminderFormTableLayoutPanel.ResumeLayout(false);
            this.reminderFormTableLayoutPanel.PerformLayout();
            this.reminderButtonsTableLayoutPanel.ResumeLayout(false);
            this.reminderButtonsTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snoozeLengthInteger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.Timer minuteTimer;
        private System.Windows.Forms.Timer snoozeTimer;
        private System.ComponentModel.BackgroundWorker calendarRefresher;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem calendarsTrayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsTrayMenuItem;
        private System.Windows.Forms.ToolStripSeparator trayMenuToolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem refreshTrayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetTrayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTrayMenuItem;
        private System.Windows.Forms.ToolStripSeparator trayMenuToolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutTrayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitTrayMenuItem;
        private System.Windows.Forms.TableLayoutPanel reminderFormTableLayoutPanel;
        private System.Windows.Forms.Label eventWhat;
        private System.Windows.Forms.Label eventWhen;
        private System.Windows.Forms.Label eventWhere;
        private Agenda agenda;
        private System.Windows.Forms.TableLayoutPanel reminderButtonsTableLayoutPanel;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button dismissButton;
        private Controls.IntegerUpDown snoozeLengthInteger;
        private System.Windows.Forms.Button snoozeButton;
        private System.Windows.Forms.Button hideButton;
    }
}

