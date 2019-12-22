using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ho
{
    class Program
    {
        static void Main(string[] args)
        {
            Mehsul mehsul = new Mehsul(200,20);
            Console.WriteLine(mehsul.PistolStockCount);
            Console.WriteLine(mehsul.Price);
            Console.WriteLine("===================================");
            mehsul.Sale(32);
            Console.WriteLine(mehsul.Salingcount);
            Console.WriteLine(mehsul.PistolStockCount);
            Console.WriteLine(mehsul.Price);
            Console.WriteLine("===================================");
            mehsul.Return(32);
 
            Console.WriteLine(mehsul.PistolStockCount);
            Console.WriteLine(mehsul.Price);

            Console.WriteLine("===================================");

            mehsul.AddStock(300);
            mehsul.Sale(100);
            mehsul.GetDiscount(14);
            Console.WriteLine(mehsul.GetStockCount());
            Console.WriteLine(mehsul.Price+"% endirim");
        }
    }
}
