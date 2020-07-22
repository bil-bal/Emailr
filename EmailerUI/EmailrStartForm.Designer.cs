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
            this.sendEmailToBox = new System.Windows.Forms.ListBox();
            this.modifyEmailToButton = new System.Windows.Forms.Button();
            this.sendToTeamsCheckbox = new System.Windows.Forms.CheckBox();
            this.sendEmailsButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailHtmlPreviewBrowser = new System.Windows.Forms.WebBrowser();
            this.previewEmailLabel = new System.Windows.Forms.Label();
            this.composeEmailButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendEmailToBox
            // 
            this.sendEmailToBox.FormattingEnabled = true;
            this.sendEmailToBox.ItemHeight = 21;
            this.sendEmailToBox.Location = new System.Drawing.Point(792, 143);
            this.sendEmailToBox.Name = "sendEmailToBox";
            this.sendEmailToBox.Size = new System.Drawing.Size(399, 403);
            this.sendEmailToBox.TabIndex = 0;
            // 
            // modifyEmailToButton
            // 
            this.modifyEmailToButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.modifyEmailToButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.modifyEmailToButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyEmailToButton.ForeColor = System.Drawing.Color.Black;
            this.modifyEmailToButton.Location = new System.Drawing.Point(1014, 62);
            this.modifyEmailToButton.Name = "modifyEmailToButton";
            this.modifyEmailToButton.Size = new System.Drawing.Size(177, 54);
            this.modifyEmailToButton.TabIndex = 1;
            this.modifyEmailToButton.Text = "Modify List";
            this.modifyEmailToButton.UseVisualStyleBackColor = false;
            // 
            // sendToTeamsCheckbox
            // 
            this.sendToTeamsCheckbox.AutoSize = true;
            this.sendToTeamsCheckbox.Location = new System.Drawing.Point(838, 78);
            this.sendToTeamsCheckbox.Name = "sendToTeamsCheckbox";
            this.sendToTeamsCheckbox.Size = new System.Drawing.Size(129, 25);
            this.sendToTeamsCheckbox.TabIndex = 2;
            this.sendToTeamsCheckbox.Text = "Send to Teams";
            this.sendToTeamsCheckbox.UseVisualStyleBackColor = true;
            // 
            // sendEmailsButton
            // 
            this.sendEmailsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sendEmailsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.sendEmailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendEmailsButton.ForeColor = System.Drawing.Color.Black;
            this.sendEmailsButton.Location = new System.Drawing.Point(337, 595);
            this.sendEmailsButton.Name = "sendEmailsButton";
            this.sendEmailsButton.Size = new System.Drawing.Size(177, 54);
            this.sendEmailsButton.TabIndex = 3;
            this.sendEmailsButton.Text = "Send Emails";
            this.sendEmailsButton.UseVisualStyleBackColor = false;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(286, 560);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(279, 29);
            this.passwordBox.TabIndex = 4;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(198, 563);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(76, 21);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // emailHtmlPreviewBrowser
            // 
            this.emailHtmlPreviewBrowser.Location = new System.Drawing.Point(3, -1);
            this.emailHtmlPreviewBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.emailHtmlPreviewBrowser.Name = "emailHtmlPreviewBrowser";
            this.emailHtmlPreviewBrowser.Size = new System.Drawing.Size(693, 401);
            this.emailHtmlPreviewBrowser.TabIndex = 6;
            // 
            // previewEmailLabel
            // 
            this.previewEmailLabel.AutoSize = true;
            this.previewEmailLabel.Location = new System.Drawing.Point(83, 116);
            this.previewEmailLabel.Name = "previewEmailLabel";
            this.previewEmailLabel.Size = new System.Drawing.Size(107, 21);
            this.previewEmailLabel.TabIndex = 7;
            this.previewEmailLabel.Text = "Preview Email";
            // 
            // composeEmailButton
            // 
            this.composeEmailButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.composeEmailButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.composeEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.composeEmailButton.ForeColor = System.Drawing.Color.Black;
            this.composeEmailButton.Location = new System.Drawing.Point(337, 62);
            this.composeEmailButton.Name = "composeEmailButton";
            this.composeEmailButton.Size = new System.Drawing.Size(177, 54);
            this.composeEmailButton.TabIndex = 8;
            this.composeEmailButton.Text = "Compose Email";
            this.composeEmailButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.emailHtmlPreviewBrowser);
            this.panel1.Location = new System.Drawing.Point(87, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 403);
            this.panel1.TabIndex = 9;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.settingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.ForeColor = System.Drawing.Color.Black;
            this.settingsButton.Location = new System.Drawing.Point(666, 72);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(118, 34);
            this.settingsButton.TabIndex = 10;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // EmailrStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1235, 682);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.composeEmailButton);
            this.Controls.Add(this.previewEmailLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.sendEmailsButton);
            this.Controls.Add(this.sendToTeamsCheckbox);
            this.Controls.Add(this.modifyEmailToButton);
            this.Controls.Add(this.sendEmailToBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "EmailrStartForm";
            this.Text = "Emailr";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox sendEmailToBox;
        private System.Windows.Forms.Button modifyEmailToButton;
        private System.Windows.Forms.CheckBox sendToTeamsCheckbox;
        private System.Windows.Forms.Button sendEmailsButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.WebBrowser emailHtmlPreviewBrowser;
        private System.Windows.Forms.Label previewEmailLabel;
        private System.Windows.Forms.Button composeEmailButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button settingsButton;
    }
}

