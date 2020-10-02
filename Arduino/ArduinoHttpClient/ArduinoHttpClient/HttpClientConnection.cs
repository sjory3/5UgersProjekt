using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace ArduinoHttpClient
{
    class HttpClientConnection
    {
        public string HttpGetRequestFromArudino(string url)
        {
            //instance httpClient as client
            HttpClient client = new HttpClient();
            //the ip addres for the arduino
            

            //gets the data from the website
            HttpResponseMessage response = client.GetAsync(url).GetAwaiter().GetResult();

            //making sure that the responce was a sucess
            response.EnsureSuccessStatusCode();

            //getting the response
            string result = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            Debug.WriteLine("Sucess. Got the response from http");
            //returns the response
            return result;

        }
    }
}
