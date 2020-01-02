using System;

namespace new_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Elcin";
            student.order = order.doktorantura;

            Person person = new Person
            {
                student = student
            };
            Console.WriteLine(person.student.Name);

        }
    }
}
