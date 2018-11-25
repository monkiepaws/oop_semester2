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
    public class StudentClient
    {
        readonly string Url = "http://localhost:62229/api/Students";

        public async Task<List<Student>> GetAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(this.Url);
                var stringResponse = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<List<Student>>(stringResponse);

                return responseObject;
            }
        }

        public async Task<List<Student>> GetAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync($"{this.Url}/{id}");
                var stringResponse = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<List<Student>>(stringResponse);

                return responseObject;
            }
        }

        public async Task<Student> PostAsync(Student student)
        {
            using (HttpClient client = new HttpClient())
            {
                var dataString = JsonConvert.SerializeObject(student);
                var sendData = new StringContent(dataString, System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync(this.Url, sendData);

                var responseObject = JsonConvert.DeserializeObject<Student>(await response.Content.ReadAsStringAsync());

                return responseObject;
            }
        }

        public async Task<Student> PutAsync(Student student)
        {
            using (HttpClient client = new HttpClient())
            {
                var dataString = JsonConvert.SerializeObject(student,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        Formatting = Formatting.None,
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    });
                var sendData = new StringContent(dataString, System.Text.Encoding.UTF8, "application/json");
                var response = await client.PutAsync($"{this.Url}/{student.Id}", sendData);

                var responseObject = JsonConvert.DeserializeObject<Student>(await response.Content.ReadAsStringAsync());

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
