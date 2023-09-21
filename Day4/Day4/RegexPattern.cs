using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Day4
{
    internal class RegexPattern
    {

        public static void Main1(string[] args)
        {
            string pattern = "^[0-9]$";
            Regex rg = new Regex(pattern);

            
            if(rg.IsMatch("332"))
            {
                Console.WriteLine("Pattern matched1");

            }
           

        }
    }
}
