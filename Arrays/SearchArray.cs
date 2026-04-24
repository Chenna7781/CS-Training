using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Arrays
{
    internal class SearchArray
    {
        public static void searchTarget(int target, params int[] array)
        {
            foreach(var  item in array)
            {
                if (item == target)
                {
                    Console.WriteLine("Element Found");
                    break;
                }
                else
                    Console.WriteLine("Element Not Found");
            }

        }
        
    }
}
