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
        Uri week10Url = new Uri(@"https://c4demoapi.azurewebsites.net");
        Uri week11Url = new Uri(@"https://daapi.azurewebsites.net");

        public Dude GetDude(int did)
        {
            Dude dude = new Dude();
            using (var client = new WebClient())
            {
                var response = client.DownloadString(week10Url + $"/api/values/{did}");
                dude = JsonConvert.DeserializeObject<Dude>(response);
            }

            return dude;
        }

        public Product GetProduct(int id)
        {
            Product product = new Product();
            using (var client = new WebClient())
            {
                var response = client.DownloadString(week11Url + $"/api/products/{id}");
                product = JsonConvert.DeserializeObject<Product>(response);
            }

            return product;
        }

        public bool PostProduct(Product product)
        {
            using (var client = new WebClient())
            {
                var dataString = JsonConvert.SerializeObject(product);
                client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                client.UploadString(week11Url + $"/api/products/{product.id}", "POST", dataString);
            }

            return true;
        }

        public bool PutProduct(Product product)
        {
            using (var client = new WebClient())
            {
                var dataString = JsonConvert.SerializeObject(product);
                client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                client.UploadString(week11Url + $"/api/products/{product.id}", "PUT", dataString);
            }

            return true;
        }

        public bool DeleteProduct(int id)
        {
            using (var client = new WebClient())
            {
                var response = client.UploadString(week11Url + $"/api/products/{id}", "DELETE", "");
                Console.WriteLine(response);
            }

            return true;
        }

        //

        public Inventory GetInventory(int id)
        {
            Inventory inventory = new Inventory();
            using (var client = new WebClient())
            {
                var response = client.DownloadString(week11Url + $"/api/inventories/{id}");
                inventory = JsonConvert.DeserializeObject<Inventory>(response);
            }

            return inventory;
        }

        public bool PostInventory(Inventory inventory)
        {
            using (var client = new WebClient())
            {
                var dataString = JsonConvert.SerializeObject(inventory);
                client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                client.UploadString(week11Url + $"/api/inventories/{inventory.id}", "POST", dataString);
            }

            return true;
        }

        public bool PutInventory(Inventory inventory)
        {
            using (var client = new WebClient())
            {
                var dataString = JsonConvert.SerializeObject(inventory);
                client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                client.UploadString(week11Url + $"/api/inventories/{inventory.id}", "PUT", dataString);
            }

            return true;
        }

        public bool DeleteInventory(int id)
        {
            using (var client = new WebClient())
            {
                var response = client.UploadString(week11Url + $"/api/inventories/{id}", "DELETE", "");
                Console.WriteLine(response);
            }

            return true;
        }
    }
}
