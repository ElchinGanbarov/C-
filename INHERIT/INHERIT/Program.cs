using INHERIT.Codeacademy;
using System;

namespace INHERIT
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Lead lead = new Lead
            //    {
            //        Name = "Ilkin",
            //        Surname = "Bayramov",
            //        ApplyTime = new DateTime(2019, 11, 11),
            //        Channel="web-site"
            //    };
            //    Candidate candidate = new Candidate
            //    {
            //        Name = "Ilkin",
            //        Surname = "Bayramov",
            //        ApplyTime = new DateTime(2019, 11, 11),
            //        Channel = "web-site",
            //        Workingat ="Code Academy"
            //    };
            //    Console.WriteLine(candidate.FullName());

            //Candidate candidate = new Candidate("Code", "web-site", "0513141213");
            //Console.WriteLine(candidate.Workingat);
            //Console.WriteLine(candidate.Channel);
            //Console.WriteLine(candidate.Phone);

            Room mars = new Room
            {
                Name = "Mars",
                Capacity = 23,
            };
            Room jupiter = new Room
            {
                Name = "Jupiter",
                Capacity = 43,
            };
            Session evening = new Session
            {
                No = 3
            };
            Session Morning = new Session
            {
                No = 1
            };
            Group group = new Group
            {
                Session=evening,
                Room = jupiter,
                StartTime = new TimeSpan(05, 30, 2019),
                EndTime = new TimeSpan(01, 20, 2020)
            };
            Console.WriteLine(group.Session.No);
            
        }
    }
}
