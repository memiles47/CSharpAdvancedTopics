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

            //This will not work but I will find a solution with nullcoalecing (I did)
            //Console.WriteLine($"Value: {date.Value}");
            //Console.WriteLine($"Value: {date.GetValueOrDefault()}");
            Console.WriteLine($"Value: {(date == null ? "Null": DateTime.Now.ToString())}");
            Console.WriteLine();

            DateTime? date1 = null;

            //will not work. You can't put a nullable into a non nullable practice.
            //DateTime date2 = date1;
            DateTime date2 = date1.GetValueOrDefault();
            Console.WriteLine($"Value: {date2.DayOfWeek}");

        }
    }
}