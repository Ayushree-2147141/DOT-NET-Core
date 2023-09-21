using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class CustomIdException : Exception
    {
        public CustomIdException() 
        {
            Console.WriteLine("Id should not be greater than 300");
        }
    }
    class Student
    {
        int studentId;
        string studentName;

        public Student(int id, string name)
        {
            studentId = id;
            studentName = name;
            try
            {
                if (id > 300)
                {
                    throw new CustomIdException();
                }
                else
                {
                    Console.WriteLine("id accepted!");
                }
            }

            catch(CustomIdException c)
            {
                Console.WriteLine(c.Message);
            }
            
        }
    }
    internal class CustomExceptionTask
    {
        public static void Main1(string[] args) 
        {
            int id;
            Console.WriteLine("Enter id : ");
            id = Convert.ToInt32(Console.ReadLine());

            string name;
            Console.WriteLine("enter name");
            name = Console.ReadLine();

            Student st = new Student(id, name);
        }
    }
}
