using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    //handling events using delegate 
    delegate void OrderEventHandler();
    class Order
    {
        public event OrderEventHandler onOrderCreated;
        public void Create()
        {
            Console.WriteLine("Order created!");
            //SMS.Send();
            //Email.Send();
            if(onOrderCreated != null) onOrderCreated();
        }
    }

    class SMS
    {
        public static void Send()
        {
            Console.WriteLine("SMS Sent");
        }
    }

    class Email
    {
        public static void Send()
        {
            Console.WriteLine("Email sent");
        }
    }


    internal class EventsDemo
    {
        public static void Main1() 
        {
            var Order = new Order();
            Order.onOrderCreated += Email.Send;
            //to not perform an action
            Order.onOrderCreated -= Email.Send;
            Order.onOrderCreated += SMS.Send;
            Order.Create();
        }
    }
}
