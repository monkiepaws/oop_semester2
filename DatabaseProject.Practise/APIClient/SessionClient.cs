using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TMM.WebAPI.Models;

namespace APIClient
{
    public class SessionClient
    {
        readonly string Url = "http://localhost:62229/api/Sessions";

        public async Task<List<Session>> GetAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(this.Url);
                var stringResponse = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<List<Session>>(stringResponse);

                return responseObject;
            }
        }

        public async Task<List<Session>> GetAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync($"{this.Url}/{id}");
                var stringResponse = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<List<Session>>(stringResponse);

                return responseObject;
            }
        }

        public async Task<Session> PostAsync(Session Session)
        {
            using (HttpClient client = new HttpClient())
            {
                var dataString = JsonConvert.SerializeObject(Session);
                var sendData = new StringContent(dataString, System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync(this.Url, sendData);

                var responseObject = JsonConvert.DeserializeObject<Session>(await response.Content.ReadAsStringAsync());

                return responseObject;
            }
        }

        public async Task<Session> PutAsync(Session Session)
        {
            using (HttpClient client = new HttpClient())
            {
                var dataString = JsonConvert.SerializeObject(Session,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        Formatting = Formatting.None,
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    });
                var sendData = new StringContent(dataString, System.Text.Encoding.UTF8, "application/json");
                var response = await client.PutAsync($"{this.Url}/{Session.Id}", sendData);

                var responseObject = JsonConvert.DeserializeObject<Session>(await response.Content.ReadAsStringAsync());

                return responseObject;
            }
        }

        public async Task<string> DeleteAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.DeleteAsync($"{this.Url}/{id}");
                var stringResponse = response.StatusCode.ToString();

                return stringResponse;
            }
        }
    }
}
