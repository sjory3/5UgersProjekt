using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoHttpClient
{
    //Hvor er dine kodekommentar?
    class Converter
    {
        //Hvorfor er denne metode static og hvad bruger du metoden til?
        public static int ConvertStringToInt(string response)
        {
            int result = int.Parse(response);
            return result;
        }
    }
}
