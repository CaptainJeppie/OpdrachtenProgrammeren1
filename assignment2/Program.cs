using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int numberToCheck;
                Console.Write("Enter number (0 is stop value): ");
                numberToCheck = int.Parse(Console.ReadLine());
                bool check = IsPrimeNumber(numberToCheck);
                if (numberToCheck == 0)
                {
                    break;
                }
                else if (numberToCheck < 0)
                {
                    Console.WriteLine("Negative number entered...");
                }
                else if (check == false)
                {
                    Console.WriteLine($"{numberToCheck} is not a prime number.");
                }
                else
                {
                    Console.WriteLine($"{numberToCheck} is a prime number.");
                }
                
            } while (true);
            Console.ReadKey();
        }

        static bool IsPrimeNumber(int numberToCheck)
        {

            int limit;
            limit = numberToCheck / 2;
            for (int i = 2; i <= limit; i++)
            {
                if (numberToCheck % i == 0)
                {
                    return false;
                }
            }
            return true;
            
            

        }
    }
}
