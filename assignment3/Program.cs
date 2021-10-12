using System;

namespace assignment3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter a year: ");
                int year = int.Parse(Console.ReadLine());
                if (year == 0)
                {
                    break;
                }

                
                bool result = YearCalc(year);


                if (year < 0)
                {
                    Console.WriteLine("Year must be positive!"); 
                }
                else if(result == true)
                {
                    Console.WriteLine($"{year} is a leap year");
                }
                else
                {
                    Console.WriteLine($"{year} is not a leap year");
                }




            } while (true);
            Console.ReadKey();
        }


        static bool YearCalc(int year)
        {
            bool result;
            int notLeapYear = year % 100;
            int leapYearFour = year % 4;
            int leapYearFourHundred = year % 400;

            if (leapYearFourHundred == 0)
            {
                result = true;
            }
            else if (notLeapYear == 0)
            {
                result = false;
            }
            else if (leapYearFour == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }


            return result;
        }
    }
}
