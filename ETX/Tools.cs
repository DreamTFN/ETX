using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETX
{
    internal class Tools
    {

        private static short progworktype = 0;
        private static String servername = "";
        private static String dbname = "";
        private static String dbuser = "";
        private static String dbpass = "";
        private static int User_ID = 1;

        public static String ServerName { get { return servername; } set { servername = value; UpdateConnectionString(); } }
        public static String DbName { get { return dbname; } set { dbname = value; UpdateConnectionString(); } }
        public static String DbUser { get { return dbuser; } set { dbuser = value; UpdateConnectionString(); } }
        public static String DbPass { get { return dbpass; } set { dbpass = value; UpdateConnectionString(); } }
        public static short ProgWorkType { get { return progworktype; } set { progworktype = value; UpdateProgWorkType(); } }

        private static String constring = "";
        public static int user_ID { get { return User_ID; } set { User_ID = 1; } }

        private static void UpdateConnectionString()
        {
            constring = "Data Source=" + ServerName + "; Initial Catalog=" + DbName + "; User ID=" + DbUser + "; Password=" + DbPass + "; Trusted_Connection=True; TrustServerCertificate=True; Connect Timeout=3000000; MultipleActiveResultSets=True;";
        }

        private static void UpdateProgWorkType()
        {
            progworktype = ProgWorkType; // "Data Source=" + ServerName + ";Initial Catalog=" + DbName + ";User ID=" + DbUser + ";Password=" + DbPass + ";Connect Timeout=3000000;MultipleActiveResultSets=True;";
        }

        public static string Constring
        {
            get { return constring; }
            set { }
        }



        private static SqlConnection connection;
        public static SqlConnection Sql_Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new SqlConnection(constring);
                }
                return connection;
            }
            private set { connection = value; }
        }


        private static string logo_firma = "";
        public static string Logo_Firma
        {
            get { return logo_firma; }
            set { logo_firma = value; }
        }


        private static string logo_yil = "";
        public static string Logo_Yil
        {
            get { return logo_yil; }
            set { logo_yil = value; }
        }


        private static string logo_kull = "";
        public static string Logo_Kull
        {
            get { return logo_kull; }
            set { logo_kull = value; }
        }


        private static string logo_isyeri = "01";
        public static string Logo_Isyeri
        {
            get { return logo_isyeri; }
            set { logo_isyeri = value; }
        }

    }
}
