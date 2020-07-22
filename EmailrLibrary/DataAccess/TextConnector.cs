using EmailrLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailrLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        public EmailModel CreateEmail(EmailModel model)
        {
            throw new NotImplementedException();
        }

        public PersonModel CreatePerson(PersonModel model)
        {
            throw new NotImplementedException();
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            throw new NotImplementedException();
        }
    }
}
