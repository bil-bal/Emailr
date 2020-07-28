namespace EmailerUI
{
    partial class EmailrStartForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailrStartForm));
            this.employeeListbox = new System.Windows.Forms.ListBox();
            this.modifyEmailToButton = new System.Windows.Forms.Button();
            this.sendToTeamsCheckbox = new System.Windows.Forms.CheckBox();
            this.sendEmailsButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailHtmlPreviewBrowser = new System.Windows.Forms.WebBrowser();
            this.previewEmailLabel = new System.Windows.Forms.Label();
            this.composeEmailButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.teamListbox = new System.Windows.Forms.ListBox();
            this.subjectTextbox = new System.Windows.Forms.TextBox();
            this.fromTextbox = new System.Windows.Forms.TextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.logListbox = new System.Windows.Forms.ListBox();
            this.logLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeListbox
            // 
            this.employeeListbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeListbox.FormattingEnabled = true;
            this.employeeListbox.ItemHeight = 21;
            this.employeeListbox.Location = new System.Drawing.Point(745, 181);
            this.employeeListbox.Name = "employeeListbox";
            this.employeeListbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.employeeListbox.Size = new System.Drawing.Size(399, 403);
            this.employeeListbox.TabIndex = 0;
            // 
            // modifyEmailToButton
            // 
            this.modifyEmailToButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modifyEmailToButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.modifyEmailToButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.modifyEmailToButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyEmailToButton.ForeColor = System.Drawing.Color.Black;
            this.modifyEmailToButton.Location = new System.Drawing.Point(967, 100);
            this.modifyEmailToButton.Name = "modifyEmailToButton";
            this.modifyEmailToButton.Size = new System.Drawing.Size(177, 54);
            this.modifyEmailToButton.TabIndex = 1;
            this.modifyEmailToButton.Text = "Modify List";
            this.modifyEmailToButton.UseVisualStyleBackColor = false;
            this.modifyEmailToButton.Click += new System.EventHandler(this.modifyEmailToButton_Click);
            // 
            // sendToTeamsCheckbox
            // 
            this.sendToTeamsCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendToTeamsCheckbox.AutoSize = true;
            this.sendToTeamsCheckbox.Location = new System.Drawing.Point(773, 148);
            this.sendToTeamsCheckbox.Name = "sendToTeamsCheckbox";
            this.sendToTeamsCheckbox.Size = new System.Drawing.Size(129, 25);
            this.sendToTeamsCheckbox.TabIndex = 2;
            this.sendToTeamsCheckbox.Text = "Send to Teams";
            this.sendToTeamsCheckbox.UseVisualStyleBackColor = true;
            this.sendToTeamsCheckbox.CheckedChanged += new System.EventHandler(this.sendToTeamsCheckbox_CheckedChanged);
            // 
            // sendEmailsButton
            // 
            this.sendEmailsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sendEmailsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sendEmailsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.sendEmailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendEmailsButton.ForeColor = System.Drawing.Color.Black;
            this.sendEmailsButton.Location = new System.Drawing.Point(290, 633);
            this.sendEmailsButton.Name = "sendEmailsButton";
            this.sendEmailsButton.Size = new System.Drawing.Size(177, 54);
            this.sendEmailsButton.TabIndex = 3;
            this.sendEmailsButton.Text = "Send Emails";
            this.sendEmailsButton.UseVisualStyleBackColor = false;
            this.sendEmailsButton.Click += new System.EventHandler(this.sendEmailsButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(151, 601);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(76, 21);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // emailHtmlPreviewBrowser
            // 
            this.emailHtmlPreviewBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailHtmlPreviewBrowser.Location = new System.Drawing.Point(3, -1);
            this.emailHtmlPreviewBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.emailHtmlPreviewBrowser.Name = "emailHtmlPreviewBrowser";
            this.emailHtmlPreviewBrowser.Size = new System.Drawing.Size(693, 401);
            this.emailHtmlPreviewBrowser.TabIndex = 6;
            // 
            // previewEmailLabel
            // 
            this.previewEmailLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.previewEmailLabel.AutoSize = true;
            this.previewEmailLabel.Location = new System.Drawing.Point(36, 80);
            this.previewEmailLabel.Name = "previewEmailLabel";
            this.previewEmailLabel.Size = new System.Drawing.Size(107, 21);
            this.previewEmailLabel.TabIndex = 7;
            this.previewEmailLabel.Text = "Preview Email";
            // 
            // composeEmailButton
            // 
            this.composeEmailButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.composeEmailButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.composeEmailButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.composeEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.composeEmailButton.ForeColor = System.Drawing.Color.Black;
            this.composeEmailButton.Location = new System.Drawing.Point(290, 19);
            this.composeEmailButton.Name = "composeEmailButton";
            this.composeEmailButton.Size = new System.Drawing.Size(177, 54);
            this.composeEmailButton.TabIndex = 8;
            this.composeEmailButton.Text = "Compose Email";
            this.composeEmailButton.UseVisualStyleBackColor = false;
            this.composeEmailButton.Click += new System.EventHandler(this.composeEmailButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.emailHtmlPreviewBrowser);
            this.panel1.Location = new System.Drawing.Point(40, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 403);
            this.panel1.TabIndex = 9;
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.settingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.ForeColor = System.Drawing.Color.Black;
            this.settingsButton.Location = new System.Drawing.Point(619, 29);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(118, 34);
            this.settingsButton.TabIndex = 10;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // teamListbox
            // 
            this.teamListbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamListbox.FormattingEnabled = true;
            this.teamListbox.ItemHeight = 21;
            this.teamListbox.Location = new System.Drawing.Point(745, 181);
            this.teamListbox.Name = "teamListbox";
            this.teamListbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.teamListbox.Size = new System.Drawing.Size(399, 403);
            this.teamListbox.TabIndex = 11;
            // 
            // subjectTextbox
            // 
            this.subjectTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.subjectTextbox.BackColor = System.Drawing.Color.White;
            this.subjectTextbox.Location = new System.Drawing.Point(125, 146);
            this.subjectTextbox.Name = "subjectTextbox";
            this.subjectTextbox.ReadOnly = true;
            this.subjectTextbox.Size = new System.Drawing.Size(614, 29);
            this.subjectTextbox.TabIndex = 12;
            // 
            // fromTextbox
            // 
            this.fromTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fromTextbox.BackColor = System.Drawing.Color.White;
            this.fromTextbox.Location = new System.Drawing.Point(125, 111);
            this.fromTextbox.Name = "fromTextbox";
            this.fromTextbox.ReadOnly = true;
            this.fromTextbox.Size = new System.Drawing.Size(614, 29);
            this.fromTextbox.TabIndex = 13;
            // 
            // subjectLabel
            // 
            this.subjectLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(64, 147);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(61, 21);
            this.subjectLabel.TabIndex = 14;
            this.subjectLabel.Text = "Subject";
            // 
            // fromLabel
            // 
            this.fromLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(64, 114);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(47, 21);
            this.fromLabel.TabIndex = 15;
            this.fromLabel.Text = "From";
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.passwordBox.Location = new System.Drawing.Point(239, 598);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(279, 29);
            this.passwordBox.TabIndex = 4;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // logListbox
            // 
            this.logListbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logListbox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.logListbox.FormattingEnabled = true;
            this.logListbox.Location = new System.Drawing.Point(619, 598);
            this.logListbox.Name = "logListbox";
            this.logListbox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.logListbox.Size = new System.Drawing.Size(525, 82);
            this.logListbox.TabIndex = 16;
            // 
            // logLabel
            // 
            this.logLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(36, 650);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(0, 21);
            this.logLabel.TabIndex = 17;
            // 
            // EmailrStartForm
            // 
            this.AcceptButton = this.sendEmailsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 702);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.logListbox);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.subjectTextbox);
            this.Controls.Add(this.fromTextbox);
            this.Controls.Add(this.teamListbox);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.composeEmailButton);
            this.Controls.Add(this.previewEmailLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.sendEmailsButton);
            this.Controls.Add(this.sendToTeamsCheckbox);
            this.Controls.Add(this.modifyEmailToButton);
            this.Controls.Add(this.employeeListbox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1200, 741);
            this.Name = "EmailrStartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emailr";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox employeeListbox;
        private System.Windows.Forms.Button modifyEmailToButton;
        private System.Windows.Forms.CheckBox sendToTeamsCheckbox;
        private System.Windows.Forms.Button sendEmailsButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.WebBrowser emailHtmlPreviewBrowser;
        private System.Windows.Forms.Label previewEmailLabel;
        private System.Windows.Forms.Button composeEmailButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.ListBox teamListbox;
        private System.Windows.Forms.TextBox subjectTextbox;
        private System.Windows.Forms.TextBox fromTextbox;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.ListBox logListbox;
        private System.Windows.Forms.Label logLabel;
    }
}

