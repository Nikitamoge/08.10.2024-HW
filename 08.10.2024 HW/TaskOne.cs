using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 14, 16, 20, 28, 56 };

        Console.WriteLine("All numbers: " + string.Join(", ", numbers));

        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
        Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));

        var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();
        Console.WriteLine("Odd numbers: " + string.Join(", ", oddNumbers));

        var rangeNumbers = numbers.Where(n => n >= 5 && n <= 20).ToList();
        Console.WriteLine("Numbers in range 5-20: " + string.Join(", ", rangeNumbers));

        var multiplesOfSeven = numbers.Where(n => n % 7 == 0).OrderBy(n => n).ToList();
        Console.WriteLine("Multiples of 7: " + string.Join(", ", multiplesOfSeven));

        var multiplesOfEightDescending = numbers.Where(n => n % 8 == 0).OrderByDescending(n => n).ToList();
        Console.WriteLine("Multiples of 8 (descending order): " + string.Join(", ", multiplesOfEightDescending));
    }
}
