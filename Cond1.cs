using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    internal class Cond1
    {

        public static void Run()
        {
            Console.WriteLine("Enter your Age");
        int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18) Console.WriteLine("Major");
            else Console.WriteLine("Minor");
        }
    }
}
