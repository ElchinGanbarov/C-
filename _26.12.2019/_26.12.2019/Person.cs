using System;
using System.Collections.Generic;
using System.Text;

namespace _26._12._2019
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public virtual void FullName()
        {
            Console.WriteLine(Name + " " + Surname + " " + Age);
        }
    }
    class Lead:Person
    {
        public DateTime ApplyAt { get; set; }
        public override void FullName()
        {
            base.FullName();
            {
                Console.WriteLine(ApplyAt);
            }
        }

    }

}
