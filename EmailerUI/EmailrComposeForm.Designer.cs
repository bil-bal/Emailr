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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailrComposeForm));
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
            this.filePathsListbox = new System.Windows.Forms.ListBox();
            this.addPathsButton = new System.Windows.Forms.Button();
            this.editPathButton = new System.Windows.Forms.Button();
            this.removePathButton = new System.Windows.Forms.Button();
            this.editTextbox = new System.Windows.Forms.TextBox();
            this.saveEditButton = new System.Windows.Forms.Button();
            this.logoPathTextbox = new System.Windows.Forms.TextBox();
            this.addLogoButton = new System.Windows.Forms.Button();
            this.logLabel = new System.Windows.Forms.Label();
            this.keywordsButton = new System.Windows.Forms.Button();
            this.replacementPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rPersonalIdLabel = new System.Windows.Forms.Label();
            this.rLastNameLabel = new System.Windows.Forms.Label();
            this.rFirstnameLabel = new System.Windows.Forms.Label();
            this.rFromLabel = new System.Windows.Forms.Label();
            this.rMonthLabel = new System.Windows.Forms.Label();
            this.rYearLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.replacementPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // yearTextbox
            // 
            this.yearTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.yearTextbox.Location = new System.Drawing.Point(44, 33);
            this.yearTextbox.Name = "yearTextbox";
            this.yearTextbox.Size = new System.Drawing.Size(202, 29);
            this.yearTextbox.TabIndex = 0;
            // 
            // monthTextbox
            // 
            this.monthTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monthTextbox.Location = new System.Drawing.Point(281, 33);
            this.monthTextbox.Name = "monthTextbox";
            this.monthTextbox.Size = new System.Drawing.Size(202, 29);
            this.monthTextbox.TabIndex = 1;
            // 
            // fromTextbox
            // 
            this.fromTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fromTextbox.Location = new System.Drawing.Point(44, 92);
            this.fromTextbox.Name = "fromTextbox";
            this.fromTextbox.Size = new System.Drawing.Size(202, 29);
            this.fromTextbox.TabIndex = 2;
            // 
            // subjectTextbox
            // 
            this.subjectTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.subjectTextbox.Location = new System.Drawing.Point(281, 92);
            this.subjectTextbox.Name = "subjectTextbox";
            this.subjectTextbox.Size = new System.Drawing.Size(202, 29);
            this.subjectTextbox.TabIndex = 3;
            // 
            // yearLabel
            // 
            this.yearLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(40, 9);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(40, 21);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Year";
            // 
            // monthLabel
            // 
            this.monthLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(277, 9);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(56, 21);
            this.monthLabel.TabIndex = 5;
            this.monthLabel.Text = "Month";
            // 
            // fromLabel
            // 
            this.fromLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(40, 68);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(47, 21);
            this.fromLabel.TabIndex = 6;
            this.fromLabel.Text = "From";
            // 
            // subjectLabel
            // 
            this.subjectLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(277, 68);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(61, 21);
            this.subjectLabel.TabIndex = 7;
            this.subjectLabel.Text = "Subject";
            // 
            // composeEmailTextbox
            // 
            this.composeEmailTextbox.AcceptsTab = true;
            this.composeEmailTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.composeEmailTextbox.Location = new System.Drawing.Point(12, 231);
            this.composeEmailTextbox.Name = "composeEmailTextbox";
            this.composeEmailTextbox.Size = new System.Drawing.Size(987, 514);
            this.composeEmailTextbox.TabIndex = 4;
            this.composeEmailTextbox.Text = "";
            // 
            // saveEmailButton
            // 
            this.saveEmailButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveEmailButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveEmailButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.saveEmailButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.saveEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveEmailButton.ForeColor = System.Drawing.Color.Black;
            this.saveEmailButton.Location = new System.Drawing.Point(451, 763);
            this.saveEmailButton.Name = "saveEmailButton";
            this.saveEmailButton.Size = new System.Drawing.Size(118, 34);
            this.saveEmailButton.TabIndex = 5;
            this.saveEmailButton.Text = "Save Email";
            this.saveEmailButton.UseVisualStyleBackColor = false;
            this.saveEmailButton.Click += new System.EventHandler(this.saveEmailButton_Click);
            // 
            // filePathsListbox
            // 
            this.filePathsListbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.filePathsListbox.FormattingEnabled = true;
            this.filePathsListbox.ItemHeight = 21;
            this.filePathsListbox.Location = new System.Drawing.Point(515, 12);
            this.filePathsListbox.Name = "filePathsListbox";
            this.filePathsListbox.Size = new System.Drawing.Size(462, 109);
            this.filePathsListbox.TabIndex = 8;
            // 
            // addPathsButton
            // 
            this.addPathsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addPathsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addPathsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addPathsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.addPathsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPathsButton.ForeColor = System.Drawing.Color.Black;
            this.addPathsButton.Location = new System.Drawing.Point(560, 133);
            this.addPathsButton.Name = "addPathsButton";
            this.addPathsButton.Size = new System.Drawing.Size(118, 34);
            this.addPathsButton.TabIndex = 9;
            this.addPathsButton.Text = "Add File";
            this.addPathsButton.UseVisualStyleBackColor = false;
            this.addPathsButton.Click += new System.EventHandler(this.addPathsButton_Click);
            // 
            // editPathButton
            // 
            this.editPathButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editPathButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editPathButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.editPathButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.editPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPathButton.ForeColor = System.Drawing.Color.Black;
            this.editPathButton.Location = new System.Drawing.Point(684, 133);
            this.editPathButton.Name = "editPathButton";
            this.editPathButton.Size = new System.Drawing.Size(118, 34);
            this.editPathButton.TabIndex = 10;
            this.editPathButton.Text = "Edit Path";
            this.editPathButton.UseVisualStyleBackColor = false;
            this.editPathButton.Click += new System.EventHandler(this.editPathButton_Click);
            // 
            // removePathButton
            // 
            this.removePathButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.removePathButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removePathButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.removePathButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.removePathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePathButton.ForeColor = System.Drawing.Color.Black;
            this.removePathButton.Location = new System.Drawing.Point(808, 133);
            this.removePathButton.Name = "removePathButton";
            this.removePathButton.Size = new System.Drawing.Size(118, 34);
            this.removePathButton.TabIndex = 11;
            this.removePathButton.Text = "Remove Path";
            this.removePathButton.UseVisualStyleBackColor = false;
            this.removePathButton.Click += new System.EventHandler(this.removePathButton_Click);
            // 
            // editTextbox
            // 
            this.editTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editTextbox.Location = new System.Drawing.Point(515, 138);
            this.editTextbox.Name = "editTextbox";
            this.editTextbox.Size = new System.Drawing.Size(410, 29);
            this.editTextbox.TabIndex = 12;
            // 
            // saveEditButton
            // 
            this.saveEditButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveEditButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveEditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.saveEditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.saveEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveEditButton.ForeColor = System.Drawing.Color.Black;
            this.saveEditButton.Location = new System.Drawing.Point(932, 138);
            this.saveEditButton.Name = "saveEditButton";
            this.saveEditButton.Size = new System.Drawing.Size(45, 29);
            this.saveEditButton.TabIndex = 13;
            this.saveEditButton.Text = "✓";
            this.saveEditButton.UseVisualStyleBackColor = false;
            this.saveEditButton.Click += new System.EventHandler(this.saveEditButton_Click);
            // 
            // logoPathTextbox
            // 
            this.logoPathTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logoPathTextbox.Location = new System.Drawing.Point(515, 182);
            this.logoPathTextbox.Name = "logoPathTextbox";
            this.logoPathTextbox.Size = new System.Drawing.Size(347, 29);
            this.logoPathTextbox.TabIndex = 12;
            // 
            // addLogoButton
            // 
            this.addLogoButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addLogoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addLogoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addLogoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.addLogoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLogoButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.addLogoButton.ForeColor = System.Drawing.Color.Black;
            this.addLogoButton.Location = new System.Drawing.Point(868, 182);
            this.addLogoButton.Name = "addLogoButton";
            this.addLogoButton.Size = new System.Drawing.Size(108, 29);
            this.addLogoButton.TabIndex = 13;
            this.addLogoButton.Text = "Add Logo";
            this.addLogoButton.UseVisualStyleBackColor = false;
            this.addLogoButton.Click += new System.EventHandler(this.addLogoButton_Click);
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(40, 136);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(0, 21);
            this.logLabel.TabIndex = 14;
            // 
            // keywordsButton
            // 
            this.keywordsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.keywordsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.keywordsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.keywordsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.keywordsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keywordsButton.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.keywordsButton.ForeColor = System.Drawing.Color.Black;
            this.keywordsButton.Location = new System.Drawing.Point(281, 183);
            this.keywordsButton.Name = "keywordsButton";
            this.keywordsButton.Size = new System.Drawing.Size(202, 29);
            this.keywordsButton.TabIndex = 15;
            this.keywordsButton.Text = "Toggle Replacement Keywords";
            this.keywordsButton.UseVisualStyleBackColor = false;
            this.keywordsButton.Click += new System.EventHandler(this.keywordsButton_Click);
            // 
            // replacementPanel
            // 
            this.replacementPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.replacementPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.replacementPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.replacementPanel.Controls.Add(this.label1);
            this.replacementPanel.Controls.Add(this.rPersonalIdLabel);
            this.replacementPanel.Controls.Add(this.rLastNameLabel);
            this.replacementPanel.Controls.Add(this.rFirstnameLabel);
            this.replacementPanel.Controls.Add(this.rFromLabel);
            this.replacementPanel.Controls.Add(this.rMonthLabel);
            this.replacementPanel.Controls.Add(this.rYearLabel);
            this.replacementPanel.Location = new System.Drawing.Point(281, 3);
            this.replacementPanel.Name = "replacementPanel";
            this.replacementPanel.Size = new System.Drawing.Size(296, 174);
            this.replacementPanel.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Replaced in: File Paths, Subject, Email Body";
            // 
            // rPersonalIdLabel
            // 
            this.rPersonalIdLabel.AutoSize = true;
            this.rPersonalIdLabel.Location = new System.Drawing.Point(12, 142);
            this.rPersonalIdLabel.Name = "rPersonalIdLabel";
            this.rPersonalIdLabel.Size = new System.Drawing.Size(270, 21);
            this.rPersonalIdLabel.TabIndex = 5;
            this.rPersonalIdLabel.Text = "-personaldid- replaced by Personal ID";
            // 
            // rLastNameLabel
            // 
            this.rLastNameLabel.AutoSize = true;
            this.rLastNameLabel.Location = new System.Drawing.Point(12, 121);
            this.rLastNameLabel.Name = "rLastNameLabel";
            this.rLastNameLabel.Size = new System.Drawing.Size(247, 21);
            this.rLastNameLabel.TabIndex = 4;
            this.rLastNameLabel.Text = "-lastname- replaced by Last Name";
            // 
            // rFirstnameLabel
            // 
            this.rFirstnameLabel.AutoSize = true;
            this.rFirstnameLabel.Location = new System.Drawing.Point(12, 100);
            this.rFirstnameLabel.Name = "rFirstnameLabel";
            this.rFirstnameLabel.Size = new System.Drawing.Size(252, 21);
            this.rFirstnameLabel.TabIndex = 3;
            this.rFirstnameLabel.Text = "-firstname- replaced by First Name";
            // 
            // rFromLabel
            // 
            this.rFromLabel.AutoSize = true;
            this.rFromLabel.Location = new System.Drawing.Point(12, 79);
            this.rFromLabel.Name = "rFromLabel";
            this.rFromLabel.Size = new System.Drawing.Size(181, 21);
            this.rFromLabel.TabIndex = 2;
            this.rFromLabel.Text = "-from- replaced by From";
            this.rFromLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rMonthLabel
            // 
            this.rMonthLabel.AutoSize = true;
            this.rMonthLabel.Location = new System.Drawing.Point(12, 58);
            this.rMonthLabel.Name = "rMonthLabel";
            this.rMonthLabel.Size = new System.Drawing.Size(202, 21);
            this.rMonthLabel.TabIndex = 1;
            this.rMonthLabel.Text = "-month- replaced by Month";
            // 
            // rYearLabel
            // 
            this.rYearLabel.AutoSize = true;
            this.rYearLabel.Location = new System.Drawing.Point(12, 37);
            this.rYearLabel.Name = "rYearLabel";
            this.rYearLabel.Size = new System.Drawing.Size(170, 21);
            this.rYearLabel.TabIndex = 0;
            this.rYearLabel.Text = "-year- replaced by Year";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label2.Location = new System.Drawing.Point(512, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Content Imaged ID for <img> tag: \"companyLogo\"";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EmailrComposeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 839);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.replacementPanel);
            this.Controls.Add(this.keywordsButton);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.addLogoButton);
            this.Controls.Add(this.saveEditButton);
            this.Controls.Add(this.logoPathTextbox);
            this.Controls.Add(this.editTextbox);
            this.Controls.Add(this.removePathButton);
            this.Controls.Add(this.editPathButton);
            this.Controls.Add(this.addPathsButton);
            this.Controls.Add(this.filePathsListbox);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1027, 835);
            this.Name = "EmailrComposeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compose Email";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmailrComposeForm_FormClosed);
            this.replacementPanel.ResumeLayout(false);
            this.replacementPanel.PerformLayout();
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
        private System.Windows.Forms.ListBox filePathsListbox;
        private System.Windows.Forms.Button addPathsButton;
        private System.Windows.Forms.Button editPathButton;
        private System.Windows.Forms.Button removePathButton;
        private System.Windows.Forms.TextBox editTextbox;
        private System.Windows.Forms.Button saveEditButton;
        private System.Windows.Forms.TextBox logoPathTextbox;
        private System.Windows.Forms.Button addLogoButton;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.Button keywordsButton;
        private System.Windows.Forms.Panel replacementPanel;
        private System.Windows.Forms.Label rPersonalIdLabel;
        private System.Windows.Forms.Label rLastNameLabel;
        private System.Windows.Forms.Label rFirstnameLabel;
        private System.Windows.Forms.Label rFromLabel;
        private System.Windows.Forms.Label rMonthLabel;
        private System.Windows.Forms.Label rYearLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}