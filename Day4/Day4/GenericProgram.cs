using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    
    internal class GenericProgram
    {
        public static void Main1(string[] args)
        {
            //dictionary
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "Ram");
            dict.Add(2, "shyam");
            dict.Add(3, "Seeta");

            foreach (var item in dict)
            {
                Console.WriteLine(item.Value);
            }

            dict.Remove(2);
            Console.WriteLine("------------------------");
            foreach (var item in dict)
            {
                Console.WriteLine(item.Value);
            }

            //LIST

            Console.WriteLine("*********LIST************");

            List<string> ls = new List<string>();

            ls.Add("name1");
            ls.Add("name2");
            ls.Add("name3");

            foreach(var item in ls)
            {
                Console.WriteLine(item);
            }

            ls.RemoveAt(2);
            Console.WriteLine("****************After removing****************");
            foreach (var item in ls)
            {
                Console.WriteLine(item);
            }
        }
    }
}
