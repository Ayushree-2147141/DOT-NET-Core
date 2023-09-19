using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    //demonstration of IS vs AS operator
    //AS : Typecast
    //IS : Matching left with right
    internal class IsVsAs
    {
        public static void Main1(string[] args)
        {
            string str1 = "Ayushree";
            int str2 = 23;
            if(str2 is string)
            {
                Console.WriteLine("String value");
            }
            else
            {
                Console.WriteLine("Not string value");
            }
        }
    }
}
