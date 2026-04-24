using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Methods
{
    internal class Calculator
    {
        
        //sum of two integers
        public static int sum(int a, int b) { return a + b; }

        //difference of two integers
        public static int diff(int a, int b) { return a - b; }

        //product of two integers
        public static int product(int a, int b) { return a * b; }

        //product of two decimals
        public static double product(double a, double b) { return a * b; }

        ////division of two integers
        //public static int division(int a, int b) { return a / b; }

        //division of two decimals
        public static double division(int a, int b) { return a / b; }

        //remainder of two integers
        public static int remainder(int a, int b) { return a % b; }

        //calculator
        public static void calculator()
        {
            Console.WriteLine("Enter the number to do calculations");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select the Operation");
            Console.WriteLine("1.Sum of two integers \n2.Difference of two integers \n3.Product of two integers \n4.Division of two integers \n5.Remainder of two integers");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:

                    Console.WriteLine(sum(x, y));
                    break;

                case 2:
                    
                    Console.WriteLine(diff(x, y));
                    break;

                case 3:
                   
                    Console.WriteLine(product(x, y));
                    break;

                case 4:
                    
                    Console.WriteLine(division(x, y));
                    break;

                case 5:
                 
                    Console.WriteLine(remainder(x, y));
                    break;

        


            }
        }
    }
}

