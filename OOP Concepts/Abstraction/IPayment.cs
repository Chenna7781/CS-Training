using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.OOP_Concepts.Abstraction
{
    public interface IPayment
    {
        //we dont declare it as public
        void Pay();
    }

    public class CreditCardPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("User Paying through CreditCard");
        }
    }

    public class UpiPayment:IPayment
    {
        public void Pay()
        {
            Console.WriteLine("USer paid through UPI");
        }
    }
}
