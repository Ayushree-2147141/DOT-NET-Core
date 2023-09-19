using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class ParameterExample
    {
        //optional parameter
        public void PrintOptional(int a, int b = 10)
        {
            Console.WriteLine("A : "+a+"\nB : "+b);
        }

        //named parameter
        public void PrintNamedParameter(int a, int b)
        {
            Console.WriteLine("A : " + a + "\nB : " + b);
        }
        public static void Main1(string[] args)
        {
            ParameterExample p = new ParameterExample();
            p.PrintOptional(1, 2);
            p.PrintNamedParameter(b: 3, a: 4);
            p.PrintNamedParameter(a: 2, 20);
        }
    }
}
