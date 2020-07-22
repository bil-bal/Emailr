using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailerUI
{
    public partial class EmailrStartForm : Form
    {
        public EmailrStartForm()
        {
            InitializeComponent();
            InitializePasswordBox();
            //TestWebbrowser();
            
        }

        private void InitializePasswordBox()
        {
            passwordBox.Text = "";
            passwordBox.PasswordChar = '*';
        }

        private void TestWebbrowser()
        {
            emailHtmlPreviewBrowser.AllowNavigation = false;
            emailHtmlPreviewBrowser.AllowWebBrowserDrop = false;
            emailHtmlPreviewBrowser.Url = new Uri(@"D:\Backup\Projects\html.html");
        }
    }
}
