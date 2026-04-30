using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Exception_Handling
{
    internal class DemoException
    {
        public static void Operation()
        {
            try
            {
                int a = 10;
                a /= 0;
            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Program Ended");
            }
        }

        public static void TryWithMultipleCatch()
        {
            try
            {
                int a = 0;
                string s = null;
                string s1 = "";
                s1 = s1 + s;
                a = 100 / a;

                
            }

            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Source);
            }
           

            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Usingthrow()
        {
            int age = 16;

            if (age < 18)
            {
                throw new ArgumentException("Under Aged");
            }
        }
    }
}
