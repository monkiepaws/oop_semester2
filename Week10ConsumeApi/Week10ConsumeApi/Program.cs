using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week10ConsumeApi.Models;

namespace Week10ConsumeApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            var api = new APIClient();

            PostInventory(api);

            Console.WriteLine("End");
            Console.ReadLine();
        }

        static void GetDude(APIClient api)
        {
            Console.WriteLine(api.GetDude(100));
        }

        static void GetProduct(APIClient api)
        {
            Console.WriteLine(api.GetProduct(9633324));
        }

        static void PostProduct(APIClient api)
        {
            Product product = new Product();
            product.id = 9633324;
            product.prodname = "Richard";
            product.desc = "Sims";
            product.price = 42;

            Console.WriteLine($"id: {product.id}\nprodname: {product.prodname}\ndesc: {product.desc}\nprice: {product.price}");
            Console.WriteLine();
            Console.WriteLine(api.PostProduct(product));
        }

        static void PutProduct(APIClient api)
        {
            Product product = new Product();
            product.id = 9633324;
            product.prodname = "Richard";
            product.desc = "Sims haz bin hrr";
            product.price = 42;

            Console.WriteLine($"id: {product.id}\nprodname: {product.prodname}\ndesc: {product.desc}\nprice: {product.price}");
            Console.WriteLine();
            Console.WriteLine(api.PutProduct(product));
        }

        static void DeleteProduct(APIClient api)
        {
            Console.WriteLine(api.DeleteProduct(9633324));
        }

        //

        static void GetInventory(APIClient api)
        {
            Console.WriteLine(api.GetInventory(42));
        }

        static void PostInventory(APIClient api)
        {
            Inventory inventory = new Inventory();
            inventory.id = 42;
            inventory.prodid = 9633324;
            inventory.instock = 1001;
            inventory.backorder = 0;

            Console.WriteLine($"id: {inventory.id}\nprodname: {inventory.prodid}\ndesc: {inventory.instock}\nprice: {inventory.backorder}");
            Console.WriteLine();
            Console.WriteLine(api.PostInventory(inventory));
        }

        static void PutInventory(APIClient api)
        {
            Inventory inventory = new Inventory();
            inventory.id = 42;
            inventory.prodid = 9633324;
            inventory.instock = 999;
            inventory.backorder = 0;

            Console.WriteLine($"id: {inventory.id}\nprodname: {inventory.prodid}\ndesc: {inventory.instock}\nprice: {inventory.backorder}");
            Console.WriteLine();
            Console.WriteLine(api.PutInventory(inventory));
        }

        static void DeleteInventory(APIClient api)
        {
            Console.WriteLine(api.DeleteInventory(42));
        }
    }
}
