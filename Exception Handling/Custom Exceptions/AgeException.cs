using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Exception_Handling.Custom_Exceptions
{
    internal class AgeException : Exception
    {
        public AgeException(string message) : base(message) { }


        //static void Main(string[] args)
        //{
        //    int age = 16;
        //    if (age < 18)
        //    {
        //        throw new AgeException("Minor"); //Unhandled Exception: CS.Exception_Handling.Custom_Exceptions.AgeException: Minor
        //    }
        //}

    }


}
