using MySql.Data.MySqlClient;
using System;

namespace ArduinoHttpClient
{
    class DatabaseConnection
    {
        //instance messages to output to the console
        Messages messages = new Messages();
        //getting the connection credentials from a file
        static string connStr = ConnectionString.ConnectionStringToDatabase();
        //making a connection to the MySql database with the connection string
        MySqlConnection conn = new MySqlConnection(connStr);

        public void OpenConnectionToMySqlDatabase()
        {
            //opens a connection
            conn.Open();
            //making sure the connection is open
            if (conn.State == System.Data.ConnectionState.Open)
            {
                //calling the method for inserting data into the database
                PostDataToDatabase();
                //closing the connection when we are done
                conn.Close();
                //ouputing to the console that the data have been saved
                messages.SavedDataToDatabase();
            }
        }

        public void PostDataToDatabase()
        {
            //setting the MySql command to null
            MySqlCommand cmd = null;
            //making a cmdstring we use for querys
            string cmdString = "";

            //setting the query to inserting into the database
            cmdString = "insert into mydb.place Values(0,'Ringsted',55.443,11.7914,15,'Denmark'," + Program.responseBody + ")";
            //calling the MySqlCommand and sending the query and the connection to the database
            cmd = new MySqlCommand(cmdString, conn);
            //executing the query we sendt
            cmd.ExecuteNonQuery();

        }
    }
}
