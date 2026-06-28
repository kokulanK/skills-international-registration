using MySql.Data.MySqlClient;
using System.Configuration;

namespace SkillsInternational
{
    /// <summary>
    /// Provides a centralised way to open a MySQL connection.
    /// All forms call DBHelper.GetConnection() rather than hard-coding
    /// the connection string in multiple places.
    /// </summary>
    public static class DBHelper
    {
        // Read the MySQL connection string from App.config once.
        private static readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["StudentDB"].ConnectionString;

        /// <summary>
        /// Returns an OPEN MySqlConnection to the student database.
        /// Always wrap the returned connection in a 'using' block so it is
        /// closed and disposed automatically.
        /// </summary>
        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            conn.Open();
            return conn;
        }
    }
}
