using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ContactBookMVC.Controller
{
    class Singleton
    {
        //private static Singleton instance;
        private static SqlConnection connection;

        public SqlConnection GetSqlConnection
        {
            get { return connection; }
        }

        public static Singleton GetInstance()
        {
                Singleton instance = null;
                if (instance == null)
                {
                    instance = new Singleton();
                    connection = new SqlConnection(GetConnectionStrings());
                }
                return instance;
        }

        public static string GetConnectionStrings()
        {
            ConnectionStringSettingsCollection settings =
                ConfigurationManager.ConnectionStrings;

            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    return cs.ConnectionString;
                }
            }
            return String.Empty;
        }
    }
}
