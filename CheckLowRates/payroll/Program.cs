using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What Is Your Hourly Pay Rate? ");
            Double HourlyPay = Convert.ToDouble(Console.ReadLine());
            Console.Write("How Many Hours Do You Work? ");
            Double Hours = Convert.ToDouble(Console.ReadLine());

            Double grosspay = HourlyPay * Hours;
            Double withholdingtax = grosspay / 100;
            Double netpay = grosspay - withholdingtax;

            Console.WriteLine("Gross Pay                  Withholding Tax");
            Console.WriteLine("Up To And Including {0}   %{1}", grosspay, withholdingtax);
            Console.WriteLine("{0} And Up                 %{1}", grosspay, withholdingtax++);
        }
    }
}
