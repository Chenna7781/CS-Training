using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CS.Exception_Handling
{
    internal class InnerExceptionn
    {
        public static void InnerException()
        {
            try
            {
                try
                {
                    int x = int.Parse("abc"); // causes FormatException
                }
                catch (Exception ex)
                {
       
                    throw new ApplicationException("Error while processing data", ex);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Main Exception: " + ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
                }

            }
        }
    }
}
