using EmailrLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmailrLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        public void CreatePerson(List<PersonModel> addList, List<PersonModel> removeList)
        {
            List<PersonModel> people = GlobalConfig.PersonFile.FullFilePath().LoadFile().ConvertToPersonModel();

            if (removeList != null || removeList.Count != 0)
            {
                people = RemovePersonFromList(removeList);
            }

            int currentId = 1;

            foreach (PersonModel p in addList)
            {
                if (people.Count > 0)
                {
                    currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
                }

                p.Id = currentId;

                people.Add(p);

                people.SaveToPersonFile();
            }
        }

        public void CreateTeam(List<TeamModel> addList, List<TeamModel> removeList)
        {
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModel();

            if (removeList != null)
            {
                if (removeList.Count != 0)
                {
                    teams = RemoveTeamFromList(removeList);
                }
            }

            int currentId = 1;

            foreach (TeamModel tm in addList)
            {
                if (teams.Count > 0)
                {
                    currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
                }

                tm.Id = currentId;

                teams.Add(tm);

                teams.SaveToTeamFile();
            }
            
        }

        public List<PersonModel> RemovePersonFromList(List<PersonModel> list)
        {
            List<PersonModel> people = GlobalConfig.PersonFile.FullFilePath().LoadFile().ConvertToPersonModel();
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModel();

            foreach (PersonModel p in list)
            {
                people.Remove(people.Where(x => x.Id == p.Id).First());

                foreach (TeamModel tm in teams)
                {
                    tm.TeamMembers.RemoveAt(tm.TeamMembers.FindIndex(x => x.Id == p.Id));
                }
            }

            people.SaveToPersonFile();
            teams.SaveToTeamFile();
            return people;
        }

        public List<TeamModel> RemoveTeamFromList(List<TeamModel> list)
        {
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModel();

            foreach (TeamModel tm in list)
            {
                teams.Remove(teams.Where(x => x.Id == tm.Id).First());
            }

            teams.SaveToTeamFile();

            return teams;
        }

        public void RemoveTeamMemberFromList(PersonModel p, TeamModel tm)
        {
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModel();

            int tIndex = teams.FindIndex(a => a.Id == tm.Id);

            int pIndex = teams[tIndex].TeamMembers.FindIndex(a => a.Id == p.Id);

            teams[tIndex].TeamMembers.RemoveAt(pIndex);

            teams.SaveToTeamFile();
        }
    }
}
