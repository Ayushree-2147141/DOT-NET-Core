using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Stack1<T>
    {

        int currentValue = -1;
        T[] items;
        public Stack1(int size)
        {
            items = new T[size];
        }

        public bool Empty => currentValue == -1;

        public bool Full => currentValue == items.Length - 1;

        public bool Push(T item)
        {
            if(!Full)
            {
                items[++currentValue] = item;
            }
            return false;
        }

        public T? Pop => !Empty ? items[currentValue] : default(T);
    }
    internal class GenericClassProg
    {
        public static void Main(string[] args) 
        { 
            Stack<string> s = new Stack<string>(1);
            s.Push("A");
            s.Push("B");
            Console.WriteLine(s.Pop());
        }

    }
}
