using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class DemoReadOnly
    {
        public readonly int ab =1 ;
        public DemoReadOnly(int a)
        {
            Console.WriteLine("Iinital value for ab : "+ab);
            ab = a;
        }
        public void show()
        {
            Console.WriteLine("After using constructor changing the value : "+ab);
        }
    }
    internal class ConstReadOnly
    {
        public static void Main1(string[] args)
        {
            const int a = 1;
            DemoReadOnly d = new DemoReadOnly(3);
            d.show();

        }
    }
}
