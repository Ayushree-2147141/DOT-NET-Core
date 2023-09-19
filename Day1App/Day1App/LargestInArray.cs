using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1App
{
    internal class LargestInArray
    {
        public static int LargestNumber(int[] a)
        {
            int temp;
            int total = a.Length;


            for (int i = 0; i < total; i++)
            {
                for (int j = i + 1; j < total; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            return(a[total - 1]);
        }
        public static void Main(string[] args)
        {
            int [] arr = { 18, 12, 33, 24, 15 };
            //dynamic a = 0;
            Console.WriteLine(LargestNumber(arr));
        }
    }
}
