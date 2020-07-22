namespace EmailerUI
{
    partial class EmailrSettingsForm
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
            this.emailAddressTextbox = new System.Windows.Forms.TextBox();
            this.smtpPortTextBox = new System.Windows.Forms.TextBox();
            this.smtpServerTextbox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.smtpLabel = new System.Windows.Forms.Label();
            this.smtpPortLabel = new System.Windows.Forms.Label();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailAddressTextbox
            // 
            this.emailAddressTextbox.Location = new System.Drawing.Point(90, 47);
            this.emailAddressTextbox.Name = "emailAddressTextbox";
            this.emailAddressTextbox.Size = new System.Drawing.Size(208, 29);
            this.emailAddressTextbox.TabIndex = 0;
            // 
            // smtpPortTextBox
            // 
            this.smtpPortTextBox.Location = new System.Drawing.Point(90, 175);
            this.smtpPortTextBox.Name = "smtpPortTextBox";
            this.smtpPortTextBox.Size = new System.Drawing.Size(208, 29);
            this.smtpPortTextBox.TabIndex = 1;
            // 
            // smtpServerTextbox
            // 
            this.smtpServerTextbox.Location = new System.Drawing.Point(90, 112);
            this.smtpServerTextbox.Name = "smtpServerTextbox";
            this.smtpServerTextbox.Size = new System.Drawing.Size(208, 29);
            this.smtpServerTextbox.TabIndex = 2;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(86, 23);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(108, 21);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email Address";
            // 
            // smtpLabel
            // 
            this.smtpLabel.AutoSize = true;
            this.smtpLabel.Location = new System.Drawing.Point(86, 88);
            this.smtpLabel.Name = "smtpLabel";
            this.smtpLabel.Size = new System.Drawing.Size(96, 21);
            this.smtpLabel.TabIndex = 4;
            this.smtpLabel.Text = "Smtp Server";
            // 
            // smtpPortLabel
            // 
            this.smtpPortLabel.AutoSize = true;
            this.smtpPortLabel.Location = new System.Drawing.Point(86, 151);
            this.smtpPortLabel.Name = "smtpPortLabel";
            this.smtpPortLabel.Size = new System.Drawing.Size(79, 21);
            this.smtpPortLabel.TabIndex = 5;
            this.smtpPortLabel.Text = "Smtp Port";
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.saveSettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.saveSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSettingsButton.ForeColor = System.Drawing.Color.Black;
            this.saveSettingsButton.Location = new System.Drawing.Point(124, 245);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(141, 45);
            this.saveSettingsButton.TabIndex = 11;
            this.saveSettingsButton.Text = "Save Settings";
            this.saveSettingsButton.UseVisualStyleBackColor = false;
            // 
            // EmailrSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 351);
            this.Controls.Add(this.saveSettingsButton);
            this.Controls.Add(this.smtpPortLabel);
            this.Controls.Add(this.smtpLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.smtpServerTextbox);
            this.Controls.Add(this.smtpPortTextBox);
            this.Controls.Add(this.emailAddressTextbox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "EmailrSettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailAddressTextbox;
        private System.Windows.Forms.TextBox smtpPortTextBox;
        private System.Windows.Forms.TextBox smtpServerTextbox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label smtpLabel;
        private System.Windows.Forms.Label smtpPortLabel;
        private System.Windows.Forms.Button saveSettingsButton;
    }
}