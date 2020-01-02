using System;
using Data;
using CryptoHelper;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //FAKTORIYAL
            //int a = Convert.ToInt16(Console.ReadLine());
            //int fakt = 1;
            //for (int i = 1; i <= a; i++)
            //{
            //    fakt *= i;
            //}
            //Console.WriteLine(fakt);

            //Fibornasiya ardiciligi
            //int a = Convert.ToInt16(Console.ReadLine());
            //int n1 = 0;
            //int n2 = 1;
            //int n3;
            //Console.WriteLine("\n"+  n1);
            //Console.WriteLine("\n"+   n2);
            //for (int i = 0; i < a; i++)
            //{
            //    n3 = n1 + n2;
            //    n1 = n2;
            //    n2 = n3;
            //    Console.WriteLine("\n" +n3);
            //}      

            //Salary engineer = new Salary();
            //engineer.Calc(30, 40);

            //Console.WriteLine(engineer.Amount);
            //Console.WriteLine(engineer.Taxes());
            //string userid = "";
            //string password = "";
            //int i = 1;
            //do
            //{
            //    Console.WriteLine("Please enter your userid");
            //    userid = Console.ReadLine();
            //    Console.WriteLine("Please enter your password");
            //    password = Console.ReadLine();
            //    i++;
            //}
            //while (i <= 3 && (userid == "" || password == ""));

            //if (userid != "" && password != "")
            //{
            //    Console.WriteLine("You entered correctly!");
            //}
            //else
            //    Console.WriteLine("Sorry, you have more than 3 attempts");
            //Noun student = new Noun("");
            //student.Name = "Ugur";
            //student.Surname = "Memmedov";
            //Console.WriteLine(student.Fullname());
            //Console.WriteLine("\n");
            //student.Display();
            //int result = student.Topla(4,d:3);

            ////Console.WriteLine(result);

            //Console.WriteLine(student.Calc(1996));
            //User user = new User(23);
            //user.Name = "Sultan";

            //Group group = new Group();
            //group.user = user;
            //Console.WriteLine(user.Age);

            Console.WriteLine(Crypto.HashPassword("123123123123"));
        }
    }
}
