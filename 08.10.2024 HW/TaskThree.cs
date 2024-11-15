using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string University { get; set; }
}

class Program
{
    static void Main()
    {
        var students = new List<Student>
        {
            new Student { FirstName = "Ryan", LastName = "Gosling", Age = 19, University = "Oxford" },
            new Student { FirstName = "Mike", LastName = "Ehrmantraut", Age = 21, University = "Harvard" },
            new Student { FirstName = "Kolya", LastName = "Brosky", Age = 22, University = "Oxford" },
            new Student { FirstName = "Walter", LastName = "White", Age = 20, University = "Oxford" }
        };

        Console.WriteLine("All students: ");
        foreach (var student in students)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}, University: {student.University}");
        }

        var studentsWithLastNameBro = students.Where(s => s.LastName.StartsWith("Bro")).ToList();
        Console.WriteLine("Students with a last name starting with 'Bro': ");
        studentsWithLastNameBro.ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName}"));

        var studentsOlderThan19 = students.Where(s => s.Age > 19).ToList();
        Console.WriteLine("Students older than 19: ");
        studentsOlderThan19.ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName}"));

        var students20To23 = students.Where(s => s.Age > 20 && s.Age < 23).ToList();
        Console.WriteLine("Students older than 20 and younger than 23: ");
        students20To23.ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName}"));

        var oxfordStudents = students.Where(s => s.University == "Oxford" && s.Age > 18).OrderByDescending(s => s.Age).ToList();
        Console.WriteLine("Students from Oxford, older than 18 (sorted by age in descending order): ");
        oxfordStudents.ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName}, Age: {s.Age}"));
    }
}
