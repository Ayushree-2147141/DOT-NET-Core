using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Sample
    {
        private protected int a;

    }
    public class Derived : Sample
    {
        public void show()
        {
            Console.WriteLine(a);
        }
    }

    internal class NamespaceExample
    {
        public static void Main1(string[] args)
        {
            Day3.Demo2.Class3 c1 = new Day3.Demo2.Class3();
            Day3.Demo1.Class1 c2 = new Day3.Demo1.Class1();
            c1.show();
            c2.show();
            System.Console.WriteLine();
        }
    }
}
