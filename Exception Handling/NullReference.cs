using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CS.Exception_Handling
{
    internal class NullReference
    {
        string s = null;
        
        public void Print()
        {
            Console.WriteLine(s);
        }


        //static void Main(string[] args)
        //{
        //    NullReference n = null;
        //    Console.WriteLine(n);

        //}
    }
}
