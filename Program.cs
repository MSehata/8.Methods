using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sayHi();
            Console.WriteLine();

            users();
            Console.WriteLine();

            sayHiUser("Moloko");
            Console.WriteLine();

            sayHiAge("Mosibudi", 23);
            Console.WriteLine();

            users();
            

            Console.ReadKey();

        }

        static void sayHi()
        {
            Console.WriteLine("Entering say Hi ...");
            Console.WriteLine("--------------");
            Console.WriteLine("Hi");
            Console.WriteLine("Exiting say Hi ...");
        }

        static void sayHiUser(string name)
        {
            Console.WriteLine("Entering say Hi User ...");
            Console.WriteLine("--------------");
            Console.WriteLine("Hi, " + name);
            Console.WriteLine("Exiting say Hi User ...");
        }

        static void sayHiAge(string name,  int age)
        {
            Console.WriteLine("Entering say Hi Age ...");
            Console.WriteLine("--------------");
            Console.WriteLine("Hi " + name + " " + ", You have " + age + " years" );
            Console.WriteLine("Exiting say Hi Age ...");
        }

        static void users()
        {
            Console.WriteLine("Entering users ...");
            Console.WriteLine("--------------");
            Console.Write("Hey, what is your name? ");
            string name = Console.ReadLine();

            Console.Write("Hi " + name + ", when were you born? ");
            int yearOfBirth = int.Parse(Console.ReadLine());

            int age = 2023 - yearOfBirth;

            Console.WriteLine();
            Console.WriteLine(name + " is " + age + " years old.");
            Console.WriteLine("Exiting users ...");

        }
    }
}
