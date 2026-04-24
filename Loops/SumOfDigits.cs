using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Loops
{
    internal class SumOfDigits
    {
        public void main(int x)
        {
            int sum = 0;

            while (x != 0)
            {
                sum += (x % 10);
                x /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
