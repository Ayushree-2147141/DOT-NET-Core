using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Person
    {
        protected int personAge;
        public void Greet()
        {
            Console.WriteLine("Hello");
        }

        public void SetAge(int age)
        {
            personAge = age;
            
        }
    }

    class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I am Studying");
        }

        public void ShowAge()
        {
            Console.WriteLine("I am " + personAge + " years old");
        }
    }

    class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining on the screen.");
        }
    }


    internal class Inheritance
    {
        public static void Main1()
        {
            Person p = new Person();
            p.Greet();
            //p.SetAge(12);

            Student s = new Student();  
            s.Greet();
            s.Study();
            s.SetAge(12);
            s.ShowAge();

            Teacher t = new Teacher();
            t.Greet();
            t.Explain();


            Console.ReadLine();
        }
       
        //Console.ReadLine();
    }
}
