using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.OOP_Concepts.Abstraction
{
    internal class HybridAbstraction
    {
        //static void Main(string[] args)
        //{
        //    List<Notification> list = new List<Notification>();

        //    list.Add(new EmailNotification());
        //    list.Add(new SmsNotification());

        //    //list.Add(new IRetryable()); // can't create an instance for an interface
        //    //list.Add(new Notification()); // can't create an instance for an abstract type


        //    foreach (var i in list)
        //    {
        //        i.Send();
        //        i.Log();

        //    }
        //}
    }

    //abstract class
   public abstract class Notification
    {
        public abstract void Send();

        public void Log()
        {
            Console.WriteLine("Notification Logged");
        }
    }

    //interface 
    interface IRetryable
    {
        void Retry();
    }

    //EmailNotification Extends Notification and Implements Iretryable
    class EmailNotification: Notification, IRetryable
    {
      public override void Send()
        {
            Console.WriteLine(" Email Notification");
        }

        public void Retry() => Console.WriteLine("Retry Email");
        
    }

    //SmsNotification Extends Notification and Implements IRetryable
    class SmsNotification : Notification,IRetryable
    {
        public void Retry() => Console.WriteLine("Retry SMS");
        public override void Send() => Console.WriteLine("SMS Notification");
    }


}
