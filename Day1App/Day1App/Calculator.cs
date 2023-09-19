using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1App
{
    internal class Calculator
    {
        public static void UserChoice(int choice, int a, int b)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("sum : " + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Difference : " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Product : " + (a * b));
                    break;
                case 4:
                    Console.WriteLine("Quotient  : " + (a / b));
                    break;

                default:
                    Console.WriteLine("Please choose different number :");
                    break;

            }
        }
        public static void Main1(string[] args)
        {
            Console.WriteLine("Press : \n 1. Add \n2. Subtract \n3. Product\n4. Division\n");
            Console.WriteLine("enter choice :");
            int ch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            UserChoice(ch, num1, num2);
        }
    }
}