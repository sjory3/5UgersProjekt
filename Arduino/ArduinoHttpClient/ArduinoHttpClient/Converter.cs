using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoHttpClient
{
    class Converter
    {
        public static int ConvertHttpResponseToInt(string response)
        {
            int result = int.Parse(response);
            return result;
        }
    }
}
