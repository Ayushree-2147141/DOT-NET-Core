using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 1. Dictionary<>
2.List <>
3. Queue <>
4. Stack <>
5. HashSet<>
6. LinkedList <>
 */
namespace Day4
{
    internal class GenericProgramTask
    {

        public static void Main1(string[] args)
        {
            int ch;
            Console.WriteLine("\nEnter \n 1. dictionary\n 2.List\n3.Queue\n4.Stack\n5.HashSet\n6.LinkeList\nEnter your choice: ");
            ch = Convert.ToInt32(Console.ReadLine());   

            switch(ch)
            {
                //dictionary
                case 1: Dictionary<int, string> dict = new Dictionary<int, string>();
                    //adding 
                    Console.WriteLine("\nEnter two names : ");
                    string name1, name2;

                    name1 = Console.ReadLine();
                    name2 = Console.ReadLine(); 

                    dict.Add(1, name1);
                    dict.Add(2, name2);

                    Console.WriteLine("after inserting--------------");
                    foreach(var item in dict)
                    {
                        Console.WriteLine($"{item}");
                    }


                    //update
                    Console.WriteLine("enter id for updation: ");
                    int uid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter name : ");
                    string newname = Console.ReadLine();
                    dict[uid] = newname;

                    Console.WriteLine("after updating--------------");
                    foreach (var item in dict)
                    {
                        Console.WriteLine($"{item}");
                    }

                    Console.WriteLine("\n enter 1 or 2 to remove the name! : ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    dict.Remove(id);

                    Console.WriteLine("after removing ---------------");
                    foreach (var item in dict)
                    {
                        Console.WriteLine(item.Value);
                    }


                    break;

                case 2: List<string> ls = new List<string>();
                    string name;
                    for(int i=0; i<3; i++)
                    {
                        Console.WriteLine("\nEnter name : ");
                        name = Console.ReadLine();

                        ls.Add(name);
                    }

                    //printing
                    Console.WriteLine("inserted------------");
                    foreach(string item in ls)
                    {
                        Console.WriteLine(item);
                    }

                    Console.WriteLine("Enter id for updation : ");
                    int id1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter name : ");
                    string newnamels = Console.ReadLine();
                    ls[id1] = newnamels;

                    //printing
                    Console.WriteLine("updated------------");
                    foreach (string item in ls)
                    {
                        Console.WriteLine(item);
                    }

                    //remove
                    Console.WriteLine("Enter id for deletion : ");
                    id1 = Convert.ToInt32(Console.ReadLine());

                    ls.RemoveAt(id1);



                    //printing
                    Console.WriteLine("deleted------------");
                    foreach (string item in ls)
                    {
                        Console.WriteLine(item);
                    }

                    break;

                case 3:
                    Queue<string> q = new Queue<string>();
                    Console.WriteLine("\nEnter names : ");
                    string nameQ;
                    for(int i =0; i<3;i++)
                    {
                        nameQ = Console.ReadLine();
                        q.Enqueue(nameQ);
                    }

                    //printing
                    Console.WriteLine("enquue");
                    foreach(string item in q)
                    {
                        Console.WriteLine(item);
                    }

                    q.Dequeue();
                    Console.WriteLine("dequeue");
                    foreach (string item in q)
                    {
                        Console.WriteLine(item);
                    }
                    


                    break;
            }
        }
    }
}
