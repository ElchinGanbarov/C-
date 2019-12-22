using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._12._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gun gun = new Gun(200, 30, false);
            //Console.WriteLine(gun.TotalPistolCount);
            //Console.WriteLine(gun.PistolCapacity);
            //Console.WriteLine(gun.CurrentPistolCount);
            //Console.WriteLine(gun.Issingle);
            //gun.Reload();
            //gun.Shot();
            //Console.WriteLine("==============================");
            //Console.WriteLine(gun.TotalPistolCount);
            //Console.WriteLine(gun.CurrentPistolCount);
            //Console.WriteLine(gun.Issingle);
            //gun.Reload();
            //Console.WriteLine(gun.TotalPistolCount);
            //Console.WriteLine(gun.CurrentPistolCount);
            //Console.WriteLine(gun.Issingle);
            //gun.ChangeMood();
            //gun.Shot();
            //gun.AddTotal(150);
            //Console.WriteLine("==============================");
            //Console.WriteLine(gun.TotalPistolCount);
            //Console.WriteLine(gun.CurrentPistolCount);
            //Console.WriteLine(gun.Issingle);

            //Funksion variable = new Funksion();
            //variable.Funk = 10;
            //Console.WriteLine(variable.Functriol());

            //variable.Fibonacci(6);

            //variable.get(12);


            //variable.Month = 11;
            //variable.Search();
            Console.WriteLine("Enter the first integer");
            float a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the second integer");
            float b = Convert.ToInt16(Console.ReadLine());

            Console.Write("1-Addition.\n2-Substraction.\n3-Multiplication.\n4-Division.\n5-Exit.\n");
            Console.WriteLine("input your choose");
            float choose = Convert.ToInt16(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    Console.WriteLine(a + b);
                    break;
                case 2:
                    Console.WriteLine(a - b);
                    break;
                case 3:
                    Console.WriteLine(a * b);
                    break;
                case 4:
                    Console.WriteLine(a / b);
                    break;
                default:
                    Console.WriteLine("Duzgun Secim edin");
                    break;
            }

            //Funksion variable = new Funksion();

            //Console.Write("Input a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Input the desired width: ");
            //int width = Convert.ToInt32(Console.ReadLine());

            //int height = width;
            //for (int row = 0; row < height; row++)
            //{
            //    for (int column = 0; column < width; column++)
            //    {
            //        Console.Write(num);
            //    }

            //    Console.WriteLine();
            //    width--;



        }

        }
}
