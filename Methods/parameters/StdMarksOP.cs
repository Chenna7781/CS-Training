using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Methods.parameters
{
    internal class StdMarksOP
    {
        public static void subjectMrk(double x,double y,double z,out double totalMrks,out double avg)
        {
            totalMrks = x + y + z;
            avg = totalMrks / 3;

        }

        //public static void Main(string[] args)
        //{
        //    double totalMrks, avg;
        //    StdMarksOP.subjectMrk(10.2, 22.5, 86.3, out totalMrks, out avg);
        //    Console.WriteLine("total marks : " + totalMrks + " " + " Average : " + avg);
        //}
    }
}
