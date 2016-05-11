using System;

namespace NullableTypes
{
    class Program
    {
        static void Main()
        {
            DateTime? date = null;

            Console.WriteLine($"GetValueOrDefault(): {date.GetValueOrDefault()}");
            Console.WriteLine($"HasValue: {date.HasValue}");

            //This will not work but I will find a solution with nullcoalecing
            //Console.WriteLine($"Value: {date.Value}");
            Console.WriteLine($"Value: {date.GetValueOrDefault()}");
        }
    }
}