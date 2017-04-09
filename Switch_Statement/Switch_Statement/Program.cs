﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Benjamin";
            const string niceName = "Andrea";
            const string sillyName = "Ploppy";
            string name;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            switch (name.ToLower())
            {
                case myName:
                    Console.WriteLine("You have the same name as me!");
                    break;
                case niceName:
                    Console.WriteLine("My, what a nice name you have!");
                    break;
                case sillyName:
                    Console.WriteLine("That's a very silly name.");
                    break;

            }

            Console.WriteLine($"Hello {name}!");

            Console.ReadKey();


        }
    }
}
