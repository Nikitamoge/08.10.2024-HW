using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var cities = new List<string> { "Amsterdam", "Berlin", "New York", "Odesa", "Munich", "Hamburg", "Deventer", "Rotterdam" };

        Console.WriteLine("All cities: " + string.Join(", ", cities));

        int length = 6;
        var citiesByLength = cities.Where(city => city.Length == length).ToList();
        Console.WriteLine($"Cities with name length {length}: " + string.Join(", ", citiesByLength));

        var citiesStartingWithA = cities.Where(city => city.StartsWith("A")).ToList();
        Console.WriteLine("Cities that start with 'A': " + string.Join(", ", citiesStartingWithA));

        var citiesEndingWithM = cities.Where(city => city.EndsWith("m")).ToList();
        Console.WriteLine("Cities that end with 'M': " + string.Join(", ", citiesEndingWithM));

        var citiesStartingWithNEndingWithK = cities.Where(city => city.StartsWith("N") && city.EndsWith("k")).ToList();
        Console.WriteLine("Cities that start with 'N' and end with 'K': " + string.Join(", ", citiesStartingWithNEndingWithK));
    }
}
