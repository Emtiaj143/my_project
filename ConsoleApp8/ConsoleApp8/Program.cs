using System;

class Program
{
    static void Main(string[] args)
    {
        FibonacciCalculator fib = new FibonacciCalculator();

        // --- Test single number ---
        Console.Write("Enter the number of Fibonacci terms to generate: ");
        int singleCount = int.Parse(Console.ReadLine());
        fib.AnalyzeSingleNumber(singleCount);

        // --- Test range ---
        Console.Write("\nEnter range START: ");
        int rangeStart = int.Parse(Console.ReadLine());

        Console.Write("Enter range END: ");
        int rangeEnd = int.Parse(Console.ReadLine());

        fib.AnalyzeRange(rangeStart, rangeEnd);

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}
