using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    

    internal class DelegateCalculator
    {

        public delegate void addNumber(int a, int b);
        public delegate void subtractNumber(int a, int b);
        public delegate void productNumber(int a, int b);
        public delegate void divideNumber(int a, int b);

        void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        void Difference(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        void Product(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        void Quotient(int a, int b)
        {
            Console.WriteLine(a / b);
        }



        public static void Main1()
        {
           
            Console.WriteLine("\nEnter \n a: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n b: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int ch = 1;
            DelegateCalculator dc = new DelegateCalculator();
            while(ch != 0)
            {
                Console.WriteLine("\n1.Add\n2.Subtract\n3.Product\n4.Divide\n Enter: ");
                 ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        addNumber obj1 = new addNumber(dc.Sum);
                        obj1(num1, num2);
                        break;
                    case 2:
                        subtractNumber obj2 = new subtractNumber(dc.Difference);
                        obj2(num1, num2);

                        break;
                    case 3:
                        productNumber obj3 = new productNumber(dc.Product);
                        obj3(num1, num2);

                        break;
                    case 4:
                        divideNumber obj4 = new divideNumber(dc.Quotient);
                        obj4(num1, num2);


                        break;

                }
            }
            
            
            
        }
    }
}
