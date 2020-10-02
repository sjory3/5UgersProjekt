using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;

namespace ArduinoHttpClient
{
    class DatabaseConnection
    {
        //getting the connection credentials from a file
        static string connString = ConnectionString.ConnectionStringToDatabase();
        //making a connection to the MySql database with the connection string
        MySqlConnection conn = new MySqlConnection(connString);

        public void OpenConnectionToMySqlDatabase()
        {
            //opens a connection
            conn.Open();
            //making sure the connection is open
            if (conn.State == System.Data.ConnectionState.Open)
            {
                Debug.WriteLine("Connection Open");
                return;
            }
            else
            {
                Debug.WriteLine("FAILED TO OPEN PORT");
                
            }
        }

        public void CloseConnectionToMySqlDatabase()
        {
            conn.Close();
            Debug.WriteLine("Connection Closed");
        }

        public void PostDataToDatabase(int response)
        {
            //setting the MySql command to null
            MySqlCommand cmd = null;
            //making a cmdstring we use for querys
            string cmdString = "";

            //setting the query to inserting into the database
            cmdString = "insert into mydb.place Values(0,'Ringsted',55.443,11.7914,15,'Denmark'," + response + ")";
            //calling the MySqlCommand and sending the query and the connection to the database
            cmd = new MySqlCommand(cmdString, conn);
            //executing the query we sendt
            cmd.ExecuteNonQuery();

                Debug.WriteLine("Saved to database");
        }
    }
}
