using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Arrays
{
    internal class CopyArray
    {
        public void CopyTo(params int[] orgArray)
        {
            int[] copy = new int[orgArray.Length];
            foreach(var i in orgArray)
            {
                copy[i] = i;
            }

            foreach(var i in copy)
            {
                Console.Write(i+" ");
            }
        }
    }
}
