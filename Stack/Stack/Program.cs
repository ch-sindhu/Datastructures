using System;
using System.Collections;

namespace datastructures

{
    class Program
    {
        static void Main(string[] args)
        {
            //last in first out
            Stack mystack = new Stack();
            mystack.Push("Hello");
            mystack.Push("world");
            mystack.Push("!");
            Console.WriteLine("mystack");
            Console.WriteLine("\t count: {0}", mystack.Count);
            Console.WriteLine("Values");
            foreach (var item in mystack)
                Console.Write("  {0} ", item);
            Console.WriteLine();

        }

    }
}
