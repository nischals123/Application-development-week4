using System;

namespace Task5
{
    enum DayType
    {
        Weekday,
        Weekend
    }

    record Book(string title, string author, double price);

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a day (e.g. Sunday): ");
            string? input = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("No input provided.");
            }
            else
            {
                string dayLower = input.ToLowerInvariant();
                DayType type = (dayLower == "friday" || dayLower == "saturday") ? DayType.Weekend : DayType.Weekday;
                Console.WriteLine($"It is: {type}");
            }

            // Create first book object
            Book book1 = new Book("The web developer", "Nischal", 39.99);

            // Create second book using 'with' expression, changing title and price
            Book book2 = book1 with { title = "Clean Code", price = 29.99 };

            Console.WriteLine();
            Console.WriteLine("First book:");
            Console.WriteLine(book1);

            // Deconstruct second book and print values
            var (title, author, price) = book2;
            Console.WriteLine();
            Console.WriteLine("Second book (deconstructed):");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {price}");
        }
    }
}