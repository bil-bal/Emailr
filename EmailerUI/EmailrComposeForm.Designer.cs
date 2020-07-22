namespace EmailerUI
{
    partial class EmailrComposeForm
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
            this.yearTextbox = new System.Windows.Forms.TextBox();
            this.monthTextbox = new System.Windows.Forms.TextBox();
            this.fromTextbox = new System.Windows.Forms.TextBox();
            this.subjectTextbox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.composeEmailTextbox = new System.Windows.Forms.RichTextBox();
            this.saveEmailButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yearTextbox
            // 
            this.yearTextbox.Location = new System.Drawing.Point(111, 51);
            this.yearTextbox.Name = "yearTextbox";
            this.yearTextbox.Size = new System.Drawing.Size(202, 29);
            this.yearTextbox.TabIndex = 0;
            // 
            // monthTextbox
            // 
            this.monthTextbox.Location = new System.Drawing.Point(111, 110);
            this.monthTextbox.Name = "monthTextbox";
            this.monthTextbox.Size = new System.Drawing.Size(202, 29);
            this.monthTextbox.TabIndex = 1;
            // 
            // fromTextbox
            // 
            this.fromTextbox.Location = new System.Drawing.Point(348, 51);
            this.fromTextbox.Name = "fromTextbox";
            this.fromTextbox.Size = new System.Drawing.Size(202, 29);
            this.fromTextbox.TabIndex = 2;
            // 
            // subjectTextbox
            // 
            this.subjectTextbox.Location = new System.Drawing.Point(348, 110);
            this.subjectTextbox.Name = "subjectTextbox";
            this.subjectTextbox.Size = new System.Drawing.Size(202, 29);
            this.subjectTextbox.TabIndex = 3;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(107, 27);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(40, 21);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Year";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(107, 86);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(56, 21);
            this.monthLabel.TabIndex = 5;
            this.monthLabel.Text = "Month";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(344, 27);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(47, 21);
            this.fromLabel.TabIndex = 6;
            this.fromLabel.Text = "From";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(344, 86);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(61, 21);
            this.subjectLabel.TabIndex = 7;
            this.subjectLabel.Text = "Subject";
            // 
            // composeEmailTextbox
            // 
            this.composeEmailTextbox.Location = new System.Drawing.Point(12, 187);
            this.composeEmailTextbox.Name = "composeEmailTextbox";
            this.composeEmailTextbox.Size = new System.Drawing.Size(617, 407);
            this.composeEmailTextbox.TabIndex = 8;
            this.composeEmailTextbox.Text = "";
            // 
            // saveEmailButton
            // 
            this.saveEmailButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.saveEmailButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.saveEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveEmailButton.ForeColor = System.Drawing.Color.Black;
            this.saveEmailButton.Location = new System.Drawing.Point(273, 615);
            this.saveEmailButton.Name = "saveEmailButton";
            this.saveEmailButton.Size = new System.Drawing.Size(118, 34);
            this.saveEmailButton.TabIndex = 11;
            this.saveEmailButton.Text = "Save Email";
            this.saveEmailButton.UseVisualStyleBackColor = false;
            // 
            // EmailrComposeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 691);
            this.Controls.Add(this.saveEmailButton);
            this.Controls.Add(this.composeEmailTextbox);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.subjectTextbox);
            this.Controls.Add(this.fromTextbox);
            this.Controls.Add(this.monthTextbox);
            this.Controls.Add(this.yearTextbox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "EmailrComposeForm";
            this.Text = "Compose Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox yearTextbox;
        private System.Windows.Forms.TextBox monthTextbox;
        private System.Windows.Forms.TextBox subjectTextbox;
        private System.Windows.Forms.TextBox fromTextbox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.RichTextBox composeEmailTextbox;
        private System.Windows.Forms.Button saveEmailButton;
    }
}