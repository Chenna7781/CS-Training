using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    internal class SlidingWindowMax
    {
        public static void MaxSlidingWindow(int[] nums, int k)
        {
            List<int> list = new List<int>();
            for(int i=0;i<=nums.Length-k; i++)
            {
                int max = 0;
                for(int j = i; j < i + k; j++)
                {
                    if(nums[j] > max) max=nums[j];
                }
                list.Add(max);
            }
            foreach(int i in list)
            {
                Console.Write(i+" ");
            }
        }
    }
}
