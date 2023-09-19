using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    interface IVehiculo
    {
        public void Drive();
        public bool Refuel(int gasolineAmount);
    }

    class Car : IVehiculo
    {
        public int amt;
        public Car()
        {
            Console.WriteLine("enter gasoline : ");
            amt = Convert.ToInt32(Console.ReadLine());
            Refuel(amt);

        }
        public void Drive()
        {
            Console.WriteLine("the car is Driving");
        }
        public bool Refuel(int gasolineAmount)
        {
            if(gasolineAmount > 0)
            {
                Drive();
                return true;
            }
            else
            {
                gasolineAmount = 10;
                Console.WriteLine("Increased amount to : " + gasolineAmount);
                Refuel(gasolineAmount);

                return true;
            }
            
        }
    }

    internal class Interface
    {
        public static void Main1(string[] args)
        {
            Car c = new Car();
            // Console.ReadLine();
        }
    }
}
