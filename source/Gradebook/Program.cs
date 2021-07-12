using System;
using System.Collections.Generic;

namespace Gradebook.Show
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Jacob's Grade Book");
            Console.WriteLine(book.name);
            book.GenerateRandomGrades();
            book.ShowStatistics();
            book.ListItems();
            Console.ReadLine();
        }
    }
}