using System;
using System.Collections.Generic;
using System.Linq;

class Firm
{
    public string Name { get; set; }
    public DateTime FoundationDate { get; set; }
    public string BusinessProfile { get; set; }
    public string DirectorName { get; set; }
    public int EmployeeCount { get; set; }
    public string Address { get; set; }
}

class Program
{
    static void Main()
    {
        var firms = new List<Firm>
        {
            new Firm { Name = "FoodCorp", FoundationDate = DateTime.Now.AddYears(-3), BusinessProfile = "Food", DirectorName = "Walter White", EmployeeCount = 200, Address = "London" },
            new Firm { Name = "TechMark", FoundationDate = DateTime.Now.AddYears(-5), BusinessProfile = "Marketing", DirectorName = "Alice Black", EmployeeCount = 150, Address = "New York" },
            new Firm { Name = "IT Solutions", FoundationDate = DateTime.Now.AddYears(-1), BusinessProfile = "IT", DirectorName = "Mike Johnson", EmployeeCount = 120, Address = "San Francisco" }
        };

        Console.WriteLine("All firms:");
        firms.ForEach(f => Console.WriteLine($"{f.Name}, Founded: {f.FoundationDate.ToShortDateString()}, Profile: {f.BusinessProfile}, Director: {f.DirectorName}, Employees: {f.EmployeeCount}, Address: {f.Address}"));

        var foodFirms = firms.Where(f => f.Name.Contains("Food")).ToList();
        Console.WriteLine("Firms with 'Food' in the name: " + string.Join(", ", foodFirms.Select(f => f.Name)));

        var marketingFirms = firms.Where(f => f.BusinessProfile == "Marketing").ToList();
        Console.WriteLine("Firms in the Marketing industry: " + string.Join(", ", marketingFirms.Select(f => f.Name)));

        var marketingOrITFirms = firms.Where(f => f.BusinessProfile == "Marketing" || f.BusinessProfile == "IT").ToList();
        Console.WriteLine("Firms in the Marketing or IT industry: " + string.Join(", ", marketingOrITFirms.Select(f => f.Name)));

        var largeFirms = firms.Where(f => f.EmployeeCount > 100).ToList();
        Console.WriteLine("Firms with more than 100 employees: " + string.Join(", ", largeFirms.Select(f => f.Name)));

        var mediumFirms = firms.Where(f => f.EmployeeCount >= 100 && f.EmployeeCount <= 300).ToList();
        Console.WriteLine("Firms with 100 to 300 employees: " + string.Join(", ", mediumFirms.Select(f => f.Name)));

        var londonFirms = firms.Where(f => f.Address == "London").ToList();
        Console.WriteLine("Firms in London: " + string.Join(", ", londonFirms.Select(f => f.Name)));

        var whiteDirectorFirms = firms.Where(f => f.DirectorName.Contains("White")).ToList();
        Console.WriteLine("Firms with Director named White: " + string.Join(", ", whiteDirectorFirms.Select(f => f.Name)));

        var oldFirms = firms.Where(f => (DateTime.Now - f.FoundationDate).TotalDays > 365 * 2).ToList();
        Console.WriteLine("Firms founded more than 2 years ago: " + string.Join(", ", oldFirms.Select(f => f.Name)));

        var firms123DaysOld = firms.Where(f => (DateTime.Now - f.FoundationDate).TotalDays > 123).ToList();
        Console.WriteLine("Firms founded more than 123 days ago: " + string.Join(", ", firms123DaysOld.Select(f => f.Name)));

        var blackDirectorWhiteNameFirms = firms.Where(f => f.DirectorName.Contains("Black") && f.Name.Contains("White")).ToList();
        Console.WriteLine("Firms with Director named Black and 'White' in the name: " + string.Join(", ", blackDirectorWhiteNameFirms.Select(f => f.Name)));
    }
}

