using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1App
{
    internal class LargestNumberArray
    {
        public static void Main1(string[] args)
        {
            //int [] numbers = {1, 2, 3, 4, 5};
            int[] numbers = new int[5];
            int num;
            for(int i =0; i < 5; i++)
            {
                Console.WriteLine("enter number : " + (i+1));
                num = Convert.ToInt32(Console.ReadLine());
                numbers[i] = num;
            }

            foreach(int val in numbers)
            {
                Console.WriteLine(val);
            }
        }
    }
}
