using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.OOP_Concepts.Abstraction.Coupling
{
    internal interface IPaymentGateway
    {
        void ProcessPayment(decimal amount);
    }

    class StripePaymentGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount) => Console.WriteLine($"Payment Processed {amount} using StripeGateway");
        

    }

    class PayPalGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            amount = 21324234.321432M;
            Console.WriteLine("PayPalGateway : " + amount);
        }
    }

    class OrderService
    {
        private IPaymentGateway ipg;

        public OrderService(IPaymentGateway ipg)
        {
            this.ipg = ipg;
        }

        public void PlaceOrder(decimal amount)
        {
            
            ipg.ProcessPayment(amount);

        }

        //static void Main(string[] args)
        //{
        //    //Inject Dependency from Outside (Composition Root)
        //    decimal amount = 1312312.423M;
        //    IPaymentGateway ipg = new StripePaymentGateway();
        //    //IPaymentGateway ipg1 = new PayPalGateway(); //local varaible
        //    OrderService os = new OrderService(ipg);
        //    os.PlaceOrder(amount);
        //}

    }
}
