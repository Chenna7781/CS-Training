using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    internal class MaxSubArraySum
    {
        
        public static void SubArraySum(int[] arr, int windowSize)
        {
            int max = 0;
            for (int i = 0; i < arr.Length-windowSize; i++)
            {
                int sum = 0;

                for(int j = i; j <i+windowSize; j++)
                {
                  sum += arr[j];
               
                }
                if (sum > max) max = sum;
            }
            Console.WriteLine("Max SubArray Sum : "+max);
        }
    }

}
