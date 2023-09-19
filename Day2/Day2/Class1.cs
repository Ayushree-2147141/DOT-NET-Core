using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Class1
    {
       public static void Main1(string[] args)
        {
            Object[] objects = new Object[2];
            objects[0] = 1;
            objects[1] = "Ayushree"; 

            foreach(var item in objects)
            {
                //Console.WriteLine(item);
                if(item is string)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    var str = item as string;
                    Console.WriteLine(str);
                }
            }
        }

    }
}
