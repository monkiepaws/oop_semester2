using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Week10ConsumeApi.Models;
using Newtonsoft.Json;

namespace Week10ConsumeApi
{
    public class APIClient
    {
        Uri url = new Uri(@"https://c4demoapi.azurewebsites.net");

        public Dude GetDude(int did)
        {
            Dude dude = new Dude();
            using (var client = new WebClient())
            {
                var response = client.DownloadString(url + $"/api/values/{did}");
                dude = JsonConvert.DeserializeObject<Dude>(response);
            }

            return dude;
        }
    }
}
