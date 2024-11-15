using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string Name { get; set; }
    public string Position { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public decimal Salary { get; set; }
}

class Firm
{
    public string Name { get; set; }
    public DateTime FoundationDate { get; set; }
    public string BusinessProfile { get; set; }
    public string DirectorName { get; set; }
    public int EmployeeCount { get; set; }
    public string Address { get; set; }
    public List<Employee> Employees { get; set; }
}

class Program
{
    static void Main()
    {
        var firms = new List<Firm>
        {
            new Firm
            {
                Name = "FoodCorp",
                FoundationDate = DateTime.Now.AddYears(-3),
                BusinessProfile = "Food",
                DirectorName = "John White",
                EmployeeCount = 200,
                Address = "London",
                Employees = new List<Employee>
                {
                    new Employee { Name = "Lionel Messi", Position = "Manager", PhoneNumber = "2345678901", Email = "lionel@foodcorp.com", Salary = 5000 },
                    new Employee { Name = "Diana Prince", Position = "Developer", PhoneNumber = "2356789012", Email = "diana@foodcorp.com", Salary = 4000 },
                    new Employee { Name = "Clark Kent", Position = "Manager", PhoneNumber = "2367890123", Email = "clark@foodcorp.com", Salary = 6000 }
                }
            },
            new Firm
            {
                Name = "TechMark",
                FoundationDate = DateTime.Now.AddYears(-5),
                BusinessProfile = "Marketing",
                DirectorName = "Alice Black",
                EmployeeCount = 150,
                Address = "New York",
                Employees = new List<Employee>
                {
                    new Employee { Name = "Bruce Wayne", Position = "Manager", PhoneNumber = "2378901234", Email = "bruce@techmark.com", Salary = 7000 },
                    new Employee { Name = "Barry Allen", Position = "Developer", PhoneNumber = "2389012345", Email = "barry@techmark.com", Salary = 4500 },
                    new Employee { Name = "Hal Jordan", Position = "Manager", PhoneNumber = "2390123456", Email = "hal@techmark.com", Salary = 5500 }
                }
            }
        };

        var firmName = "FoodCorp";
        var employeesOfFirm = firms.FirstOrDefault(f => f.Name == firmName)?.Employees;
        Console.WriteLine($"Employees of {firmName}: " + string.Join(", ", employeesOfFirm.Select(e => e.Name)));

        decimal salaryThreshold = 4500;
        var highSalaryEmployees = firms.SelectMany(f => f.Employees).Where(e => e.Salary > salaryThreshold).ToList();
        Console.WriteLine($"Employees with salary greater than {salaryThreshold}: " + string.Join(", ", highSalaryEmployees.Select(e => e.Name)));

        var managers = firms.SelectMany(f => f.Employees).Where(e => e.Position == "Manager").ToList();
        Console.WriteLine("Employees with position 'Manager': " + string.Join(", ", managers.Select(e => e.Name)));

        var employeesWithPhoneStart23 = firms.SelectMany(f => f.Employees).Where(e => e.PhoneNumber.StartsWith("23")).ToList();
        Console.WriteLine("Employees with phone starting with '23': " + string.Join(", ", employeesWithPhoneStart23.Select(e => e.Name)));

        var employeesWithEmailStartDi = firms.SelectMany(f => f.Employees).Where(e => e.Email.StartsWith("di")).ToList();
        Console.WriteLine("Employees with Email starting with 'di': " + string.Join(", ", employeesWithEmailStartDi.Select(e => e.Name)));

        var employeesNamedLionel = firms.SelectMany(f => f.Employees).Where(e => e.Name.Contains("Lionel")).ToList();
        Console.WriteLine("Employees named Lionel: " + string.Join(", ", employeesNamedLionel.Select(e => e.Name)));
    }
}

