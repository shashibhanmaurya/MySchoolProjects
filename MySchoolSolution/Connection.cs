﻿using System.Configuration;
using System.Data.SqlClient;


namespace MySchoolSolution
{
    /// <summary>
    /// Summary description for Connection
    /// </summary>
    public class Connection
    {
        public Connection()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static SqlConnection Connection_string
        {
            get
            {
                string _iSTR = System.Convert.ToString(ConfigurationManager.ConnectionStrings["LocalSqlServer1"].ConnectionString);
                return new SqlConnection(_iSTR);
            }
        }

        public static string Connections
        {
            get
            {
                return System.Convert.ToString(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            }
        }
    }
}