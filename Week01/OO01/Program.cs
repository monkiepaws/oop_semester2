using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cookie biscuit = new Cookie("ANZAC", "Round", "Brown", "Macadamia nuts", DateTime.Now);

            Console.WriteLine(biscuit.ToString());

            biscuit.ChangeTopping("Everything");

            Console.WriteLine(biscuit.ToString());

            Console.WriteLine($"Is the cookie out of date? {biscuit.IsOutOfDate()}");

            Console.ReadLine();
        }
    }
}
