using APIClient.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APIClient
{
    public class TodoClient
    {
        readonly string Url = "http://todoapiswin.azurewebsites.net/api/Todo";
        readonly string ApiKey = "?apiKey=Richo";

        public async Task<List<TodoItem>> GetAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync($"{this.Url}{this.ApiKey}");
                var stringResponse = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<List<TodoItem>>(stringResponse);

                return responseObject;
            }
        }

        public async Task<TodoItem> GetAsync(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync($"{this.Url}/{id}{this.ApiKey}");
                var stringResponse = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<TodoItem>(stringResponse);

                return responseObject;
            }
        }

        public async Task<TodoItem> PostAsync(TodoItem task)
        {
            using (HttpClient client = new HttpClient())
            {
                var dataString = JsonConvert.SerializeObject(task,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        Formatting = Formatting.None,
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    });
                var sendData = new StringContent(dataString, System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync($"{Url}{ApiKey}", sendData);

                var responseObject = JsonConvert.DeserializeObject<TodoItem>(await response.Content.ReadAsStringAsync());

                return responseObject;
            }
        }

        public async Task<TodoItem> PutAsync(TodoItem task)
        {
            using (HttpClient client = new HttpClient())
            {
                var dataString = JsonConvert.SerializeObject(task,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        Formatting = Formatting.None,
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    });
                var sendData = new StringContent(dataString, System.Text.Encoding.UTF8, "application/json");
                var response = await client.PutAsync($"{this.Url}/{task.id}{this.ApiKey}", sendData);

                var responseObject = JsonConvert.DeserializeObject<TodoItem>(await response.Content.ReadAsStringAsync());

                return responseObject;
            }
        }

        public async Task<string> DeleteAsync(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.DeleteAsync($"{this.Url}/{id}{this.ApiKey}");
                var stringResponse = response.StatusCode.ToString();

                return stringResponse;
            }
        }
    }
}
