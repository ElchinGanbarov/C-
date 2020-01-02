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
            //Console.WriteLine("Enter the Number: ");
            //int number = int.Parse(Console.ReadLine());
            //int count=0;
            //int n=0;

            //while (n < number)
            //{
            //    n++;
            //    if (number % n == 0)
            //    {
            //        count++;   
            //    }
            //}
            //if (count == 2)
            //{
            //    Console.WriteLine("Eded sadedir");
            //}
            //else { Console.WriteLine("Eded murekkebdir"); }

            //Console.WriteLine("Enter the Number: ");
            //int number = int.Parse(Console.ReadLine());
            //int fakt = 1;

            //while (true)
            //{
            //    if (number < 1) { break; }
            //    fakt *= number;
            //    number--;
            //}

            //Console.WriteLine(fakt);
            //do
            //{
            //    fakt *= number;
            //    number--;
            //} while (number>0);
            //Console.WriteLine(fakt);

            //for (int i = 1, sum = 1; i <= 128; i *= 2, sum += i)
            //{
            //    Console.WriteLine("i={0},sum={1}",i,sum);
            //}

            //int a = 5;
            //int b = 2;
            //int result = 1;
            //for(int i = 0; i < 5; i++)
            //{
            //    result *= b;
            //}
            //Console.WriteLine(result);

            //int n = int.Parse(Console.ReadLine());
            //for(int row = 1; row <= n; row++)
            //{
            //    for(int col = 1; col <= row; col++)
            //    {
            //        Console.WriteLine(col + " ");
            //    }
            //    Console.WriteLine();

            //}
            //fakt *= i;

            //if (n == Math.Pow(10, i))
            //{
            //    Console.WriteLine(i);
            //}

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= n; i += 2)
            {
                if (i % 7 == 0)
                {
                    break;
                }
     
                sum += i;
                Console.WriteLine("sum={0},i={1}", sum, i);
            }
          
        }
    }
}
