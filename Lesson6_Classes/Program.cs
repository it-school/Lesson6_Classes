using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.Fio = "Vasya";
            student.Height = 1.80f;
            student.Age = 20;

            student.GetInfo();
            Console.WriteLine(student.ToString());
            Console.WriteLine(student);


            Student student1 = new Student("Anna", 160, 1.9f);
            Console.WriteLine(student1);

        }
    }
}
