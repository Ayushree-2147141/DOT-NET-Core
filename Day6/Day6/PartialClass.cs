using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    partial class Part1
    {
        public void Print1()
        {
            Console.WriteLine("Print 1");
        }
    }

    partial class Part1
    {
        public void Print2()
        {
            Console.WriteLine("Print 2");
        }
    }

    internal class PartialClass
    {
        public static void Main1()
        {
            Part1 p = new Part1();
            p.Print1();
            p.Print2 ();
        }
    }
}
