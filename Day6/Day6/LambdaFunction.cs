using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class LambdaFunction
    {
        public static void Main1()
        {
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> evenNumbers = Numbers.FindAll(x => (x % 2 == 0)); 
            foreach(var item in evenNumbers)
                {
                Console.WriteLine(item);    
            }

            //ODD Numbers
            Console.WriteLine("odd:");

            List<int> oddNumbers = Numbers.FindAll(x => (x % 2 == 1));
            foreach(var item in oddNumbers) { 
            Console.WriteLine(item);
            }
        }
    }
}
