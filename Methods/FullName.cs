using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Methods
{
    internal class FullName
    {

        public string name()
        {
            Console.WriteLine("Enter your FirstName");
            string s = Console.ReadLine();
            Console.WriteLine("Enter your MiddleName");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter your LastName");
            string s2 = Console.ReadLine();


            return "Full Name : " + s +" "+ s1 +" "+ s2;
        }
    }
}
