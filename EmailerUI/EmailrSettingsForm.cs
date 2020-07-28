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
    public partial class EmailrSettingsForm : Form
    {
        public EmailrSettingsForm()
        {
            InitializeComponent();
            LoadSettings();
        }

        public void LoadSettings()
        {
            emailAddressTextbox.Text = Properties.Settings.Default.email;
            smtpServerTextbox.Text = Properties.Settings.Default.smtp;
            smtpPortTextBox.Text = Properties.Settings.Default.smtpPort.ToString();
        }
        public bool ValidateSettings()
        {
            try
            {
                MailAddress m = new MailAddress(emailAddressTextbox.Text);
                Properties.Settings.Default.email = emailAddressTextbox.Text;
            }
            catch (Exception)
            {
                logLabel.Text = "Enter valid email address";
                logLabel.ForeColor = Color.Red;
                
                return false;
            }

            Properties.Settings.Default.smtp = smtpServerTextbox.Text;

            try
            {
                int port = int.Parse(smtpPortTextBox.Text);
                Properties.Settings.Default.smtpPort = port.ToString();
            }
            catch (Exception)
            {
                logLabel.Text = "Port can only contain numbers.";
                logLabel.ForeColor = Color.Red;
                
                return false;
            }

            return true;
        }
        public void SaveSettings()
        {
            Properties.Settings.Default.Save();
            logLabel.Text = "Save Complete";
            logLabel.ForeColor = Color.Green;
            logLabel.Refresh();
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            if (ValidateSettings())
            {
                SaveSettings();
                Thread.Sleep(500);
                this.Close();
            }
        }

        private void EmailrSettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            EmailrStartForm.esf = null;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Are you sure? This will reset the Application.", "Confirm reset", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                logLabel.Text = "Application will reset after restart.";
                logLabel.ForeColor = Color.Red;
                EmailrStartForm.LogLabel(logLabel, "Application will reset after restart.", Color.Red);
                Thread.Sleep(500);
                this.Close();
            }
        }
    }
}
