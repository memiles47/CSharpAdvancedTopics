using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main()
        {
            string post = "This is supposed to be a very long blog post blah blah blah ...";
            //var shortenedPost = post.Shorten(5);

            IEnumerable<int> numbers = new List<int> {1, 5, 3, 10, 2, 18};
            var max = numbers.Max();

            Console.WriteLine($"Shortened Post: \"{post.Shorten(5)}...\"");
            Console.WriteLine($"Maximum in numbers: {max}");
        }
    }
}
