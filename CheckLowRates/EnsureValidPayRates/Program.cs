using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnsureValidPayRates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your hourly pay rate? ");
            Double Hourly = Convert.ToDouble(Console.ReadLine());

            if (Hourly < 5.65 || Hourly > 49.99)
                Console.Write("What is your hourly pay rate? ");

            else
                Console.WriteLine("Your payrate it ${0} and you make ${1} a week!", Hourly, Hourly * 40);

            Double Hourly2 = Convert.ToDouble(Console.ReadLine());

            if (Hourly2 < 5.65 || Hourly2 > 49.99)
                Console.Write("I'm sorry, but your pay rate is incorrect.");

            else
                Console.WriteLine("Your payrate it ${0} and you make ${1} a week!", Hourly2, Hourly2 * 40);
        }
    }
}
