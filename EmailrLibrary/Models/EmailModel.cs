using EmailrLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EmailrLibrary.Models
{
    [Serializable]
    public class EmailModel
    {
        public string Year { get; set; } = "";
        public string Month { get; set; } = "";
        public string From { get; set; } = "";
        public string Subject { get; set; } = "";
        public string Content { get; set; } = "";
        public List<string> Attachements { get; set; }
        public string Image { get; set; } = "";
        public EmailModel()
        {

        }
        public EmailModel(string year, string month, string from, string subject, string content, List<string> attachement, string img)
        {
            Year = year;
            Month = month;
            From = from;
            Subject = subject;
            Content = content;
            Attachements = attachement;
            Image = img;
        }
    }
}
