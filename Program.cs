using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace CalculatePrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatePrimes();
        }
  
        private static void CalculatePrimes()
        {
            Console.WriteLine("To what number would you like to calculate primes?\n");
            string input = Console.ReadLine();
            Console.WriteLine("\nThe primes are:");
            string pattern = "^([1-9][0-9]{0,2}|1000)$";
              
            if (Regex.IsMatch(input, pattern))
            {
                int countToMax = Convert.ToInt32(input);

                int isItPrime = 1;
              
                while (isItPrime <= countToMax)
                {
                    GetPrimes(isItPrime);
                    isItPrime += 1;
                }
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 and 1000\n");
                CalculatePrimes();
            }
            CalculatePrimes();
        }

        public static void GetPrimes(int isItPrime)
        {
            int notPrimeFlag = 0;

            for (int i = isItPrime - 1; i >= 1; i--)
            {
                int remainder = isItPrime % i;

                if (isItPrime == 2)
                {
                    Console.WriteLine(isItPrime);
                }
                if (remainder == 0)
                {
                    notPrimeFlag = 1;
                    
                    break;
                }

                if (i == 2 && notPrimeFlag == 0)
                {
                    Console.WriteLine(isItPrime);
                }
            }
        }
    }
}