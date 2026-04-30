using CS.Methods.Method_Loading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Collections.Properties
{
    internal class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public long Pincode { get; set; }

        public static void Details()
        {
            //Person p = new Person();
            //p.Name = "Shiva";

            Person p = new Person()
            {
                Name = "Sweety",
                Age = 23,
                Address = "Banglore",
                Pincode = 506123
            };

            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Address);
            Console.WriteLine(p.Pincode);
        }

    }
}
