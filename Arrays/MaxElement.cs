using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Arrays
{
    internal class MaxElement
    {
        public static void maximum(params int[] array)
        {
            int max = int.MinValue;
            foreach(int s in array)
            {
                max= Math.Max(max, s);
                //if(s>max) max=s;
            }
            Console.WriteLine(max);
        }
    }
}
