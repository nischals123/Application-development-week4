using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the marks: ");
        string marksValue = Console.ReadLine();

        Console.Write("Enter the total marks: ");
        string totalValue = Console.ReadLine();

        //? By using try parse
        int marks, total;

        if (!int.TryParse(marksValue, out marks))
        {
            Console.WriteLine("Invalid input for marks.");
            return;
        }
        if (!int.TryParse(totalValue, out total))
        {
            Console.WriteLine("Your input value is invalid for total marks.");
            return;
        }

        double percentage = marks / total * 100;

        Console.WriteLine($"The percentage: {percentage}%");
    }
}