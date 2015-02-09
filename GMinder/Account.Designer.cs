namespace ReflectiveCode.GMinder
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.accountFormTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.okCancelFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.enterUsernameAndPasswordLabel = new System.Windows.Forms.Label();
            this.accountFormTableLayout.SuspendLayout();
            this.okCancelFlowLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountFormTableLayout
            // 
            this.accountFormTableLayout.ColumnCount = 1;
            this.accountFormTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.accountFormTableLayout.Controls.Add(this.okCancelFlowLayout, 0, 5);
            this.accountFormTableLayout.Controls.Add(this.usernameLabel, 0, 1);
            this.accountFormTableLayout.Controls.Add(this.passwordLabel, 0, 3);
            this.accountFormTableLayout.Controls.Add(this.usernameTextBox, 0, 2);
            this.accountFormTableLayout.Controls.Add(this.passwordTextBox, 0, 4);
            this.accountFormTableLayout.Controls.Add(this.enterUsernameAndPasswordLabel, 0, 0);
            this.accountFormTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountFormTableLayout.Location = new System.Drawing.Point(0, 0);
            this.accountFormTableLayout.Name = "accountFormTableLayout";
            this.accountFormTableLayout.RowCount = 6;
            this.accountFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.accountFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.accountFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.accountFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.accountFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.accountFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.accountFormTableLayout.Size = new System.Drawing.Size(252, 186);
            this.accountFormTableLayout.TabIndex = 0;
            // 
            // okCancelFlowLayout
            // 
            this.okCancelFlowLayout.AutoSize = true;
            this.okCancelFlowLayout.Controls.Add(this.buttonCancel);
            this.okCancelFlowLayout.Controls.Add(this.buttonOk);
            this.okCancelFlowLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okCancelFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.okCancelFlowLayout.Location = new System.Drawing.Point(3, 154);
            this.okCancelFlowLayout.Name = "okCancelFlowLayout";
            this.okCancelFlowLayout.Size = new System.Drawing.Size(246, 29);
            this.okCancelFlowLayout.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(168, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(87, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.HandleOK);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(20, 54);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(20, 5, 20, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(20, 98);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(20, 5, 20, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.usernameTextBox.Location = new System.Drawing.Point(20, 70);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(212, 20);
            this.usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwordTextBox.Location = new System.Drawing.Point(20, 114);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(212, 20);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // enterUsernameAndPasswordLabel
            // 
            this.enterUsernameAndPasswordLabel.AutoSize = true;
            this.enterUsernameAndPasswordLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.enterUsernameAndPasswordLabel.Location = new System.Drawing.Point(5, 5);
            this.enterUsernameAndPasswordLabel.Margin = new System.Windows.Forms.Padding(5);
            this.enterUsernameAndPasswordLabel.Name = "enterUsernameAndPasswordLabel";
            this.enterUsernameAndPasswordLabel.Size = new System.Drawing.Size(242, 39);
            this.enterUsernameAndPasswordLabel.TabIndex = 3;
            this.enterUsernameAndPasswordLabel.Text = "Enter the username and password of your Google account to download your list of c" +
                "alendars and gain access to your private calendars.";
            // 
            // Account
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(252, 186);
            this.Controls.Add(this.accountFormTableLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Your Google Account";
            this.accountFormTableLayout.ResumeLayout(false);
            this.accountFormTableLayout.PerformLayout();
            this.okCancelFlowLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel accountFormTableLayout;
        private System.Windows.Forms.FlowLayoutPanel okCancelFlowLayout;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label enterUsernameAndPasswordLabel;
    }
}