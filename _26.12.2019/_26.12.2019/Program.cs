using Data;
using System;
using System.Numerics;

namespace _26._12._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Lead lead = new Lead
            {
                Name = "Elcin",
                Surname = "Xelilov",
                Age = 23,
                ApplyAt = new DateTime(2019,3,4)
            };
            User man = new User();
            man.Count = 23;
            
            Blank blank = new Blank();
            blank.user = man;
            //Console.WriteLine(blank.user.Count);

            Order order = new Order();
            order.Status = OrderStatus.Pending;
            switch (order.Status)
            {
                    case OrderStatus.Accepted:
                    Console.WriteLine((int)OrderStatus.Accepted);
                    break;
                    case OrderStatus.Pending:
                    Console.WriteLine((int)OrderStatus.Pending);
                    break;
                    
            }
        }
    }
}
