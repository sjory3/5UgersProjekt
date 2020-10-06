using System;
using System.Threading.Tasks;
using System.Net.Http;


using MySql.Data.MySqlClient;

namespace ArduinoHttpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //making a database and httpclient object
            DatabaseConnection database = new DatabaseConnection();
            HttpClientConnection httpClient = new HttpClientConnection();
            //the url for the arduino website
            string url = "http://192.168.1.177/";

            //string for saving the response
            string response;

            //while loop runs every 10 sek and get the http from the arduino and saving it to the database
            while (true)
            {
                //calling the GetHttp and sending a httpclient and url with it and saving the response in a string
                response = GetHttp(httpClient, url);
                //connecting to the database - opening the connection
                database.OpenConnectionToMySqlDatabase();
                //posting the response to the database sending the database object and the responce as a int
                PostToDatabase(database, Converter.ConvertStringToInt(response));
                //closing the connection to the database
                database.CloseConnectionToMySqlDatabase();

                //sleeps for 10 sek
                System.Threading.Thread.Sleep(10000);
            }
        }
        //method for getting the http response
        public static string GetHttp(HttpClientConnection httpClient, string url)
        {

            //Gets the data from the arduino webserver
            string response = httpClient.HttpGetRequestFromArudino(url);
            return response;
        }
       
        //method for posting the response to the database
        public static void PostToDatabase(DatabaseConnection database, int response)
        {
            database.PostDataToDatabase(response);
        }

    }
}
