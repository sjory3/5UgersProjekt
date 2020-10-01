using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArduinoHttpClient
{
    class ConnectionString
    {
        public static string ConnectionStringToDatabase()
        {
            //reads and saves the connection credentials from a file
            string connectionStringToMySqlServer = File.ReadAllText(@"C:\Users\mich612i\Documents\GitHub\5UgersProjekt\Arduino\ArduinoHttpClient\ArduinoHttpClient\Config.txt");
            //returning the credentials
            return connectionStringToMySqlServer;
        }
    }
}
