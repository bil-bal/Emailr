using EmailrLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailrLibrary.DataAccess
{
    public interface IDataConnection
    {
        PersonModel CreatePerson(PersonModel model);
        TeamModel CreateTeam(TeamModel model);
        EmailModel CreateEmail(EmailModel model);

    }
}
