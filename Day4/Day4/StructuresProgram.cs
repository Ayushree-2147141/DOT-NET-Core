using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    //Structures : collection of different data types <heterogeneous>
    //class <heap memory, dividing large problem into chunks(enterprise level)>
    //structures <stack memory, small problem> 

    //STRUCTURE
    struct Employee
    {
        public int employeeId;
        public string employeeName;

        public void GetEmployeeDetails()
        {
            Console.WriteLine("Enter employee id : ");
            employeeId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter employee Name : ");
            employeeName =Console.ReadLine();
        }

        public void PrintEmployeeDetails()
        {
            Console.WriteLine("Employee ID : " + employeeId);
            Console.WriteLine("Employee Name : " + employeeName);
        }
    };


    internal class StructuresProgram
    {
        public static void Main1(string[] args)
        {
            int num;
            Console.WriteLine("Enter the strength of employees : ");
            num = Convert.ToInt32(Console.ReadLine());
            Employee[] emp = new Employee[num];

            for(int i = 0; i < num; i++) 
            {
                emp[i].GetEmployeeDetails();
                //emp.PrintEmployeeDetails();
            }
            
            
            for(int i = 0; i < num;i++)
            {
                emp[i].PrintEmployeeDetails(); 
            }

            //emp.employeeId = 1; 
            //emp.employeeName = "Test";
            //Console.WriteLine(emp.employeeId);
            //Console.WriteLine(emp.employeeName);

            //print employee details

        }
    }
}
