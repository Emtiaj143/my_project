using System;
using System.Collections.Generic;
public void AnalyzeSingleNumber(int count)
{
    var sequence = GenerateSequence(count);

    long max = 0;
    foreach (var num in sequence)
    {
        if (num > max)
            max = num;
    }

    Console.WriteLine($"\nFibonacci sequence ({sequence.Count} terms):");
    foreach (var num in sequence)
        Console.Write(num + " ");

    Console.WriteLine($"\nMax value: {max}");
    Console.WriteLine($"Total iterations: {sequence.Count}");
}

