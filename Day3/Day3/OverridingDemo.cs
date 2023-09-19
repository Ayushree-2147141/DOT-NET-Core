using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Animal
    {
        //public virtual void show()
         public void show()
        {
            Console.WriteLine("I am Base");
        }
        public string name;
    }

    class Dog : Animal
    {
        //shadowing
        new int name;
        //public override void show()
        public void show()
        {
            Console.WriteLine("I am Derived");
        }
    }
    internal class OverridingDemo
    {
        public static void Main1(string[] args)
        {
            Dog d1 = new Dog();
            d1.show();

            Animal a1 = new Dog();   
            a1.show();
            //Console.ReadKey();
        }
    }
}
