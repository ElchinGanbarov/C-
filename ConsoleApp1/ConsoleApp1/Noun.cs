using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Noun
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fullname()
        {
            return Name + " "+ Surname;
        }
        public void Display()
        {
            Console.WriteLine(Name + " " + Surname);
        }
        public int Topla(int a, int b=2,int c=3,int d=12)
        {
            return a + b + c + d;
        }
        public string Cash { get; set; }
        public int Calc(int year)
        {
            return 2019 - year;
        }
        public int Calc(string year) {
            return 2019 - Convert.ToInt32(year);
        }
        public string Path { get; set; }

        public Noun(string path)
        {
           
        }
    }
}
