using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Loops
{
    internal class ReverseNumber
    {
        public void main(int x)
        {
            int rev = 0;
            while(x!=0)
            {
                int r = x % 10;
                rev = rev * 10 + r;
                x /= 10;
            }
            Console.WriteLine(rev);
        }
    }
}
