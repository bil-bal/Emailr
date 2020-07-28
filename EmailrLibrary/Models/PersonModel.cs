using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailrLibrary.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PersonalId { get; set; }

        public PersonModel()
        {

        }

        public PersonModel(string emailAddress, string firstName, string lastName, string personalId)
        {
            EmailAddress = emailAddress;
            FirstName = firstName;
            LastName = lastName;
            PersonalId = personalId;
        }

        public string FullName
        {
            get
            {
                return $"{EmailAddress}, {FirstName} {LastName}, {PersonalId}";
            }
        }
    }
}
