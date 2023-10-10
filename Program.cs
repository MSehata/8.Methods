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

            sayHiUser("Moloko");

            sayHiAge("Mosibudi", 23);

            Console.ReadKey();

        }

        static void sayHi()
        {
            Console.WriteLine("Hi");
        }

        static void sayHiUser(string name)
        {
            Console.WriteLine("Hi, " + name);
        }

        static void sayHiAge(string name,  int age)
        {
            Console.WriteLine("Hi " + name + " " + ", You have " + age + " years" );
        }
    }
}
