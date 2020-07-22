using EmailrLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailrLibrary.Models
{
    public class EmailModel
    {
        public string Year { get; set; }
        public string Month { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string MyProperty { get; set; }
        public HtmlModel Content { get; set; }
    }
}
