using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Exception_Handling
{
    internal class ArrayIndex
    {
        public void Array()
        {
            int[] a = { 1, 2, 23, 3 };
            Console.WriteLine(a[4]); // System.IndexOutOfRangeException: Index was outside the bounds of the array.
        }

        //static void Main(string[] args)
        //{
        //    ArrayIndex a = new ArrayIndex();
        //    a.Array();

        //}
    }
}
