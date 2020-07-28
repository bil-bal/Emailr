using EmailrLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EmailrLibrary.DataAccess
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            string cd = Directory.GetCurrentDirectory();
            return $@"{cd}\{fileName}";
        }

        public static List<string> LoadFile(this string fileName)
        {
            if (!File.Exists(fileName))
            {
                return new List<string>();
            }
            return File.ReadAllLines(fileName).ToList();
        }

        public static void SaveToPersonFile(this List<PersonModel> models)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id},{p.EmailAddress},{p.FirstName},{p.LastName},{p.PersonalId}");
            }

            File.WriteAllLines(GlobalConfig.PersonFile.FullFilePath(), lines);
        }

        public static void SaveToTeamFile(this List<TeamModel> models)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel tm in models)
            {
                lines.Add($"{tm.Id},{tm.TeamName},{ConvertToTeamString(tm)}");
            }

            File.WriteAllLines(GlobalConfig.TeamFile.FullFilePath(), lines);
        }

        private static string ConvertToTeamString(TeamModel model)
        {
            string output = "";

            foreach (PersonModel p in model.TeamMembers)
            {
                output += $"{p.Id}|";
            }

            if (output.Length != 0)
            {
                output = output.Substring(0, output.Length - 1);
            }


            return output;
        }

        public static List<PersonModel> ConvertToPersonModel(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PersonModel p = new PersonModel();

                p.Id = int.Parse(cols[0]);
                p.EmailAddress = cols[1];
                p.FirstName = cols[2];
                p.LastName = cols[3];
                p.PersonalId = cols[4];

                output.Add(p);
            }

            return output;
        }

        public static List<TeamModel> ConvertToTeamModel(this List<string> lines)
        {
            List<TeamModel> output = new List<TeamModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TeamModel m = new TeamModel();

                m.Id = int.Parse(cols[0]);
                m.TeamName = cols[1];
                m.TeamMembers = ConvertToTeamList(cols[2]);

                output.Add(m);
            }

            return output;
        }

        public static List<PersonModel> ConvertToTeamList(string ids)
        {
            List<PersonModel> persons = GlobalConfig.PersonFile.FullFilePath().LoadFile().ConvertToPersonModel();
            List<PersonModel> output = new List<PersonModel>();

            string[] cols = ids.Split('|');

            if (ids != "")
            {
                foreach (string id in cols)
                {
                    output.Add(persons.Where(x => x.Id == int.Parse(id)).First());
                }
            }

            return output;
        }
    }
}
