using System;
using System.Threading.Tasks;
using System.Net.Http;


using MySql.Data.MySqlClient;

namespace ArduinoHttpClient
{
    class Program
    {
        //static string for the diffrent methods to use
        public static int responseBody;
        static void Main(string[] args)
        {
            //instansiate the diffrent classes to call the methods they have
            HttpClientConnection httpClient = new HttpClientConnection();
            DatabaseConnection database = new DatabaseConnection();

            //while loop runs every 10 sek and get the http from the arduino and saving it to the database
            while (true)
            {
                //Gets the data from the arduino webserver
                httpClient.HttpGetRequestFromArudino();


                //opens a connection to the database
                database.OpenConnectionToMySqlDatabase();

                //sleeps for 10 sek
                System.Threading.Thread.Sleep(10000);
            }
        }
    }
}
