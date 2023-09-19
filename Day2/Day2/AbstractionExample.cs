using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    abstract class AnimalTest
    {
        string name;
        //SetName (string name), GetName and Eat

        public void SetName(string _name)
        {
            name = _name;
        }
        public void GetName()
        {
            Console.WriteLine("Name : " + name);
        }

        abstract public void Eat();


    }

    class Dog : AnimalTest
    {
        public override void Eat()
        {
            Console.WriteLine("Dog is eating");
        }
    }
    internal class AbstractionExample
    {
        public static void Main1(string[] args)
        {
            Dog d = new Dog();
            d.SetName("Tuffu");
            d.GetName();
            d.Eat();
        }
    }

}
