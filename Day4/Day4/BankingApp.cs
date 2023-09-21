using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    struct EmployeeBankDetails
    {
        public static int employeeId;
        public static string employeeName;
        public static int employeeBalance;

        public void Register()
        {
            Console.WriteLine("\n enter employee id : ");
            employeeId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter you name : ");
            employeeName = Console.ReadLine();

           
        }

        public void AddMoney()
        {
            Console.WriteLine("\nEnter the amount to be added: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            employeeBalance = employeeBalance + amount;

        }

        public void CheckBalance()
        {
            Console.WriteLine("Your balance amount :" + employeeBalance);

        }

        public void WithdrawMoney()
        {
            Console.WriteLine("\nEnter the amount to be withdrawn: ");
            int wamount = Convert.ToInt32(Console.ReadLine());

            if(wamount > employeeBalance)
            {
                Console.WriteLine("\nCan't withdraw!");
                CheckBalance();
            }
            else
            {
                employeeBalance = employeeBalance - wamount;
            }

            
        }
    };

    

    internal class BankingApp
    {
        public static void Main(string[] args)
        {

            EmployeeBankDetails emp = new EmployeeBankDetails();
            int ch = 1;
             
            while(ch!=0)
            {
                Console.WriteLine("1.Register\n2.Add money\n3.Withdraw\n4.Check Balance\n5.Exit");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        emp.Register();
                        break;
                    case 2:
                        emp.AddMoney();
                        break;
                    case 3:
                        emp.WithdrawMoney();
                        break;
                    case 4:
                        emp.CheckBalance();
                        break;
                    default:
                        Console.WriteLine("wrong choice!");
                        break;
                }

            }

        }
    }
}
