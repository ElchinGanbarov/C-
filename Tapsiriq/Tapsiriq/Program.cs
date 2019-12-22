using System;

namespace Tapsiriq
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //string b;
            //do
            //{
            //    b = Console.ReadLine();
            //    i++;
            //} while (i <= 4 && b==" ");
            //if (b=="user")
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}

            //double x;

            //for (int y = -5; y <= 5; y++)
            //{
            //    x = Math.Pow(y, 2) + 2 * y + 1;
            //    Console.WriteLine(x);
            //}

            //Console.WriteLine("Input the first number");
            //int first = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Input the second number");
            //int second = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Input the third number");
            //int third = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("En boyuk reqem");
            //if(first>second && first > third) { Console.WriteLine(first); }
            //else if(second>first && second > third) { Console.WriteLine(second);}
            //else { Console.WriteLine(third); }
            int x = 0;
            for(int i = 1; i <= 10; i++)
            {
                x += i;
            }
            Console.WriteLine(x);





        }
    }
}
