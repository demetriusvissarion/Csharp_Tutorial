using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book
    {
        public string title, author;
        public int pages;

        public Book() // this constructor allow to instantiate an object without any arguments
        {

        }

        public Book(string aTitle, string aAuthor, int thePages) // works in parrallel with the first constructor
        {
            Console.WriteLine("Creating Book " + aTitle);
            title = aTitle;
            author = aAuthor;
            pages = thePages;
        }

        // Note: there can be any number of constructors 
    }

}
