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
        public async Task HttpGetRequestFromArudino()
        {
            var client = new HttpClient();
            string url = "http://192.168.1.177/";

            HttpResponseMessage response = client.GetAsync(url).GetAwaiter().GetResult();

            response.EnsureSuccessStatusCode();
            Program.responseBody = int.Parse(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());

        }
    }
}
