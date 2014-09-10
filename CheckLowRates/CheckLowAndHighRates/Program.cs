using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowAndHighRates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your hourly pay rate? ");
            Double Hourly = Convert.ToDouble(Console.ReadLine());

            if (Hourly < 5.65 || Hourly > 49.99)
                Console.WriteLine("ERROR, Payrate is too Wrong");
        }
    }
}
