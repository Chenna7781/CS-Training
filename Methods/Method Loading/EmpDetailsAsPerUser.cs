using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Methods.Method_Loading
{
    internal class EmpDetailsAsPerUser
    {
        public static void details(int id,string name)
        {
            Console.WriteLine("Employee id :" + id+" name :"+ name);
        }

        public static void details(string name, int id)
        {
            Console.WriteLine("Employee id :" + id + " name :" + name);
        }


    }
}
