using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main()
        {
            //args => expression

            //() => ...         (No arguments)
            //x => ...          (One argument)
            //(x, y, z) => ...  (More than one argument)

            Func<int, int> square = number => number*number;
            Console.WriteLine($"{square(5)}");

            const int factor = 5;
            Func<int, int> multiplier = n => n*factor;
            Console.WriteLine($"{multiplier(10)}");

            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        //static bool IsCheaperThan10Dollars(Book book)
        //{
        //    return book.Price < 10;
        //}

        //Normal method
/*      same as the lambda expression above
        static int Square(int number)
        {
            return number*number;
        }
*/
    }
}
