using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Methods
{
    internal class PrimeNumber
    {

        public bool isPrime(int n)
        {
            if(n<2) return false;

            for(int i = 2; i <= n / 2; i++)
            {
                if(n%i==0) return false;
            }
            return true;
        }
    }
}
