using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    static class StaticDemoClass
    {
        public static int a;
        //public int c;
    }
    class StaticDemoClass2
    {
        static StaticDemoClass2()
        {
            Console.WriteLine("Hi i am static constructor");
        }
        public StaticDemoClass2()
        {
            Console.WriteLine("Hi i am default constructor");
        }
        public StaticDemoClass2(int a)
        {
            Console.WriteLine("Hi i am parameteized constructor");

        }
        public static int a;
        public int c;


    }

   class D
    {
        private D()
        {

        }
        public static D getInstance()
        {
            return new D();
        }
    }

    internal class StaticMember
    {
        public static void Main1(string[] args)
        {
            StaticDemoClass.a = 1;
            StaticDemoClass2 st = new StaticDemoClass2();
            D.getInstance();

        }
    }
}
