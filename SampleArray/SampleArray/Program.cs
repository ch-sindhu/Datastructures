using System;

namespace SampleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = new int[5];
            array[0] = 10;
            array[1] = 20;
            array[2] = 30;
            array[3] = 40;
            array[4] = 50;
            Console.WriteLine("for loop");
            for (int i = 0; i < array.Length; i++)
                Console.Write("   " + array[i]);
            Console.WriteLine("for-each loop");
            foreach(int i in array)
            {
                Console.Write("  " + i);
            }

            Console.Write("while loop");
            int j = 0;
            Console.WriteLine();
            while (j < array.Length)
            {
                Console.Write("   " + array[j]);
                j++;
            }
            Console.WriteLine();
            Console.Write("do while loop");
            int k = 0;
            do
            {
                Console.Write("  " + array[k]);
                k++;
            } while (k > array.Length);

            }
        }
    }

