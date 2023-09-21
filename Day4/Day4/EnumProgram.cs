using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    enum Status
    {
        Active = 8, 
        Deactive,
        Hold
    }

    enum Weekdays
    {
        Sunday,
        Monday,
        Tuesday , 
        Wednesday, 
        Thursday,
        Friday , 
        Saturday
    }
    internal class EnumProgram
    {
        public static void Main1(string[] args)
        {
            //Console.WriteLine(Status.Active); Active
            //Console.WriteLine((int)Status.Active); 
            int dayNum;
            Console.WriteLine("Enter day number :");
            dayNum = Convert.ToInt16(Console.ReadLine());

            switch((Weekdays)dayNum)
            {
                case Weekdays.Sunday: 
                    Console.WriteLine(Weekdays.Sunday); 
                    break;
                case Weekdays.Monday: Console.WriteLine(Weekdays.Monday);   
                    break;
                case Weekdays.Tuesday: Console.WriteLine(Weekdays.Tuesday);
                    break;
                case Weekdays.Wednesday:    Console.WriteLine(Weekdays.Wednesday);
                    break; 
                case Weekdays.Thursday: Console.WriteLine(Weekdays.Thursday);
                    break;
                case Weekdays.Friday: Console.WriteLine(Weekdays.Friday);
                    break;
                case Weekdays.Saturday: Console.WriteLine(Weekdays.Saturday);
                    break;
                default: Console.WriteLine("Wrong choice!");
                    break;

            }

            string status;
            Console.WriteLine("Enter status : ");
            status = Console.ReadLine();

            switch(status)
            {
                case "active": Console.WriteLine((int)Status.Active); break;
                case "deactive": Console.WriteLine((int)Status.Deactive); break;
                case "hold": Console.WriteLine((int)Status.Hold); break;
                default: Console.WriteLine("default"); break;
            }
        }
    }
}
