using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1App
{
    internal class JaggedArray
    {
        public static void Main1(string[] args)
        {
            int[][] arr = new int[2][];
            arr[0] = new int[] { 3, 4, 5 };
            arr[1] = new int[] { 2, 6, 7 };

            for (int n = 0; n < arr.Length; n++)
            {

                // Print the row number
                System.Console.Write("Row({0}): ", n);

                for (int k = 0; k < arr[n].Length; k++)
                {

                    // Print the elements in the row
                    System.Console.Write("{0} ", arr[n][k]);
                }
                System.Console.WriteLine();
            }


        }

    }
}
