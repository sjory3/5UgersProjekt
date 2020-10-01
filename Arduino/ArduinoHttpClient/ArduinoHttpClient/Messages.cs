using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoHttpClient
{
    class Messages
    {
        //methods for outputing to the console
        public void SucssesFullResponceFromArduino(int responce)
        {
            Console.WriteLine("Responce from arduino = " + responce);
        }

        public void SucssesFullDatabaseConnection()
        {
            Console.WriteLine("Connection Opened");
        }

        public void SavedDataToDatabase()
        {
            Console.WriteLine("Data Stored");
        }
    }
}
