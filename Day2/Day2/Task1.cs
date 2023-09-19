using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day2
{
    internal class Task1
    {
        protected int id = 1 ;
        public void AddEmployee()
        {
            string name;
            int sal;
            Console.WriteLine("\nName :");
            name = Console.ReadLine();

            Console.WriteLine("\nSalary : ");
            sal = Convert.ToInt32(Console.ReadLine());

            id = id + 1;


        }


        public void DeleteEmployee()
        {

        }

        public void ListEmployee()
        {
            Console.WriteLine("Employee Record: ");
            Console.WriteLine("\tId      : " + empId);
            Console.WriteLine("\tName     : " + empName);
            Console.WriteLine("\tSalary   : " + empSalary);
        }

        public void UpdateEmployee()
        {

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("\nPress \n1. Add\n2. Update\n3. Delete\n4. List\n0. Exit\nEnter your choice: ");
            int ch = Convert.ToInt32(Console.ReadLine());
            Task1 emp = new Task1();
            while(ch != 0)
            {
                switch (ch)
                {
                    case 1:
                        emp.AddEmployee();
                        break;

                    case 2: 
                        emp.UpdateEmployee();
                        break;
                    case 3:
                        emp.DeleteEmployee();
                        break;
                    case 4:
                        
                        emp.ListEmployee();
                        break;
                    default: Console.WriteLine("\nWrong choice");
                        break;
                }
            }

            
        }
    }
}
