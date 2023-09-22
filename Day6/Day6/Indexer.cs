using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Demo
    {
        //property
        private string[] val = new string[3];
        public string this[int index]
        {
           get { return val[index]; }
            set
            {
                val[index] = value;
            }
        }
    }

    //class as an Array
    internal class Indexer
    {
        public static void Main1()
        {
            Demo demo = new Demo();
            demo[0] = "Ayushree";
            demo[1] = "Chakrabartty";
            Console.WriteLine(demo[0]);
        }
    }
}
