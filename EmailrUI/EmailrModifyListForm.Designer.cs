namespace EmailrUI
{
    partial class EmailrModifyListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailrModifyListForm));
            this.employeeListbox = new System.Windows.Forms.ListBox();
            this.addEmployeeGroupbox = new System.Windows.Forms.GroupBox();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.personalIdLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.personalIdTextbox = new System.Windows.Forms.TextBox();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.emailAddressTextbox = new System.Windows.Forms.TextBox();
            this.deleteSelectedButton = new System.Windows.Forms.Button();
            this.showTeamsCheckbox = new System.Windows.Forms.CheckBox();
            this.createTeamGroupbox = new System.Windows.Forms.GroupBox();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.addEmployeeToTeamButton = new System.Windows.Forms.Button();
            this.addEmployeeLabel = new System.Windows.Forms.Label();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.teamNameTextbox = new System.Windows.Forms.TextBox();
            this.saveListsButton = new System.Windows.Forms.Button();
            this.teamListbox = new System.Windows.Forms.ListBox();
            this.selectedForTeamListbox = new System.Windows.Forms.ListBox();
            this.removeSelectedMfromTButton = new System.Windows.Forms.Button();
            this.teamListLabel = new System.Windows.Forms.Label();
            this.employeeInTeamListbox = new System.Windows.Forms.ListBox();
            this.logLabel = new System.Windows.Forms.Label();
            this.addEmployeeGroupbox.SuspendLayout();
            this.createTeamGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeListbox
            // 
            this.employeeListbox.FormattingEnabled = true;
            this.employeeListbox.ItemHeight = 21;
            this.employeeListbox.Location = new System.Drawing.Point(410, 46);
            this.employeeListbox.Name = "employeeListbox";
            this.employeeListbox.Size = new System.Drawing.Size(399, 256);
            this.employeeListbox.TabIndex = 1;
            // 
            // addEmployeeGroupbox
            // 
            this.addEmployeeGroupbox.Controls.Add(this.addEmployeeButton);
            this.addEmployeeGroupbox.Controls.Add(this.personalIdLabel);
            this.addEmployeeGroupbox.Controls.Add(this.lastNameLabel);
            this.addEmployeeGroupbox.Controls.Add(this.firstNameLabel);
            this.addEmployeeGroupbox.Controls.Add(this.emailAddressLabel);
            this.addEmployeeGroupbox.Controls.Add(this.personalIdTextbox);
            this.addEmployeeGroupbox.Controls.Add(this.lastNameTextbox);
            this.addEmployeeGroupbox.Controls.Add(this.firstNameTextbox);
            this.addEmployeeGroupbox.Controls.Add(this.emailAddressTextbox);
            this.addEmployeeGroupbox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeGroupbox.Location = new System.Drawing.Point(39, 46);
            this.addEmployeeGroupbox.Name = "addEmployeeGroupbox";
            this.addEmployeeGroupbox.Size = new System.Drawing.Size(317, 259);
            this.addEmployeeGroupbox.TabIndex = 2;
            this.addEmployeeGroupbox.TabStop = false;
            this.addEmployeeGroupbox.Text = "Add Employee";
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addEmployeeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.addEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployeeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeButton.ForeColor = System.Drawing.Color.Black;
            this.addEmployeeButton.Location = new System.Drawing.Point(97, 207);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(150, 34);
            this.addEmployeeButton.TabIndex = 12;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = false;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // personalIdLabel
            // 
            this.personalIdLabel.AutoSize = true;
            this.personalIdLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalIdLabel.Location = new System.Drawing.Point(6, 164);
            this.personalIdLabel.Name = "personalIdLabel";
            this.personalIdLabel.Size = new System.Drawing.Size(88, 21);
            this.personalIdLabel.TabIndex = 7;
            this.personalIdLabel.Text = "Personal ID";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(6, 119);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(84, 21);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(6, 76);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(86, 21);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "First Name";
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressLabel.Location = new System.Drawing.Point(6, 31);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(48, 21);
            this.emailAddressLabel.TabIndex = 4;
            this.emailAddressLabel.Text = "Email";
            // 
            // personalIdTextbox
            // 
            this.personalIdTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalIdTextbox.Location = new System.Drawing.Point(108, 161);
            this.personalIdTextbox.Name = "personalIdTextbox";
            this.personalIdTextbox.Size = new System.Drawing.Size(192, 29);
            this.personalIdTextbox.TabIndex = 3;
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextbox.Location = new System.Drawing.Point(108, 116);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(192, 29);
            this.lastNameTextbox.TabIndex = 2;
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextbox.Location = new System.Drawing.Point(108, 73);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(192, 29);
            this.firstNameTextbox.TabIndex = 1;
            // 
            // emailAddressTextbox
            // 
            this.emailAddressTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressTextbox.Location = new System.Drawing.Point(108, 28);
            this.emailAddressTextbox.Name = "emailAddressTextbox";
            this.emailAddressTextbox.Size = new System.Drawing.Size(192, 29);
            this.emailAddressTextbox.TabIndex = 0;
            // 
            // deleteSelectedButton
            // 
            this.deleteSelectedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.deleteSelectedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.deleteSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedButton.ForeColor = System.Drawing.Color.Black;
            this.deleteSelectedButton.Location = new System.Drawing.Point(829, 137);
            this.deleteSelectedButton.Name = "deleteSelectedButton";
            this.deleteSelectedButton.Size = new System.Drawing.Size(98, 77);
            this.deleteSelectedButton.TabIndex = 13;
            this.deleteSelectedButton.Text = "Delete Selected";
            this.deleteSelectedButton.UseVisualStyleBackColor = false;
            this.deleteSelectedButton.Click += new System.EventHandler(this.deleteSelectedButton_Click);
            // 
            // showTeamsCheckbox
            // 
            this.showTeamsCheckbox.AutoSize = true;
            this.showTeamsCheckbox.Location = new System.Drawing.Point(410, 12);
            this.showTeamsCheckbox.Name = "showTeamsCheckbox";
            this.showTeamsCheckbox.Size = new System.Drawing.Size(115, 25);
            this.showTeamsCheckbox.TabIndex = 14;
            this.showTeamsCheckbox.Text = "Show Teams";
            this.showTeamsCheckbox.UseVisualStyleBackColor = true;
            this.showTeamsCheckbox.CheckedChanged += new System.EventHandler(this.showTeamsCheckbox_CheckedChanged);
            // 
            // createTeamGroupbox
            // 
            this.createTeamGroupbox.Controls.Add(this.createTeamButton);
            this.createTeamGroupbox.Controls.Add(this.addEmployeeToTeamButton);
            this.createTeamGroupbox.Controls.Add(this.addEmployeeLabel);
            this.createTeamGroupbox.Controls.Add(this.teamNameLabel);
            this.createTeamGroupbox.Controls.Add(this.teamNameTextbox);
            this.createTeamGroupbox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamGroupbox.Location = new System.Drawing.Point(39, 326);
            this.createTeamGroupbox.Name = "createTeamGroupbox";
            this.createTeamGroupbox.Size = new System.Drawing.Size(317, 235);
            this.createTeamGroupbox.TabIndex = 15;
            this.createTeamGroupbox.TabStop = false;
            this.createTeamGroupbox.Text = "Create Team";
            // 
            // createTeamButton
            // 
            this.createTeamButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamButton.ForeColor = System.Drawing.Color.Black;
            this.createTeamButton.Location = new System.Drawing.Point(97, 172);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(150, 34);
            this.createTeamButton.TabIndex = 13;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = false;
            this.createTeamButton.Click += new System.EventHandler(this.createTeamButton_Click);
            // 
            // addEmployeeToTeamButton
            // 
            this.addEmployeeToTeamButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addEmployeeToTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.addEmployeeToTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployeeToTeamButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeToTeamButton.ForeColor = System.Drawing.Color.Black;
            this.addEmployeeToTeamButton.Location = new System.Drawing.Point(108, 90);
            this.addEmployeeToTeamButton.Name = "addEmployeeToTeamButton";
            this.addEmployeeToTeamButton.Size = new System.Drawing.Size(192, 33);
            this.addEmployeeToTeamButton.TabIndex = 13;
            this.addEmployeeToTeamButton.Text = "Add from list";
            this.addEmployeeToTeamButton.UseVisualStyleBackColor = false;
            this.addEmployeeToTeamButton.Click += new System.EventHandler(this.addEmployeeToTeamButton_Click);
            // 
            // addEmployeeLabel
            // 
            this.addEmployeeLabel.AutoSize = true;
            this.addEmployeeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeLabel.Location = new System.Drawing.Point(6, 96);
            this.addEmployeeLabel.Name = "addEmployeeLabel";
            this.addEmployeeLabel.Size = new System.Drawing.Size(38, 21);
            this.addEmployeeLabel.TabIndex = 3;
            this.addEmployeeLabel.Text = "Add";
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameLabel.Location = new System.Drawing.Point(6, 50);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(92, 21);
            this.teamNameLabel.TabIndex = 2;
            this.teamNameLabel.Text = "Team Name";
            // 
            // teamNameTextbox
            // 
            this.teamNameTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameTextbox.Location = new System.Drawing.Point(108, 47);
            this.teamNameTextbox.Name = "teamNameTextbox";
            this.teamNameTextbox.Size = new System.Drawing.Size(192, 29);
            this.teamNameTextbox.TabIndex = 1;
            // 
            // saveListsButton
            // 
            this.saveListsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.saveListsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.saveListsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveListsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveListsButton.ForeColor = System.Drawing.Color.Black;
            this.saveListsButton.Location = new System.Drawing.Point(383, 576);
            this.saveListsButton.Name = "saveListsButton";
            this.saveListsButton.Size = new System.Drawing.Size(175, 51);
            this.saveListsButton.TabIndex = 16;
            this.saveListsButton.Text = "Save";
            this.saveListsButton.UseVisualStyleBackColor = false;
            this.saveListsButton.Click += new System.EventHandler(this.saveListsButton_Click);
            // 
            // teamListbox
            // 
            this.teamListbox.FormattingEnabled = true;
            this.teamListbox.ItemHeight = 21;
            this.teamListbox.Location = new System.Drawing.Point(410, 46);
            this.teamListbox.Name = "teamListbox";
            this.teamListbox.Size = new System.Drawing.Size(399, 256);
            this.teamListbox.TabIndex = 17;
            this.teamListbox.SelectedIndexChanged += new System.EventHandler(this.teamListbox_SelectedIndexChanged);
            // 
            // selectedForTeamListbox
            // 
            this.selectedForTeamListbox.FormattingEnabled = true;
            this.selectedForTeamListbox.ItemHeight = 21;
            this.selectedForTeamListbox.Location = new System.Drawing.Point(410, 368);
            this.selectedForTeamListbox.Name = "selectedForTeamListbox";
            this.selectedForTeamListbox.Size = new System.Drawing.Size(399, 193);
            this.selectedForTeamListbox.TabIndex = 18;
            // 
            // removeSelectedMfromTButton
            // 
            this.removeSelectedMfromTButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.removeSelectedMfromTButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.removeSelectedMfromTButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedMfromTButton.ForeColor = System.Drawing.Color.Black;
            this.removeSelectedMfromTButton.Location = new System.Drawing.Point(829, 407);
            this.removeSelectedMfromTButton.Name = "removeSelectedMfromTButton";
            this.removeSelectedMfromTButton.Size = new System.Drawing.Size(98, 77);
            this.removeSelectedMfromTButton.TabIndex = 19;
            this.removeSelectedMfromTButton.Text = "Delete Selected";
            this.removeSelectedMfromTButton.UseVisualStyleBackColor = false;
            this.removeSelectedMfromTButton.Click += new System.EventHandler(this.removeSelectedMfromTButton_Click);
            // 
            // teamListLabel
            // 
            this.teamListLabel.AutoSize = true;
            this.teamListLabel.Location = new System.Drawing.Point(406, 344);
            this.teamListLabel.Name = "teamListLabel";
            this.teamListLabel.Size = new System.Drawing.Size(190, 21);
            this.teamListLabel.TabIndex = 20;
            this.teamListLabel.Text = "Employees to add to team";
            // 
            // employeeInTeamListbox
            // 
            this.employeeInTeamListbox.FormattingEnabled = true;
            this.employeeInTeamListbox.ItemHeight = 21;
            this.employeeInTeamListbox.Location = new System.Drawing.Point(410, 368);
            this.employeeInTeamListbox.Name = "employeeInTeamListbox";
            this.employeeInTeamListbox.Size = new System.Drawing.Size(399, 193);
            this.employeeInTeamListbox.TabIndex = 21;
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(45, 591);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(0, 21);
            this.logLabel.TabIndex = 22;
            // 
            // EmailrModifyListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 639);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.employeeInTeamListbox);
            this.Controls.Add(this.teamListLabel);
            this.Controls.Add(this.removeSelectedMfromTButton);
            this.Controls.Add(this.selectedForTeamListbox);
            this.Controls.Add(this.teamListbox);
            this.Controls.Add(this.saveListsButton);
            this.Controls.Add(this.createTeamGroupbox);
            this.Controls.Add(this.showTeamsCheckbox);
            this.Controls.Add(this.deleteSelectedButton);
            this.Controls.Add(this.addEmployeeGroupbox);
            this.Controls.Add(this.employeeListbox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "EmailrModifyListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Lists";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmailrModifyListForm_FormClosed);
            this.addEmployeeGroupbox.ResumeLayout(false);
            this.addEmployeeGroupbox.PerformLayout();
            this.createTeamGroupbox.ResumeLayout(false);
            this.createTeamGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox employeeListbox;
        private System.Windows.Forms.GroupBox addEmployeeGroupbox;
        private System.Windows.Forms.Label personalIdLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.TextBox personalIdTextbox;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.TextBox emailAddressTextbox;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button deleteSelectedButton;
        private System.Windows.Forms.CheckBox showTeamsCheckbox;
        private System.Windows.Forms.GroupBox createTeamGroupbox;
        private System.Windows.Forms.Label addEmployeeLabel;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.TextBox teamNameTextbox;
        private System.Windows.Forms.Button createTeamButton;
        private System.Windows.Forms.Button addEmployeeToTeamButton;
        private System.Windows.Forms.Button saveListsButton;
        private System.Windows.Forms.ListBox teamListbox;
        private System.Windows.Forms.ListBox selectedForTeamListbox;
        private System.Windows.Forms.Button removeSelectedMfromTButton;
        private System.Windows.Forms.Label teamListLabel;
        private System.Windows.Forms.ListBox employeeInTeamListbox;
        private System.Windows.Forms.Label logLabel;
    }
}