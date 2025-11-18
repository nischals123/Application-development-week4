using System;

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        calc.PrintWelcome();
        int sum = calc.Add(5, 7);
        Console.WriteLine("Addition: " + sum);
        int product2 = calc.Multiply(10);
        Console.WriteLine("Multiplication (10 * default 1): " + product2);
    }
}
