using System;
using System.Collections.Generic;
using System.Linq;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        
        if (sliceLength <= 0)
            throw new ArgumentException("Slice length must be greater than 1", nameof(sliceLength));
        if (sliceLength > numbers.Length)
            throw new ArgumentException("Slice length must be equal or less than the amount of numbers", nameof(sliceLength));
        
        return Enumerable.Range(0, numbers.Length - sliceLength + 1)
            .Select(i => numbers.Substring(i, sliceLength))
            .ToArray();
    }
}