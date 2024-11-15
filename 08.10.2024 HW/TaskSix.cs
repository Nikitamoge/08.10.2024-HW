using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var array1 = new List<int> { 1, 2, 3, 4, 5 };
        var array2 = new List<int> { 4, 5, 6, 7, 8 };

        var difference = array1.Except(array2).ToList();
        Console.WriteLine("Difference of arrays: " + string.Join(", ", difference));

        var intersection = array1.Intersect(array2).ToList();
        Console.WriteLine("Intersection of arrays: " + string.Join(", ", intersection));

        var union = array1.Union(array2).ToList();
        Console.WriteLine("Union of arrays: " + string.Join(", ", union));

        var distinctArray1 = array1.Distinct().ToList();
        Console.WriteLine("First array without duplicates: " + string.Join(", ", distinctArray1));
    }
}

