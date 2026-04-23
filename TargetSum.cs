using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    internal class TargetSum
    {
        public static int[] Run(int[] arr, int target)
        {
            for(int i = 0; i < arr.Length; i++)
                {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == target)
                        return new int[] { arr[i], arr[j] };
                }
            }
                

            return new int[0];
        }
    }

}
