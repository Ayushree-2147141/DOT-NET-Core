using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    interface IA
    {
         void Show();

    }

    interface IB
    {
        public void Print();
         void Show();
    }

    class C : IA, IB
    {
        public void Print()
        {
            Console.WriteLine("I am print method from IB");
        }

         void IA.Show()
        {
            Console.WriteLine("I am show method from IA");
        }
         void IB.Show()
        {
            Console.WriteLine("I am show method from IB");
        }
    }
    internal class MultipleInheritance
    {
        public static void Main1(string[] args)
        {
            C obj1 = new C();
            //obj1.Show(); 
            //obj1.Print();   

            IA a = new C();
            a.Show();

            IB b = new C();
            b.Show();
            b.Print();
        }
    }
}
