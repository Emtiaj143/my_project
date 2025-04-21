using System;
using System.Collections.Generic;
public class FibonacciCalculator
{
    // Method to calculate Fibonacci sequence up to a number of iterations
    public List<long> GenerateSequence(int count)
    {
        List<long> sequence = new List<long>();

        long a = 1, b = 2;
        sequence.Add(a);
        if (count > 1) sequence.Add(b);

        for (int i = 2; i < count; i++)
        {
            long next = a + b;

            // Stop if it exceeds long limit
            if (next < 0)
            {
                Console.WriteLine("Value exceeded limit of 'long'. Stopping early.");
                break;
            }

            sequence.Add(next);
            a = b;
            b = next;
        }

        return sequence;
    }
}

