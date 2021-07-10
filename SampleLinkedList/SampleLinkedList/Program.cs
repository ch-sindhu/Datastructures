using System;
using System.Collections.Generic;

namespace SampleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //atlast,atfirst,addbefore,addafter
            LinkedList<string> mylist = new LinkedList<string>();
            mylist.AddLast("hashtable");
            mylist.AddLast("Linkedlist");
            mylist.AddLast("stack");
            mylist.AddLast("Queue");
            mylist.AddLast("data structures");
            Console.WriteLine("Details of data structures");
            foreach(string str in mylist)
            {
                Console.WriteLine(str);
            }
            //After using Remove(LinkedListnode)    
            Console.WriteLine("datastructure details are:");
            mylist.Remove(mylist.First);
            foreach(var item in mylist)
            {
                Console.WriteLine(item);
            }
            //using Remove(T) method
            Console.WriteLine("datastructure details are:");
            mylist.Remove("datastructure");
            foreach(var stng in mylist)
            {
                Console.WriteLine(stng);
            }
            //after using removefirst method
            Console.WriteLine("data structure details are:");
            mylist.RemoveLast();
            foreach(var tng in mylist)
            {
                Console.WriteLine(tng);
            }
            //after using removelast method
            Console.WriteLine("data structure details are:");
            mylist.RemoveLast();
            foreach(var item in mylist)
            {
                Console.WriteLine(item);
            }
            mylist.Clear();
            Console.WriteLine("no of data structure:{0}", mylist.Count);



        }
    }
}
