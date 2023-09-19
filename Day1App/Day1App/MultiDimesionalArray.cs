using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1App
{
    internal class MultiDimesionalArray
    {
        public static void Main1(string[] args)
        {
            int[,] arr1 = { { 1, 2 }, { 4, 5 } };
            int[,] arr2 = { { 1, 2 }, { 4, 5 } };
            int[,] sum = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    //sum[i, j] = arr1[i, j] + arr2[i, j];
                    //Console.WriteLine(i + "  " + j);
                    sum[i, j] = arr1[i, j] + arr2[i,j];
                    // Console.WriteLine(sum[i,j]);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
