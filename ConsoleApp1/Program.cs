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

            Console.WriteLine("   /\\      /\\    ");
            Console.WriteLine("  /  \\    /  \\   ");
            Console.WriteLine(" /    \\  /    \\  ");
            Console.WriteLine("/______\\/______\\ ");

            //string characterName = "John";
            //int characterAge = 35;

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
            //string[] friends = new string[3];
            //friends[0] = "Mircea";
            //friends[1] = "Gabi";
            //friends[2] = "Sergiu";

            //Console.WriteLine("[{0}]", string.Join(", ", friends));
            //Console.ReadLine();


            // Methods
            //SayHi("Demetrius", 40);
            //SayHi("Madalina", 33);
            //Console.ReadLine();
            //int cubedNumber = cube(4); 
            //Console.WriteLine(cubedNumber);
            //Console.ReadLine();

            // If statements
            //bool isBald = true;
            //bool isTall = false;
            //if (isBald && isTall)
            //{
            //    Console.WriteLine("You are bald and tall");
            //} 

            //else if (isBald || isTall)
            //{
            //    Console.WriteLine("You are either bald or tall");
            //} 

            //else if (isBald && !isTall)
            //{
            //    Console.WriteLine("You are a bald shorty");
            //}             
            //else if (!isBald && isTall)
            //{
            //    Console.WriteLine("You are not bald and tall");
            //} 
            //else
            //{
            //    Console.WriteLine("You ar not bald and not tall");
            //}

            //int max = GetMax(50, 20, 10);
            //Console.WriteLine(max);
            //Console.ReadLine();

            // Switch statements
            //Console.WriteLine(GetDay(0));
            //Console.ReadLine();

            // Do While loops
            //int index = 1;
            //do
            //{
            //    Console.WriteLine(index); 
            //    index++;
            //} while (index <= 5);
            //Console.ReadLine();

            // 2D Arrays
            //int[,] numberGrid =
            //{
            //    { 1, 2 },
            //    { 3, 4 },
            //    { 5, 6 },
            //};
            //Console.WriteLine(numberGrid[1, 1]);
            //Console.ReadLine();

            // Exception handling

            // Classes and objects
            //Book book1 = new Book("Mike");
            //book1.title = "Harry Potter";
            //book1.author = "JK Rolling";
            //book1.pages = 400;

            //Book book2 = new Book("");
            //book2.title = "Hyperion";
            //book2.author = "Dan Simmons";
            //book2.pages = 1900;

            //Book book1 = new Book("Harry Potter", "JK Rolling", 400);
            //Book book2 = new Book("Hyperion", "Dan Simmons", 1900);

            //Console.WriteLine(book1.title);
            //Console.WriteLine(book2.title);

            //Console.ReadLine();

            // Object methods
            //Student student1 = new Student("Jim", "Business", 2.8);
            //Student student2 = new Student("Pam", "Art", 3.6);

            //Console.WriteLine(student1.HasHonors());
            //Console.WriteLine(student2.HasHonors());

            // Getters & Setters
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "test");
            Movie shreck = new Movie("Shreck", "Adam Adamson", "PG");
            Console.WriteLine(avengers.Rating);

            Console.ReadLine();
        }

        //static void SayHi(string name, int age) 
        //{ 
        //    Console.WriteLine("Hello " + name + ", you are " + age + " years old");  
        //}        
        //static int cube( int num) 
        //{
        //    int result = num * num * num;
        //    return result;
        //}

        //static int GetMax(int num1, int num2, int num3) 
        //{
        //    int result;
        //    if(num1 >= num2 && num1 >= num3) 
        //    {
        //        result = num1;
        //    } else if(num2 >= num1 && num2 >= num3)
        //    {
        //        result = num2;
        //    } else
        //    {
        //        result = num3;
        //    }
        //    return result;
        //}

        //static string GetDay(int dayNum)
        //{
        //    string dayName;

        //    switch (dayNum) 
        //    { 
        //    case 0:
        //        dayName = "Monday";
        //        break;
        //    case 1:
        //        dayName = "Tuesday";
        //        break;
        //    case 2:
        //        dayName = "Wednesday";
        //        break;
        //    case 3:
        //        dayName = "Thursday";
        //        break;
        //    case 4:
        //        dayName = "Friday";
        //        break;
        //    case 5:
        //        dayName = "Saturday";
        //        break;
        //    case 6:
        //        dayName = "Sunday";
        //        break;
        //    default:
        //        dayName = "Invalid Day Number";
        //        break;
        //    }
        //    return "Today is " + dayName;
        //}
    }
}
