using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10ConsumeApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            var api = new APIClient();

            Console.WriteLine(api.GetDude(100));

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
