using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class ParsingData
    {
        public static void Main1(string[] args)
        {
            int sample;
            string val;
            val = Console.ReadLine();
            bool result = int.TryParse(val, out sample);
            Console.WriteLine(result);
            Console.WriteLine(sample);
        }
    }
}
