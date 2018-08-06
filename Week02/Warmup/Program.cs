using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Is no factorial + fibonacci number above 2, so took it out of code

namespace Warmup
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ulong> fibonacciPrimeNumbers = new List<ulong>();

            FindFibonacciPrimeNumbers(fibonacciPrimeNumbers);

            Console.WriteLine($"Sum = {SumNumbers(fibonacciPrimeNumbers)}");
            Console.ReadLine();
        }

        private static void FindFibonacciPrimeNumbers(List<ulong> fibonacciPrimeNumbers)
        {
            ulong numberA = 1;
            ulong numberB = 1;
            ulong numbersSum = 0;

            while (fibonacciPrimeNumbers.Count < 8)
            {
                numbersSum = numberA + numberB;
                if (IsPrimeNumber(numbersSum))
                {
                    fibonacciPrimeNumbers.Add(numbersSum);
                    Console.WriteLine(numbersSum);
                }

                numberA = numberB;
                numberB = numbersSum;
            }
        }

        private static ulong SumNumbers(List<ulong> fibonacciPrimeNumbers)
        {
            ulong sum = 0;

            foreach (ulong number in fibonacciPrimeNumbers)
            {
                sum += number;
            }

            return sum;
        }

        private static bool IsPrimeNumber(ulong number)
        {
            if (number == 2)
            {
                return true;
            }
            if (number % 2 == 0 || number < 2)
            {
                return false;
            }

            ulong productCount = 0;
            for (ulong i = 3; i <= number; i++)
            {
                if (number % i == 0)
                {
                    productCount++;
                }
            }

            if (productCount == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //private static bool IsFactorial(double number)
        //{
        //    double sum = 1;
        //    double nextProduct = 1;


        //    while (sum <= number && (nextProduct * sum) < double.MaxValue)
        //    {
        //        sum = nextProduct * sum;
        //        nextProduct++;

        //        Console.WriteLine($"factorial result: {sum}");

        //        if (sum == number)
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}
    }
}
