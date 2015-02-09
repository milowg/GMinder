namespace ReflectiveCode.GMinder
{
    partial class Create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create));
            this.CreateFormTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.newEventNameTextBox = new System.Windows.Forms.TextBox();
            this.exampleLabel = new System.Windows.Forms.Label();
            this.calendarList = new System.Windows.Forms.ComboBox();
            this.CreateFormTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateFormTableLayout
            // 
            this.CreateFormTableLayout.AutoSize = true;
            this.CreateFormTableLayout.ColumnCount = 2;
            this.CreateFormTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CreateFormTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CreateFormTableLayout.Controls.Add(this.addButton, 1, 1);
            this.CreateFormTableLayout.Controls.Add(this.newEventNameTextBox, 0, 1);
            this.CreateFormTableLayout.Controls.Add(this.exampleLabel, 0, 0);
            this.CreateFormTableLayout.Controls.Add(this.calendarList, 0, 2);
            this.CreateFormTableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateFormTableLayout.Location = new System.Drawing.Point(0, 0);
            this.CreateFormTableLayout.Name = "CreateFormTableLayout";
            this.CreateFormTableLayout.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.CreateFormTableLayout.RowCount = 3;
            this.CreateFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CreateFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CreateFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CreateFormTableLayout.Size = new System.Drawing.Size(337, 72);
            this.CreateFormTableLayout.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addButton.Location = new System.Drawing.Point(259, 21);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.HandleAddButton);
            // 
            // newEventNameTextBox
            // 
            this.newEventNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.newEventNameTextBox.Location = new System.Drawing.Point(3, 22);
            this.newEventNameTextBox.Name = "newEventNameTextBox";
            this.newEventNameTextBox.Size = new System.Drawing.Size(250, 20);
            this.newEventNameTextBox.TabIndex = 0;
            this.newEventNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleKeyPress);
            // 
            // exampleLabel
            // 
            this.exampleLabel.AutoSize = true;
            this.CreateFormTableLayout.SetColumnSpan(this.exampleLabel, 2);
            this.exampleLabel.Location = new System.Drawing.Point(3, 5);
            this.exampleLabel.Name = "exampleLabel";
            this.exampleLabel.Size = new System.Drawing.Size(215, 13);
            this.exampleLabel.TabIndex = 3;
            this.exampleLabel.Text = "Example: Dinner with Michael 7pm tomorrow";
            // 
            // calendarList
            // 
            this.calendarList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateFormTableLayout.SetColumnSpan(this.calendarList, 2);
            this.calendarList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.calendarList.FormatString = "{Name}";
            this.calendarList.FormattingEnabled = true;
            this.calendarList.Location = new System.Drawing.Point(30, 50);
            this.calendarList.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.calendarList.Name = "calendarList";
            this.calendarList.Size = new System.Drawing.Size(277, 21);
            this.calendarList.TabIndex = 1;
            // 
            // Create
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 81);
            this.Controls.Add(this.CreateFormTableLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Create";
            this.Text = "Quick Add";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleKeyPress);
            this.CreateFormTableLayout.ResumeLayout(false);
            this.CreateFormTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CreateFormTableLayout;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox newEventNameTextBox;
        private System.Windows.Forms.Label exampleLabel;
        private System.Windows.Forms.ComboBox calendarList;
    }
}