using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPROG2
{
    class MainActivity
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            Student std2 = new Student();

            std.name = "John";
            std.age = 18;
            std.gender = "Male";

            std2.name = "Jon";
            std2.age = 81;
            std2.gender = "Male";

            Console.WriteLine("Student 1");
            Console.WriteLine("Name: " + std.name);
            Console.WriteLine("Age: " + std.age);
            Console.WriteLine("Gender: " + std.gender);
            Console.WriteLine("==================================");
            Console.WriteLine("Student 2");
            Console.WriteLine("Name: " + std2.name);
            Console.WriteLine("Age: " + std2.age);
            Console.WriteLine("Gender: " + std2.gender);
        }
    }
}