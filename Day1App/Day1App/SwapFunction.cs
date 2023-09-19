using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1App
{
    internal class SwapFunction
    {
        public static void Swap(int a, int b)
        {
            a += b;
            b = a - b;
            a -= b;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        public static void Main1(string[] args)
        {
            int a = 10;
            int b = 20;

            Swap(a, b);
        }
    }
}