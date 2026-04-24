using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Arrays
{
    internal class SumOfElements
    {
        public static void main(params int[] arr)
        {
            int sum=0;
            foreach(var i in arr)
            {
               sum+= i; 
            }
            Console.WriteLine(sum);
        }
    }
}
