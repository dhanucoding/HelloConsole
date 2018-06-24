using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Hello World!");
            const string Value = "Enter your name - ";
            Console.Write(Value);
             str = Console.ReadLine();
            Console.WriteLine("Hello " + str + " Welcome to first Git Program");
            Console.ReadKey();
        }
    }
}
