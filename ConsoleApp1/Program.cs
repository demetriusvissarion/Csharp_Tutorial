using System;
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
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", you are " + age + " years old");

            Console.ReadLine();
        }
    }
}
