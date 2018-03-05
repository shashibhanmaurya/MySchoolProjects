using System.Configuration;
using System.Data.SqlClient;
using System;


namespace MySchoolSolution
{
    /// <summary>
    /// Summary description for Connection
    /// </summary>
    public class CommonFunctions
    {
        public CommonFunctions()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static string [] GetClasses
        {
            get
            {
                string _iSTR = System.Convert.ToString(ConfigurationManager.AppSettings["Classes"]);
                string[] Classes = _iSTR.Split(',');

                return Classes;
            }
        }

        public static string GetCurrentSession
        {
            get
            {
                string session = string.Empty;
                int currentYear = DateTime.Now.Year;
                int ndYear = 0;
                int currentMonth = DateTime.Now.Month;
                if (currentMonth < 4)
                {
                    session = (currentYear - 1) + "-" + currentYear;
                    
                }
                else
                {
                    session = currentYear + "-" + (currentYear + 1);
                    
                }
                return session;
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