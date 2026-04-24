using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    internal class Cond2
    {
        //write a program to find the age by date of birth
        public static void Run()
        {
            Console.WriteLine("Enter your date of birth in format (dd-MM-yyyy)");

                DateTime birthday = DateTime.Parse(Console.ReadLine());
            TimeSpan diff = DateTime.Today - birthday;
            int years =(int) (diff.TotalDays/365);
            Console.WriteLine(years);
        }
    }
}
