using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CS.Methods.parameters
{
    internal class OutParameter
    {
        public static void getValues(int x,int y,out int sum,out int prod)
        {
            sum = x + y;
            prod = x * y;
        }


        //int sum, prod;
        //OutParameter.getValues(10, 20, out  sum, out  prod);
        //Console.WriteLine("Sum : "+sum + " -- "+" product : " + prod);
    }
}
