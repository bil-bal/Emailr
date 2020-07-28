using EmailrLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailrLibrary
{
    public static class GlobalConfig
    {
        public const string PersonFile = "PersonModels.csv";
        public const string TeamFile = "TeamModels.csv";
        public const string EmailFile = "";

        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnection(DatabaseType db)
        {
            if (db == DatabaseType.textfile)
            {
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }
    }
}
