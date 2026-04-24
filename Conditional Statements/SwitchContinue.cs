using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    internal class SwitchContinue
    {

        public static void Run()
        {
            for (int i = 0; i <= 5; i++)
            {
                switch (i)
                {

                    case 0:
                        Console.WriteLine("Skip iteration");
                        continue;
                    case 3:
                        Console.WriteLine("Skip iteration");
                        continue;
                    default:
                        Console.WriteLine(i);
                        break;

                }
            }
        }
    }
}
