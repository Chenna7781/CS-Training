using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Methods.Method_Loading
{
    internal class SumOfDifferDataTypes
    {

        public static int sum(int x,int y)
        {
            return x + y;
        }

        public static double sum(double x,double y)
        {
            return x + y;
        }

        public static string sum(string s1,string s2)
        {
            return s1 + s2;
        }

        public static void sum()
        {
            Console.WriteLine("Choose the data types to add");
            Console.WriteLine("1. sum of integers \n2. sum of double \n3. sum of strings");
            int a;
            int.TryParse(Console.ReadLine(), out a);

            

            switch (a)
            {
                case 1:
                    Console.WriteLine("Enter Elements");
                    int x = Convert.ToInt32(Console.ReadLine());
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine(sum(x, y));
                    break;

                case 2:
                    Console.WriteLine("Enter Elements");
                    double m = Convert.ToDouble(Console.ReadLine());
                    double n = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine(sum(m, n));
                    break;

                case 3:
                    Console.WriteLine("Enter Elements");
                    string s1 = Console.ReadLine();
                    string s2 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(sum(s1, s2));
                    break;

            }
        }
       
    }
}
