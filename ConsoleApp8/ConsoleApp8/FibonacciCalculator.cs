using System;
using System.Collections.Generic;
public void AnalyzeRange(int start, int end)
{
    List<int> numbers = new List<int>();
    List<long> maxValues = new List<long>();
    List<int> iterationCounts = new List<int>();

    for (int i = start; i <= end; i++)
    {
        var sequence = GenerateSequence(i);
        long max = 0;
        foreach (var num in sequence)
            if (num > max) max = num;

        numbers.Add(i);
        maxValues.Add(max);
        iterationCounts.Add(sequence.Count);
    }

    Console.WriteLine("\nResults for range:");
    Console.WriteLine("Number\tMax Value\t\tIteration Count");
    for (int i = 0; i < numbers.Count; i++)
    {
        Console.WriteLine($"{numbers[i]}\t{maxValues[i]}\t\t{iterationCounts[i]}");
    }
}