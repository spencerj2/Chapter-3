using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your hourly pay rate? ");

            if (Convert.ToDouble(Console.ReadLine()) < 5.65)
                Console.WriteLine("ERROR, Payrate is too low!");
        }
    }
}
