﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Console.WriteLine("   /\\     ");
            Console.WriteLine("  /  \\    ");
            Console.WriteLine(" /    \\   ");
            Console.WriteLine("/______\\  ");

            string characterName = "John";
            int characterAge = 35;

            //Console.WriteLine("There was once a man named " +  characterName);
            //Console.WriteLine("He was " + characterAge + " years old");
            //Console.WriteLine("He really liked the name " + characterName);
            //Console.WriteLine("But didn't like being " + characterAge);
            //Console.ReadLine();

            //string phrase = "I'm learning C#";
            //char grade = 'a';
            //int age = 30;
            //double gpa = 3.3;
            //bool isMale = true;

            //Console.WriteLine(phrase);
            //Console.WriteLine(phrase.ToUpper());
            //Console.WriteLine(phrase.Length);
            //Console.WriteLine(phrase.Contains("learn"));
            //Console.WriteLine(phrase[0]);
            //Console.WriteLine(phrase.IndexOf("C"));
            //Console.WriteLine(phrase.Substring(4));
            //Console.WriteLine(phrase.Substring(4, 4));
            //Console.ReadLine();

            // numbers
            //int num = 6;
            //num++;
            //Console.WriteLine( num );
            //num--;
            //Console.WriteLine( num );
            //Console.WriteLine( Math.Abs(-40) );
            //Console.WriteLine( Math.Pow(3, 2) );
            //Console.WriteLine( Math.Sqrt(225) );
            //Console.WriteLine( Math.Max(564, 225) );
            //Console.WriteLine( Math.Round(564.98) );
            //Console.ReadLine();

            // Get user input
            //Console.WriteLine("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter your age: ");
            //string age = Console.ReadLine();
            //Console.WriteLine("Hello " + name + ", you are " + age + " years old");
            //Console.ReadLine();

            // Convert string to numbers
            //string myString = "45";
            //int num = Convert.ToInt32(myString);
            //Console.WriteLine( num + 6);
            //Console.Write("Enter a number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter another number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num2 + num1);
            //Console.Write("Enter a number: ");
            //double num3 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter another number: ");
            //double num4 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(num3 + num4); 
            //Console.ReadLine();

            // Mad Libs
            //string color, pluralNoun, celebrity;

            //Console.Write("Enter a color: ");
            //color = Console.ReadLine();

            //Console.Write("Enter a plural noun: ");
            //pluralNoun = Console.ReadLine();

            //Console.Write("Enter a celebrity: ");
            //celebrity = Console.ReadLine();

            //Console.WriteLine("Roses are " + color);
            //Console.WriteLine(char.ToUpper(pluralNoun[0]) + pluralNoun.Substring(1) + " are blue");
            //Console.WriteLine("I love " + char.ToUpper(celebrity[0]));

            //Console.ReadLine();

            // Arrays
            //int[] luckyNumbers = { 3, 7, 11, 13, 24, 43 };
            //luckyNumbers[1] = 27;
            //Console.WriteLine( luckyNumbers[1] );
            //Console.ReadLine();

            string[] friends = new string[3];
            friends[0] = "Mircea";
            friends[1] = "Gabi";
            friends[2] = "Sergiu";

            Console.WriteLine("[{0}]", string.Join(", ", friends));

        }
    }
}
