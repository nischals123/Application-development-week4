using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var demo = new ParameterDemo();

            int value = 5;
            Console.WriteLine($"Initial value: {value}");
            demo.Increase(ref value);
            Console.WriteLine($"After Increase(ref): {value}");

            demo.GetFullName(out string fullName);
            Console.WriteLine($"Full name (out): {fullName}");

            int sum = demo.SumAll(1, 2, 3, 4, 5);
            Console.WriteLine($"SumAll(params): {sum}");
        }
    }
}