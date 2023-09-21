using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class NormalCollection
    {
        public static void Main1(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add("Ayushree");
            arrayList.Add(4);
            Console.WriteLine("--------------ARRAY LIST--------------");
            foreach(var item in arrayList)
            {
                Console.WriteLine(item);    
            }

            //Queue
            Console.WriteLine("-----------------QUEUE-----------------");
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue("Ayushree");
            queue.Enqueue("deepesh");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("-------------------STACK---------------");
            Stack st = new Stack();
            st.Push("ayushree");
            st.Push(2);
            st.Push("Demo");
            Console.WriteLine("***inserted***");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

            st.Pop();
            Console.WriteLine("***popping***");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }


            //hashtable
            Console.WriteLine("-----------------HASHTABLE--------------");
            Hashtable ht = new Hashtable(); 
            ht.Add(1, 2);
            ht.Add(5, "Ayushree");
            ht.Add("ema", 3);

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine("Key : {0} , Value : {1}", item.Key, item.Value);
            }

            ht.Remove("ema");
            Console.WriteLine("**after removing***");
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine("Key : {0} , Value : {1}", item.Key, item.Value);
            }

            ht[5] = "New name";
            Console.WriteLine("**updated**");
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine("Key : {0} , Value : {1}", item.Key, item.Value);
            }



        }
    }
}
