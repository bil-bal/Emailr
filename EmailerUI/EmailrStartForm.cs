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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailerUI
{
    public partial class EmailrStartForm : Form
    {
        public static BindingList<PersonModel> employeeList;
        public static BindingList<TeamModel> teamList;

        public static EmailrComposeForm ecf;
        public static EmailrSettingsForm esf;
        public static EmailrModifyListForm emf;

        public EmailrStartForm()
        {
            InitializeComponent();
            LoadLists();
            teamListbox.Hide();
            InitializePasswordBox();
            InitializeMailSettings();
            WireUpLists();
        }
        
        public static void LoadLists()
        {
            employeeList = new BindingList<PersonModel>(GlobalConfig.PersonFile.FullFilePath().LoadFile().ConvertToPersonModel());
            teamList = new BindingList<TeamModel>(GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModel());
        }

        public void WireUpLists()
        {
            employeeListbox.DataSource = employeeList;
            employeeListbox.DisplayMember = "FullName";
            employeeListbox.ClearSelected();

            teamListbox.DataSource = teamList;
            teamListbox.DisplayMember = "TeamName";
            teamListbox.ClearSelected();

            logListbox.DataSource = EmailLogic.logs;
        }

        private void InitializePasswordBox()
        {
            passwordBox.Text = "";
        }

        public void InitializeMailSettings()
        {
            emailHtmlPreviewBrowser.AllowNavigation = false;
            emailHtmlPreviewBrowser.AllowWebBrowserDrop = false;

            if (Properties.Settings.Default.emailContent != null)
            {
                EmailModel em = Properties.Settings.Default.emailContent;
                fromTextbox.Text = $"{em.From} @ {Properties.Settings.Default.email}";
                subjectTextbox.Text = em.Subject;
                emailHtmlPreviewBrowser.Navigate("about:blank");
                emailHtmlPreviewBrowser.Document.OpenNew(false);
                emailHtmlPreviewBrowser.Document.Write(em.Content);
                emailHtmlPreviewBrowser.Refresh();
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            if (esf == null)
            {
                esf = new EmailrSettingsForm();
                esf.Show();
            }
            else
            {
                esf.BringToFront();
            }
        }

        private void composeEmailButton_Click(object sender, EventArgs e)
        {
            if (ecf == null)
            {
                ecf = new EmailrComposeForm();
                ecf.Show(this);
            }
            else
            {
                ecf.BringToFront();
            }
        }

        private void modifyEmailToButton_Click(object sender, EventArgs e)
        {
            if (emf == null)
            {
                emf = new EmailrModifyListForm();
                emf.Show();
            }
            else
            {
                emf.BringToFront();
            }
        }

        private void sendToTeamsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (sendToTeamsCheckbox.Checked)
            {
                employeeListbox.Hide();
                teamListbox.Show();
            }
            else
            {
                employeeListbox.Show();
                teamListbox.Hide();
            }
        }

        private void sendEmailsButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.emailContent == null)
            {
                LogLabel(logLabel, "Compose email first.", Color.Red);

                return;
            }

            if (employeeList.Count == 0)
            {
                LogLabel(logLabel, "Add employee to list first.", Color.Red);

                return;
            }

            if (passwordBox.TextLength == 0)
            {
                LogLabel(logLabel, "Enter password.", Color.Red);

                return;
            }

            

            List<PersonModel> selectedEmployees = new List<PersonModel>();

            if (!sendToTeamsCheckbox.Checked)
            {
                if (employeeListbox.SelectedItems.Count == 0)
                {
                    selectedEmployees = employeeList.ToList();
                } 
                else
                {
                    foreach (PersonModel item in employeeListbox.SelectedItems)
                    {
                        selectedEmployees.Add(item);
                    }
                }
            }
            else
            {
                List<TeamModel> selectedTeams = new List<TeamModel>();

                if (teamListbox.SelectedItems.Count == 0)
                {
                    selectedTeams = teamList.ToList();
                }
                else
                {
                    foreach (TeamModel t in teamListbox.SelectedItems)
                    {
                        foreach (PersonModel p in t.TeamMembers)
                        {
                            selectedEmployees.Add(p);
                        }
                    }
                }
            }

            try
            {
                using (SmtpClient smtp = EmailLogic.CreateSmtp(Properties.Settings.Default.smtp,
                int.Parse(Properties.Settings.Default.smtpPort), Properties.Settings.Default.email, passwordBox.Text))
                {
                    foreach (PersonModel p in selectedEmployees)
                    {
                        EmailLogic.logs.Add($"Sending Email to {p.FullName}");
                        logListbox.Refresh();
                        logListbox.TopIndex = logListbox.Items.Count - 1;

                        EmailLogic.logs.Add(EmailLogic.SendEmail(Properties.Settings.Default.emailContent, p, smtp, Properties.Settings.Default.email));
                        logListbox.Refresh();
                        logListbox.TopIndex = logListbox.Items.Count - 1;
                    }
                }
            }
            catch (Exception exc)
            {
                EmailLogic.logs.Add("Something went wrong. ");
                EmailLogic.logs.Add(exc.Message);
                
                logListbox.Refresh();
                logListbox.TopIndex = logListbox.Items.Count - 1;
            }
            
            passwordBox.Text = "";
        }

        public static void LogLabel(System.Windows.Forms.Label logLabel, string text, Color color)
        {
            logLabel.Text = text;
            logLabel.ForeColor = color;
            logLabel.Refresh();
        }
    }
}
