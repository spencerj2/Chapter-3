using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pine = "P";
            string oak = "O";
            string mahogany = "M";
            int pineprice = 100;
            int oakprice = 225;
            int mahoganyprice = 310;

            Console.Write("Press P For Pine or O For Oak or M For Mahogany: ");

            if (Console.ReadLine() == pine)
                Console.WriteLine("Pine Tables Cost ${0}", pineprice);
            else
                pineprice = 0;
                
            if (Console.ReadLine() == oak)
                Console.WriteLine("Oak Tables Cost ${0}", oakprice);
            else
                oakprice = 0;
            if (Console.ReadLine() == mahogany)
                Console.WriteLine("Mahogany Tables Cost ${0}", mahoganyprice);
            else
                mahoganyprice = 0;

        }
    }
}
