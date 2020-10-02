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
        public async Task HttpGetRequestFromArudino(string url)
        {
            //instance httpClient as client
            HttpClient client = new HttpClient();
            //the ip addres for the arduino
            

            //gets the data from the website
            HttpResponseMessage response = client.GetAsync(url).GetAwaiter().GetResult();

            //making sure that the responce was a sucess
            response.EnsureSuccessStatusCode();

            //getting the response
            var result = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            //parsing the respose to a int and saving it in the public attribute
            Program.responseBody = Converter.ConvertHttpResponseToInt(result);

            //outputs a responce to the console
            messages.SucssesFullResponceFromArduino(Program.responseBody);

        }
    }
}
