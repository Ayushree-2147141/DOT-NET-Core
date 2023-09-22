using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class EmployeeBankDetails
    {
        public int employeeId;
        public string employeeName;
        public int employeeBalance;

        public void Register(string fp, EmployeeBankDetails emp)
        {
            Console.WriteLine("\n enter employee id : ");
            employeeId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter you name : ");
            employeeName = Console.ReadLine();

            StreamWriter sw = new StreamWriter(fp);
            sw.WriteLine(JsonConvert.SerializeObject(emp));
            sw.Flush();
            sw.Close();

        }

        public void AddMoney(string fp, EmployeeBankDetails emp)
        {
            Console.WriteLine("\nEnter the amount to be added: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            employeeBalance = employeeBalance + amount;

            StreamWriter sw = new StreamWriter(fp);
            sw.WriteLine(JsonConvert.SerializeObject(emp));
            sw.Flush();
            sw.Close();

        }

        public void CheckBalance()
        {
            Console.WriteLine("Your balance amount :" + employeeBalance);

        }

        public void WithdrawMoney(string fp, EmployeeBankDetails emp)
        {
            Console.WriteLine("\nEnter the amount to be withdrawn: ");
            int wamount = Convert.ToInt32(Console.ReadLine());

            if (wamount > employeeBalance)
            {
                Console.WriteLine("\nCan't withdraw!");
                CheckBalance();
            }
            else
            {
                employeeBalance = employeeBalance - wamount;
                StreamWriter sw = new StreamWriter(fp);
                sw.WriteLine(JsonConvert.SerializeObject(emp));
                sw.Flush();
                sw.Close();
            }


        }
    };

    internal class BankingAppFH
    {
        public static void Main(string[] args)
        {

            EmployeeBankDetails emp = new EmployeeBankDetails();
            int ch = 1;

            string FilePath = "C:\\Users\\Administrator\\Desktop\\dotNET\\Day5\\Day5\\bankingapp.txt";

            while (ch != 0)
            {
                Console.WriteLine("1.Register\n2.Add money\n3.Withdraw\n4.Check Balance\n5.Exit");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        emp.Register(FilePath, emp);
                        break;
                    case 2:
                        emp.AddMoney(FilePath, emp);
                        break;
                    case 3:
                        emp.WithdrawMoney(FilePath, emp);
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
