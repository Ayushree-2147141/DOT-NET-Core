namespace Day1App
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            int number1 = 10;
            //Console.WriteLine("enter the second number :");
            Console.WriteLine("enter the number you want to check :");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum, diff, prod, quo, rem;

            //addition
            sum = number1 + number2;
            diff = number1 - number2;
            prod = number1 * number2;
            quo = number1 / number2;
            rem = number1 % number2;

            Console.WriteLine("Sum : " + sum);
            Console.WriteLine("Diff : " + diff);
            Console.WriteLine("Product : " + prod);
            Console.WriteLine("Quotient : " + quo);
            Console.WriteLine("Remainder : " + rem);


            //If else
            if (number1 > number2)
            {
                Console.WriteLine(number1 + " is greater than " + number2);

            }
            else
            {
                Console.WriteLine(number2 + "is greater than " + number1);
            }


            //even odd
            if (number2 % 2 == 0)
            {
                Console.WriteLine(number2 + " is EVEN");

            }
            else
            {
                Console.WriteLine(number2 + " is ODD");
            }

            //using ternary operator
            string output = (number1 > number2) ? (number1 + " is greater than " + number2) : (number2 + "is greater than " + number1);
            Console.WriteLine(output);
            //Console.WriteLine("Hello, World!");

            int num1 = 10;
            int num2 = 50;
            int num3 = 30;
            //ternary operator
            int largest = ((num1 > num2) ? num1 : num2) > num3 ? num2 : num3;
            Console.WriteLine(largest);


            //
        }
    }
}