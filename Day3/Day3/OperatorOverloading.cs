using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    //sum 2 objects
   

    class sum
    {
        public int Number;

        public sum(int _Number)
        {
            Number = _Number;
        }

        //<access-specifier> <class name> operator <operator-name> (<parameter>)
        //parameter can be object of the class
        public static sum operator +(sum s1, sum s2)
        {
            sum s3 = new sum(0);
            s3.Number = s1.Number + s2.Number;
            return s3;
            
        }

        public void Print()
        {
            Console.WriteLine("Number value is : " + Number);
        }
    }

    class difference
    {
        int Number1;
        public difference(int _Number1) 
        {
            Number1 = _Number1;
        }
        //<access-specifier> <classname> operator <operator-name> (<parameter>)
        public static difference operator -(difference d1, difference d2)
        {
            difference d3 = new difference(0);
            d3.Number1 = d1.Number1 - d2.Number1;
            return d3;
        }
        public void Print()
        {
            Console.WriteLine("This is difference : " + Number1);
        }
    }
    internal class OperatorOverloading
    {
       public static void Main1(string[] args)
        {
            sum s1 = new sum(1);
            sum s2 = new sum(2);
            sum s3 = new sum(0);

            s3 = s1 + s2;
            s3.Print();

            difference d1 = new difference(10);
            difference d2 = new difference(2);
            difference d3 = new difference(0);

            d3 = d1 - d2;
            d3.Print();



        }
    }
}
