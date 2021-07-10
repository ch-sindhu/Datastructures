using System;
using System.Collections;

namespace SampleHashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable my_hashtable1 = new Hashtable();
            my_hashtable1.Add("A1", "Welcome");
            my_hashtable1.Add("A2", "to");
            my_hashtable1.Add("A3", "GeeksforGeeks");
            Console.WriteLine("key and value pairs for hashtable1:");
            foreach (DictionaryEntry ele1 in my_hashtable1)
            {
                Console.WriteLine("{0} and {1}  ", ele1.Key, ele1.Value);
            }
            Hashtable my_hashtable2 = new Hashtable() { { 1, "Hello" }, { 2, 234 }, { 3, 230.4 }, { 4, null } };
            Console.WriteLine("Key and Value pairs from hashtable2:");
            foreach(var ele2 in my_hashtable2.Keys)
            {
                Console.WriteLine("{0} and {1}  ", ele2, my_hashtable2[ele2]);
            }
            Console.WriteLine(my_hashtable1.Contains("A3"));
            Console.WriteLine(my_hashtable1.Contains(12)); ;
            Console.WriteLine();
            Console.WriteLine(my_hashtable1.ContainsKey("A!"));
            Console.WriteLine(my_hashtable1.ContainsKey(1));
            Console.WriteLine();
            Console.WriteLine(my_hashtable1.ContainsValue("geeks"));
            Console.WriteLine(my_hashtable1.ContainsValue("TO"));


            my_hashtable1.Remove("A2");
            Console.WriteLine("Key and value pairs");
            foreach(DictionaryEntry sls1 in my_hashtable1)
            {
                Console.WriteLine(" {0} and {1} ", sls1.Key, sls1.Value);

            }
            my_hashtable1.Clear();
            Console.WriteLine("total numbers of count", my_hashtable1.Count);
           
          

        }
    }
}
