using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    abstract class Animal
    {
        protected string name;
        public Animal(string _name)
        {
            name = _name;
        }

    }

    sealed class Mammal : Animal
    {
        int age;
        public Mammal(int _age, string _name):base(_name)
        {
            age = _age;
        }
        public void Display()
        {
            Console.WriteLine("Name : " + name + "\nAge : " + age);

        }
    }
    internal class AbstractExample
    {
        public static void Main1(string[] args)
        {
            Mammal m = new Mammal(33, "COW");
            m.Display();
        }
    }
}
