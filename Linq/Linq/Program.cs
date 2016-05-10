using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main()
        {
            var books = new BookRepository().GetBooks();

            #region Extention/Operator first examples
            //var cheapBooks = books.FindAll(book => book.Price < 10);
            //var cheapBooks = new List<Book>();

            //foreach (var book in books)
            //{
            //    if (book.Price < 10)
            //        cheapBooks.Add(book);
            //}

            //Linq query operators
            //var cheaperBooks =
            //    from b in books
            //    where b.Price < 10
            //    orderby b.Price
            //    select b.Title;

            ////Linq extension methods
            //var cheapBooks = books
            //    .Where(b => b.Price < 10)
            //    .OrderBy(b => b.Price)
            //    .Select(b => b.Title);

            //foreach (var book in cheapBooks)
            //{
            //    Console.WriteLine($"Title: {book}");
            //}

            //Console.WriteLine();
            //foreach (var book in cheaperBooks)
            //{
            //    Console.WriteLine($"Title: {book}");
            //}

            #endregion

            //LINQ Extension Methods
            //var book = books.Single(b => b.Title == "ASP.NET MVC");
            var book = books.SingleOrDefault(b => b.Title == "ASP.NET MVC");

            //var book1 = books.First(b => b.Title == "C# Advanced Topics");
            var book1 = books.FirstOrDefault(b => b.Title == "C# Advanced Topics");

            //var book2 = books.Last(b => b.Title == "C# Advanced Topics");
            var book2 = books.LastOrDefault(b => b.Title == "C# Advanced Topics");

            var book3 = books.Skip(2).Take(3);
            var book4 = books.Count;
            var book5 = books.Max(b => b.Price);
            var book6 = books.Min(b => b.Price);
            var book7 = books.Sum(b => b.Price);


            Console.WriteLine($"Title: {(book == null ? "null" : book.Title)}");
            Console.WriteLine($"Price: {(book1 == null ? "null" : book1.Price.ToString())}");
            Console.WriteLine($"Price: {(book2 == null ? "null" : book2.Price.ToString())}");
            Console.WriteLine($"Number of Books: {book4}");
            Console.WriteLine($"Max Price, Price = {book5:C}");
            Console.WriteLine($"Min Price, Price = {book6:C}");
            Console.WriteLine($"Sum of all books: {book7:C}");

            Console.WriteLine();
            foreach (var item in book3)
            {
                Console.WriteLine($"Title: {item.Title}, Price: {item.Price}");
            }
        }
    }
}
