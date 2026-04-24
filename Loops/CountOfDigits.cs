using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Loops
{
    internal class CountOfDigits
    {
        public void main(int x)
        {
            int count = 0;
            while (x != 0)
            {
                count++;
                x /= 10;
            }
            Console.WriteLine(count);
        }
    }
}
