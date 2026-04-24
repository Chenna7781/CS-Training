using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Methods
{
    internal class AreaOfCircle
    {

        public void area(int radius)
        {
            double d = 3.14 * radius * radius;
            Console.WriteLine("Area of circle : " + d);
        }
    }
}
