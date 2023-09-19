using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    abstract class AnimalTestF
    {
        string name;
        protected void SetName(string _name)
        {
            name = _name;
        }
        protected void GetName()
        {
            Console.WriteLine(name);
        }

        abstract protected void Eat();
    }
    class DogTest : Animal
    {
        int age;
        public DogTest(int _age, string _name):base(_name)
            {
            age = _age;
        }
        protected static void Eat()
        {
            Console.WriteLine("dog is eating");
        }
    }
    internal class AbstractionExampleFinal
    {
        public static void Main1() {
            DogTest d = new DogTest(12, "Tuufu");
            //d.Eat();
        }
    }
}
