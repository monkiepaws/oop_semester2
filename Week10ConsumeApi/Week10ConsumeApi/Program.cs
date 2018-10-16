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

            api.GetDude();

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
