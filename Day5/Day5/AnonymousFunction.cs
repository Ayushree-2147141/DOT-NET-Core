using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    //Anonymous : without name
    internal class AnonymousFunction
    {
        //DELEGATORS
        //<access-modifiers> delegate <return> method (Paramerter)
        public delegate void addNumber(int a, int b);

        void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Main1()
        {
            Console.WriteLine("hi");
            //BLOCK 
            {
                Console.WriteLine("I am coming from block!");

            }

            
            var employee = new { studentId = 1 , studentName = "Ayushree"};
            Console.WriteLine(employee.studentId);

            //DELEGATE  
            AnonymousFunction cl = new AnonymousFunction();

            //link delegate nd method
            addNumber obj = new addNumber(cl.Sum);
            obj(1, 2);


        }
    }
}
