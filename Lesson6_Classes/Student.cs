using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_Classes
{
    class Student
    {
        String fio;   // FIO
        byte age;     // ages
        float height; // meters

        public Student()
        {
            Fio = "Student";
            Age = 18;
            Height = 1.70f;
        }

        public Student(string fio, byte age, float height)
        {
            Fio = fio;
            Age = age;
            Height = height;
        }

        public string Fio { get => fio; set => fio = value; }
        public byte Age { get => age; set => age = (value > 160 ? (byte)0 : value); }
        public float Height { get => height; set => height = (value > 3f ? 0.47f : value); }

        public void GetInfo()
        {
            Console.WriteLine(Fio + ", height: " + Height + ", age: " + Age);
        }

        public override string ToString()
        {
            return Fio + ", height: " + Height + ", age: " + Age;
        }
    }
}
