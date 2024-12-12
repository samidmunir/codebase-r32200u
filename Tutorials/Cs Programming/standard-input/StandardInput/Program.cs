﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardInput {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Standard Input");

            Console.Write("\nEnter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("\n\tName: " + name);
            Console.WriteLine("\tAge: " + age);

            Console.ReadLine();
        }
    }
}