using System.Data.SQLite;
using System.IO;

namespace CMCS_Website.Data
{
    public class DatabaseService
    {
        private readonly string _connectionString;

        public DatabaseService()
        {
            string dbPath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "cmcs.db");
            _connectionString = $"Data Source={dbPath};Version=3;";
        }

        public SQLiteConnection GetConnection()
        {
            var conn = new SQLiteConnection(_connectionString);
            conn.Open();
            return conn;
        }
    }
}
