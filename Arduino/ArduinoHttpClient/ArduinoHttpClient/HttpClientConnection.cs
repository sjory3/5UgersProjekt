using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace ArduinoHttpClient
{
    class HttpClientConnection
    {
        Messages messages = new Messages();
        public async Task HttpGetRequestFromArudino()
        {
            //instance httpClient as client
            HttpClient client = new HttpClient();
            //the ip addres for the arduino
            string url = "http://192.168.1.177/";

            //gets the data from the website
            HttpResponseMessage response = client.GetAsync(url).GetAwaiter().GetResult();

            //making sure that the responce was a sucess
            response.EnsureSuccessStatusCode();

            //parsing the respose to a int and saving it in the public attribute
            Program.responseBody = int.Parse(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());

            //outputs a responce to the console
            messages.SucssesFullResponceFromArduino(Program.responseBody);

        }
    }
}
