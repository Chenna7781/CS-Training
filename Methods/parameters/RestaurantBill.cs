using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Methods.parameters
{
    internal class RestaurantBill
    {

        public static void totalBill(int bill,out double SGST,out double CGST)
        {
            SGST = (bill * 0.05);
            CGST = (bill * 0.03);
            double total = bill + SGST + CGST;
            Console.WriteLine("Total Bill : " + total);

         
        }
        //public static void Main(string[] args)
        //{
        //    double SGST, CGST;
        //    RestaurantBill.totalBill(11000, out SGST, out CGST);
        //    Console.WriteLine("CGST : " + CGST + " " + " SGST : " + SGST);
        //}

    }
}
