using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;
using System.Configuration;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; } 

        public static void InitilizeConnections(Databasetype db)
        {
            //c#7 and above for switch that can accept enum
            //switch (db) 
            //{
            //    case Databasetype.sql:
            //        break;
            //    case Databasetype.TextFile:
            //        break;
            //    default:
            //        break;
            //}
            if(db == Databasetype.sql)
            {
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if(db == Databasetype.TextFile)
            {
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
