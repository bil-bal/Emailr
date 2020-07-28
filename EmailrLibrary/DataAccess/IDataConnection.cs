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
        void CreatePerson(List<PersonModel> addList, List<PersonModel> removeList);
        void CreateTeam(List<TeamModel> addList, List<TeamModel> removeList);
        List<PersonModel> RemovePersonFromList(List<PersonModel> list);
        List<TeamModel> RemoveTeamFromList(List<TeamModel> list);
        void RemoveTeamMemberFromList(PersonModel p, TeamModel tm);
    }
}
