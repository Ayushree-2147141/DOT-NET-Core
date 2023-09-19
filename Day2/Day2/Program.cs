namespace Day2
{
    class Employee
    {
        //field
        private int empId;

        public void PrintEmployee( int empSalary, string empName)
        {
            Console.WriteLine(" \n Salary : " + empSalary + " \n Name : " + empName);
        }

        public Employee()
        {
            Console.WriteLine("My Id is : " + empId);
        }

    }
    internal class Program
    {
        static void Main1(string[] args)
        {
            string empName;
            int empSalary;
            Console.WriteLine("Enter name : ");
            empName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter salary : ");
            empSalary = Convert.ToInt32(Console.ReadLine());

            Employee emp = new Employee();
            emp.PrintEmployee(empSalary, empName);

        }
    }
}