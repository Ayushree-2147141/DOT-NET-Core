using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class BankingApp
    {
        public static void Main(string[] args)
        {

            Hashtable personBank = new Hashtable();
            

            
            

               
                        Console.WriteLine("Enter name : ");
                        string name = Console.ReadLine();
                        
                        personBank.Add(name, 0);
                        Console.WriteLine("Registered");

                 
                        
                        Console.WriteLine("Enter amount to add :");
                        int amt1 = Convert.ToInt32(Console.ReadLine());

                        personBank.Add(name, amt1);
            int newamt;
            Console.WriteLine("do you want to add more ? ");
            int ch = Convert.ToInt32(Console.ReadLine());
            if(ch == 1)
            {
                int amt = Convert.ToInt32(Console.ReadLine());

                newamt = amt + amt1;

                personBank.Add(name, newamt);
            }

            //Console.WriteLine(newamt);


            Console.WriteLine("do you want to withdraw amount ? ");
            int ch1 = Convert.ToInt32(Console.ReadLine());
            if (ch1 == 1)
            {

                int wamt = Convert.ToInt32(Console.ReadLine());
                foreach(DictionaryEntry de in  personBank)
                {
                    int newValue = Convert.ToInt32(de.Value) - wamt;
                    personBank.Add(name, newValue);
                }
                
            }


            foreach (DictionaryEntry de in personBank)
            {
                Console.WriteLine(de.Key);
                Console.WriteLine(de.Value);
            }






        }
    }
}
