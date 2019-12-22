using System;

namespace _17122019
{
    class Program
    {
     
        static void Main(string[] args)
        
        {
            FileManager fm = new FileManager("c:/text");

           
            Car mycar = new Car(70,12);
            mycar.AdFuel(40);
            mycar.Drive(100);
            
            Console.WriteLine(mycar.CurrentFuel);
            Console.WriteLine(mycar.LocalKm);
            Console.WriteLine(mycar.GlobalKm);

            Console.WriteLine("==============================");

            mycar.LocalResent();
            mycar.Drive(150);
            mycar.AdFuel(40);

            fm.Write("everything");

            Console.WriteLine(mycar.CurrentFuel);
            Console.WriteLine(mycar.LocalKm);
            Console.WriteLine(mycar.GlobalKm);


        }
        
       

    }
}
