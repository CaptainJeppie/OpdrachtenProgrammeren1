using System;
using System.Globalization;
using System.Threading;

namespace assignment1
{
    class Program
    {
        //constante VAT
        const double VatPercentage = 0.21;

        static void Main(string[] args)
        {
            //, veranderen naar .
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // het lezen van de prijs en converten daarvan
            Console.Write("Enter a price: ");
            string input = Console.ReadLine();
            double price = double.Parse(input);


            double vat = CalculateVAT(price);
            //totaal berekenen
            double total = price + vat;

            // het antwoord
            Console.WriteLine($"price: {price:0.00}, VAT: {vat:0.00}, total: {total:0.00}");

            //afsluiten
            Console.ReadKey();
        }

        static double CalculateVAT(double price)
        {
            //de VAT berekenen 
            double vat = price * VatPercentage;
            return vat;
        }
    }
}
