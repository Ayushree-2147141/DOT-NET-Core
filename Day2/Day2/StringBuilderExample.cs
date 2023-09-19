using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class StringBuilderExample
    {
        public static void Main1(string[] args)
        {
            string str1 = "Ayushree";
            string str2 = "New name";
            StringBuilder strBuid = new StringBuilder();
            strBuid.Append(str2);
            Console.WriteLine(str2);

            StringBuilder s = new StringBuilder("HELLO ", 20);

            s.Append("GFG");

            // after printing "GEEKS"
            // a new line append
            s.AppendLine("GEEKS");

            s.Append("GeeksForGeeks");
            Console.WriteLine(s);
        }
    }
}
