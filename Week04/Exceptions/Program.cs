using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number with multiple digits:");
            string input = Console.ReadLine();

            int[] digits = new int[input.Length];

            if (CheckValidNumber(input))
            {
                SplitIntoDigits(input, digits);
                Console.WriteLine($"Sum of digits: {SumDigits(digits)}");
            }

            Console.ReadLine();
        }

        static bool CheckValidNumber(string input)
        {
            bool isValidNumber = int.TryParse(input, out int validNumber);

            try
            {
                if (!isValidNumber)
                {
                    throw new FormatException(input);
                }

                if (validNumber < 0)
                { 
                    throw new LessThanZeroException(input);
                }

                if (validNumber > 15)
                {
                    throw new GreaterThanFifteenException(input);
                }

                return true;
            }
            catch (FormatException exception)
            {
                Console.WriteLine($"Error: input is not a valid integer /// {exception}");
                return false;
            }
            catch (LessThanZeroException exception)
            {
                Console.WriteLine($"Error: {exception}");
                return false;
            }
            catch (GreaterThanFifteenException exception)
            {
                Console.WriteLine($"Error: {exception}");
                return false;
            }
            finally
            {
                Console.WriteLine(DateTime.Now.ToString());
            }
        }

        static void SplitIntoDigits(string input, int[] digits)
        {
            char[] split = input.ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                digits[i] = int.Parse(split[i].ToString());
            }
        }

        static int SumDigits(int[] digits)
        {
            int sum = 0;
            foreach (int digit in digits)
            {
                sum += digit;
            }

            return sum;
        }
    }
}
