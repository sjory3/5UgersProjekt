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
            Messages consoleMessages = new Messages();
            HttpClientConnection httpClient = new HttpClientConnection();
            DatabaseConnection database = new DatabaseConnection();
            //while loop runs every 10 sek and get the http from the arduino and saving it to the database
            while (true)
            {

                httpClient.HttpGetRequestFromArudino();

                consoleMessages.SucssesFullResponceFromArduino(responseBody);

                database.OpenConnectionToMySqlDatabase();
                System.Threading.Thread.Sleep(10000);
            }
        }
    }
}
