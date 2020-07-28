using EmailrLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailerUI
{
    public partial class EmailrComposeForm : Form
    {
        EmailModel em;
        BindingList<string> filePaths;

        public EmailrComposeForm()
        {
            InitializeComponent();
            LoadSettings();
            WireUpLists();
        }
        public void WireUpLists()
        {
            if (Properties.Settings.Default.emailContent != null)
            {
                filePaths = new BindingList<string>(Properties.Settings.Default.emailContent.Attachements);
            }
            else
            {
                filePaths = new BindingList<string>();
            }
            filePathsListbox.DataSource = filePaths;
        }

        public void LoadSettings()
        {
            em = Properties.Settings.Default.emailContent;
            if (em != null)
            {
                yearTextbox.Text = em.Year;
                monthTextbox.Text = em.Month;
                fromTextbox.Text = em.From;
                subjectTextbox.Text = em.Subject;
                composeEmailTextbox.Text = em.Content;
                logoPathTextbox.Text = em.Image;
            }

            replacementPanel.Visible = false;


            editTextbox.Visible = false;
            saveEditButton.Visible = false;
        }
        public void SaveEmail()
        {
            em = new EmailModel(yearTextbox.Text,
                monthTextbox.Text,
                fromTextbox.Text,
                subjectTextbox.Text,
                composeEmailTextbox.Text,
                filePaths.ToList(),
                logoPathTextbox.Text);

            Properties.Settings.Default.emailContent = em;
            Properties.Settings.Default.Save();
        }

        private bool ValidateForm()
        {
            if (yearTextbox.Text.Length == 0 || !int.TryParse(yearTextbox.Text, out int year))
            {
                logLabel.Text = "Enter a valid year number.";
                logLabel.ForeColor = Color.Red;
                return false;
            }

            if (monthTextbox.Text.Length == 0 || !int.TryParse(monthTextbox.Text, out int _))
            {
                logLabel.Text = "Enter a valid month number.";
                logLabel.ForeColor = Color.Red;
                return false;
            }

            if (fromTextbox.Text.Length == 0)
            {
                logLabel.Text = "Enter a valid sender name.";
                logLabel.ForeColor = Color.Red;
                return false;
            }

            if (subjectTextbox.Text.Length == 0)
            {
                logLabel.Text = "Enter a valid subject.";
                logLabel.ForeColor = Color.Red;
                return false;
            }

            return true;
        }
        private void saveEmailButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveEmail();

                EmailrStartForm parent = (EmailrStartForm)Owner;

                parent.InitializeMailSettings();

                logLabel.Text = "Save ok.";
                logLabel.ForeColor = Color.Green;
                logLabel.Refresh();

                Thread.Sleep(500);

                this.Close();
            }
            
        }

        private void addPathsButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.InitialDirectory = "C:\\";
                file.Filter = "All files(*.*)|*.*";
                file.FilterIndex = 0;

                if (file.ShowDialog() == DialogResult.OK)
                {
                    filePaths.Add(file.FileName);
                }
            }
        }

        private void removePathButton_Click(object sender, EventArgs e)
        {
            if (filePathsListbox.SelectedItem != null)
            {
                filePaths.Remove((string)filePathsListbox.SelectedItem);
            }
        }

        private void editPathButton_Click(object sender, EventArgs e)
        {
            if (filePathsListbox.SelectedItem != null)
            {
                addPathsButton.Hide();
                removePathButton.Hide();
                editPathButton.Hide();
                editTextbox.Show();
                saveEditButton.Show();

                editTextbox.Text = (string)filePathsListbox.SelectedItem;
            }
        }

        private void saveEditButton_Click(object sender, EventArgs e)
        {
            string t = (string)filePathsListbox.SelectedItem;
            filePaths.Remove(t);
            filePaths.Add(editTextbox.Text);

            addPathsButton.Show();
            removePathButton.Show();
            editPathButton.Show();
            editTextbox.Hide();
            saveEditButton.Hide();
        }

        private void addLogoButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog img = new OpenFileDialog())
            {
                img.InitialDirectory = "C:\\";
                img.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                img.FilterIndex = 0;

                if (img.ShowDialog() == DialogResult.OK)
                {
                    logoPathTextbox.Text = img.FileName;
                }
            }
        }

        private void keywordsButton_Click(object sender, EventArgs e)
        {
            if (replacementPanel.Visible)
            {
                replacementPanel.Hide();
            }
            else
            {
                replacementPanel.Show();
            }
            
        }

        private void EmailrComposeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            EmailrStartForm.ecf = null;
        }
    }
}
