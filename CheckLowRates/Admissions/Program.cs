using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Admissions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your GPA:");
            double gpa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Your Test Score:");
            int testscore = Convert.ToInt32(Console.ReadLine());

            if (gpa >= 3.0 && testscore >= 60 || gpa < 3.0 && testscore >= 80)
                Console.WriteLine("Accept");
            else
                Console.WriteLine("Reject");

        }
    }
}
