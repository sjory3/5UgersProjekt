using System;
using System.Threading.Tasks;
using System.Net.Http;

using MySql.Data.MySqlClient;

namespace ArduinoHttpClient
{
    class Program
    {
        static string responseBody;
        static void Main(string[] args)
        {
            while (true)
            {

                HttpGetRequestFromArudino();

                Console.WriteLine(responseBody);

                PostDataToMySqlDatabase();
                System.Threading.Thread.Sleep(10000);
            }
        }

        static async Task HttpGetRequestFromArudino()
        {
            var client = new HttpClient();
            string url = "http://192.168.1.177/";

            HttpResponseMessage response = client.GetAsync(url).GetAwaiter().GetResult();

            response.EnsureSuccessStatusCode();
            responseBody = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

        }

        static void PostDataToMySqlDatabase()
        {
            string connStr = "Server=193.106.164.115;Port=3306;Database=mydb;Uid=michael;Pwd=IDKm4n0r4ng3S33msKind4SUS!;";
            MySqlConnection conn = new MySqlConnection(connStr);

            MySqlCommand cmd = null;
            string cmdString = "";

            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Connection Opened");
                cmdString = "insert into mydb.place Values(0,'Ringsted',55.443,11.7914,15,'Denmark',"+int.Parse(responseBody)+")";
                cmd = new MySqlCommand(cmdString, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                Console.WriteLine("Data Stored");
            }
        }
    }
}
