using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Panele_Glowne
{
    internal class HotelContext
    {

        string server = "127.0.0.1";
        string port = "3306";
        string database = "HotelParadise";
        string user = "HotelP";
        string password = "PANS!@1234";

        private string connectionString;

        public HotelContext()
        {
            connectionString = $"server={server};port={port};database={database};user={user};password={password};";
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
        public bool CzyJestPolaczenie()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}