using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._12._2019
{
    class Funksion
    {
        //public int Funk { get; set; }
        //public int Functriol()
        //{
        //    int x = 1;
        //    for(int i = 1; i <= Funk; i++)
        //    {
        //        x *= i;
        //    }
        //    return x;
        //}

        public void Fibonacci(int number)
        {

            int x = 0; int y = 1; int z;
            Console.WriteLine(x);
            Console.WriteLine(y);
            for (int i = 0; i < number; i++)
            {
                z = x + y;
                Console.WriteLine(z);
                x = y;
                y = z;
            }
        }
        public void get(float r)
        {
            Console.WriteLine("Cevrenin perimetri" + " " + 2 * 3.14 * r);


        }

        public int Month { get; set; }   // PROPERTY
        public void Search()
        {

            switch (Month)
            {
                case 1:
                    Console.WriteLine("Yanvar");
                    break;
                case 2:
                    Console.WriteLine("Februrary");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("JYUN");
                    break;
                case 7:
                    Console.WriteLine("JYUL");
                    break;
                case 8:
                    Console.WriteLine("AUQAST");
                    break;
                case 9:
                    Console.WriteLine("SEptember");
                    break;
                case 10:
                    Console.WriteLine("OKTOBER");
                    break;
                case 11:
                    Console.WriteLine("NOVEMBER");
                    break;
                case 12:
                    Console.WriteLine("DECEMBER");
                    break;
                default:
                    Console.WriteLine("Movcud Deil");
                    break;

            }

        }
        
        public void Full()
        {
            this.Month = 7;
        }

    }      
}
