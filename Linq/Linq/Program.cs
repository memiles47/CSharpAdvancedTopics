namespace Linq
{
    class Program
    {
        static void Main()
        {
            var books = new BookRepository().GetBooks();

            var cheabBooks = Book => Book.Price < 10;
        }
    }
}
