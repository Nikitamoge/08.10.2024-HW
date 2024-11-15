using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 121, 75, 81 };

        var sortedAscending = numbers.OrderBy(n => n.ToString().Sum(c => c - '0')).ToList();
        Console.WriteLine("Sorted in ascending order by the sum of digits: " + string.Join(", ", sortedAscending));

        var sortedDescending = numbers.OrderByDescending(n => n.ToString().Sum(c => c - '0')).ToList();
        Console.WriteLine("Sorted in descending order by the sum of digits: " + string.Join(", ", sortedDescending));
    }
}

