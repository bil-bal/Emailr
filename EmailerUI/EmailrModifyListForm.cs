using EmailrLibrary;
using EmailrLibrary.DataAccess;
using EmailrLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailerUI
{
    public partial class EmailrModifyListForm : Form
    {
        BindingList<PersonModel> employeeList = EmailrStartForm.employeeList;
        BindingList<TeamModel> teamList = EmailrStartForm.teamList;
        BindingList<PersonModel> teamMemberList = new BindingList<PersonModel>();
        List<PersonModel> employeeListTmp = new List<PersonModel>();
        List<TeamModel> teamListTmp = new List<TeamModel>();
        List<PersonModel> removeEmployeeList = new List<PersonModel>();
        List<TeamModel> removeTeamList = new List<TeamModel>();
        BindingList<PersonModel> pm = new BindingList<PersonModel>();

        public EmailrModifyListForm()
        {
            InitializeComponent();
            employeeInTeamListbox.Hide();
            teamListbox.Hide();
            WireUpLists();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            if (ValidateAddEmployee())
            {
                PersonModel m = new PersonModel(emailAddressTextbox.Text, firstNameTextbox.Text, lastNameTextbox.Text, personalIdTextbox.Text);
                employeeList.Add(m);
                employeeListTmp.Add(m);
                ClearText(emailAddressTextbox, firstNameTextbox, lastNameTextbox, personalIdTextbox);
                logLabel.Text = "Employee added.";
                logLabel.ForeColor = Color.Green;
            }
        }
        private bool ValidateAddTeam(List<PersonModel> tm)
        {

            if (teamNameTextbox.Text.Length == 0)
            {
                logLabel.Text = "Enter team name.";
                logLabel.ForeColor = Color.Red;
                return false;
            }

            if (tm.Count == 0)
            {
                logLabel.Text = "Add team members from list.";
                logLabel.ForeColor = Color.Red;
                return false;
            }
            return true;
        }
        private bool ValidateAddEmployee()
        {
            try
            {
                MailAddress m = new MailAddress(emailAddressTextbox.Text);
            }
            catch (Exception)
            {
                logLabel.Text = "Enter valid email address.";
                logLabel.ForeColor = Color.Red;
                return false;
            }

            if (firstNameTextbox.Text.Length == 0)
            {
                logLabel.Text = "Enter first name.";
                logLabel.ForeColor = Color.Red;
                return false;
            }

            if (lastNameTextbox.Text.Length == 0)
            {
                logLabel.Text = "Enter last name.";
                logLabel.ForeColor = Color.Red;
                return false;
            }

            if (personalIdTextbox.Text.Length == 0)
            {
                logLabel.Text = "Enter personal id.";
                logLabel.ForeColor = Color.Red;
                return false;
            }

            return true;
        }

        private void WireUpLists()
        {
            employeeListbox.DataSource = employeeList;
            employeeListbox.DisplayMember = "FullName";
            employeeListbox.ClearSelected();

            teamListbox.DataSource = teamList;
            teamListbox.DisplayMember = "TeamName";
            teamListbox.ClearSelected();

            selectedForTeamListbox.DataSource = teamMemberList;
            selectedForTeamListbox.DisplayMember = "FullName";
            selectedForTeamListbox.ClearSelected();


            employeeInTeamListbox.DataSource = pm;
            employeeInTeamListbox.DisplayMember = "FullName";
            employeeInTeamListbox.ClearSelected();
        }

        private void deleteSelectedButton_Click(object sender, EventArgs e)
        {
            if (!showTeamsCheckbox.Checked)
            {
                PersonModel p = (PersonModel)employeeListbox.SelectedItem;
                employeeList.Remove(p);
                removeEmployeeList.Add(p);

                foreach (TeamModel tm in teamList)
                {
                    int index = tm.TeamMembers.FindIndex(x => x.Id == p.Id);

                    if (index > 0)
                    {
                        tm.TeamMembers.RemoveAt(index);
                    }
                }
            }
            else
            {
                TeamModel t = (TeamModel)teamListbox.SelectedItem;
                teamList.Remove(t);
                removeTeamList.Add(t);
                pm.Clear();
            }

        }

        private void showTeamsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showTeamsCheckbox.Checked)
            {
                teamListLabel.Text = "Employees in team";
                selectedForTeamListbox.Hide();
                employeeInTeamListbox.Show();
                employeeListbox.Hide();
                teamListbox.Show();

                teamListbox.SelectedIndex = -1;
            }
            else
            {
                teamListLabel.Text = "Employees to add to team";
                employeeInTeamListbox.Hide();
                selectedForTeamListbox.Show();
                employeeListbox.Show();
                teamListbox.Hide();
            }
        }

        private void addEmployeeToTeamButton_Click(object sender, EventArgs e)
        {
            if (showTeamsCheckbox.Checked)
            {
                showTeamsCheckbox.Checked = false;
            }
            else
            {
                if (employeeListbox.SelectedItem != null)
                {
                    PersonModel p = (PersonModel)employeeListbox.SelectedItem;
                    teamMemberList.Add(p);
                }
            }
        }

        private void removeSelectedMfromTButton_Click(object sender, EventArgs e)
        {
            if (!showTeamsCheckbox.Checked)
            {
                if (selectedForTeamListbox.SelectedItem != null)
                {
                    PersonModel p = (PersonModel)selectedForTeamListbox.SelectedItem;
                    teamMemberList.Remove(p);
                }
            }
            else
            {
                if (employeeInTeamListbox.SelectedItem != null)
                {
                    PersonModel p = (PersonModel)employeeInTeamListbox.SelectedItem;
                    GlobalConfig.Connection.RemoveTeamMemberFromList(p, (TeamModel)teamListbox.SelectedItem);
                    EmailrStartForm.LoadLists();
                    pm.Remove(p);
                }
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            List<PersonModel> pm = teamMemberList.ToList();

            if (ValidateAddTeam(pm))
            {
                TeamModel tm = new TeamModel();

                tm.TeamName = teamNameTextbox.Text;
                tm.TeamMembers = pm;
                teamListTmp.Add(tm);
                teamList.Add(tm);

                ClearText(teamNameTextbox);

                logLabel.Text = "Team created.";
                logLabel.ForeColor = Color.Green;
            }
        }

        private void teamListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (teamListbox.SelectedItem != null)
            {
                pm.Clear();
                TeamModel tm = (TeamModel)teamListbox.SelectedItem;
                foreach (PersonModel p in tm.TeamMembers)
                {
                    pm.Add(p);
                }
            }
        }

        private void ClearText(params TextBox[] tb)
        {
            foreach (TextBox b in tb)
            {
                b.Text = "";
            }
        }   

        private void saveListsButton_Click(object sender, EventArgs e)
        {
            GlobalConfig.Connection.CreatePerson(employeeListTmp, removeEmployeeList);
            employeeListTmp.Clear();

            GlobalConfig.Connection.CreateTeam(teamListTmp, removeTeamList);
            teamListTmp.Clear();

            logLabel.Text = "Lists saved.";
            logLabel.ForeColor = Color.Green;
            logLabel.Refresh();

            Thread.Sleep(500);

            this.Close();
        }

        private void EmailrModifyListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            EmailrStartForm.emf = null;
        }
    }
}
