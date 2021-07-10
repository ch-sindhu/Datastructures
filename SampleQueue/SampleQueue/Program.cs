using System;
using System.Collections;

namespace SampleQueue
{
    class Program
    {
        static void Main(string[] args)
        { 
            //FIFO first in first out
            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World");
            myQ.Enqueue("!");
            Console.WriteLine("myqueue");
            Console.WriteLine("\t count:{0}" ,myQ.Count);
            Console.WriteLine("values");
            PrintValues(myQ);
        }
        public static void PrintValues(IEnumerable myCollection)
        {
            foreach(var item in myCollection)
            {
                Console.Write(" {0} ", item);
                
            }
        }
    }
}
