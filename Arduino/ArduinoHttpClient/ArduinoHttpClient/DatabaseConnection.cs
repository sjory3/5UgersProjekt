using MySql.Data.MySqlClient;
using System;

namespace ArduinoHttpClient
{
    class DatabaseConnection
    {
        Messages messages = new Messages();
        static string connStr = ConnectionString.ConnectionStringToDatabase();
        MySqlConnection conn = new MySqlConnection(connStr);

        public void OpenConnectionToMySqlDatabase()
        {

            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                PostDataToDatabase();
                conn.Close();
                messages.SavedDataToDatabase();
            }
        }

        public void PostDataToDatabase()
        {
            MySqlCommand cmd = null;
            string cmdString = "";

            cmdString = "insert into mydb.place Values(0,'Ringsted',55.443,11.7914,15,'Denmark'," + Program.responseBody + ")";
            cmd = new MySqlCommand(cmdString, conn);
            cmd.ExecuteNonQuery();

        }
    }
}
