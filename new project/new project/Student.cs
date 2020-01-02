using System;
using System.Collections.Generic;
using System.Text;

namespace new_project
{
    enum order
    {
        bakalavr,
        magistr,
        doktorantura
    }
    class Student
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public static int Count { get; set; }
        public void AddCount()
        {
            Count++;
        }
        public int GetCount()
        {
            return Count;
        }
        public order order { get; set; }
        public string Namer(Student student)
        {
            return Name;
        }
       
    }
    class Person
    {
        public string WorkStatus { get; set; }
        public Student student { get; set; }

    }
}
