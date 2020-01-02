using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //HOMEWORK 1---------

            //Console.Write("Input the number of elements to be stored in the array :");
            //int count = 0;
            //int n = int.Parse(Console.ReadLine());
            //int[] array = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Element {0}:", i);
            //    array[i] = int.Parse(Console.ReadLine());

            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {

            //        if (array[i] == array[j])
            //        {
            //            count++;
            //        }
            //    }

            //}
            //Console.WriteLine("Total number of duplicate elements found in the array is: {0}", count);

            //Console.WriteLine("===================================================================================");

            //HOMEWORK 2--------------------

            //Console.Write("Input the size of array :");
            //int m = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input {0} elements in the array in ascending order:", m);
            //int[] aray = new int[m];
            //for (int i = 0; i < m; i++)
            //{
            //    Console.Write("Element {0}:", i);
            //    aray[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Input the position where to delete: 3");
            //Console.Write("The new list is : ");
            //for (int i = 0; i < m; i++)
            //{
            //    if (i == 2)
            //    {
            //        continue;
            //    }

            //    Console.Write(+aray[i] + " ");
            // }

            //Console.WriteLine("===================================================================================");

            //HOMEWORK 3-----------
            //Console.Write("Input the string :");
            //string space = Console.ReadLine();
            //Console.Write("The characters of the string are :");
            //for (int i = 0; i < space.Length; i++)
            //{

            //    Console.Write(space[i] + " ");
            //}

            //Console.WriteLine("===================================================================================");

            //HOMEWORK 4---------------

            Console.Write("Input the string :");
            string a = Console.ReadLine();
            Console.Write("The substring retrieve from the string is :");

            for (int i = 5; i < 10; i++)
            {
                Console.Write(a[i]);
            }
        }
    }
}
