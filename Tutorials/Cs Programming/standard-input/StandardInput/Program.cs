using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardInput {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Standard Input");

            Console.Write("\nEnter your name: ");
            var name = Console.ReadLine();
            if (name != "" || name.Length == 0) {
                name = "Unknown";
            }
            Console.Write("Enter your age: ");
            int age = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("\n\tName: " + name);
            Console.WriteLine("\tAge: " + age);

            Console.ReadLine();
        }
    }
}