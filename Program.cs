using System;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student(1, "John Doe", "johndoe@dsu.edu", "Computer Science",
                    new DateTime(2022, 9, 1), new DateTime(2026, 6, 1), "California",
                    "USA", "1234567890", "123 Main St, Los Angeles, CA", false),
            new Student(2, "Jane Smith", "janesmith@dsu.edu", "Mathematics",
                    new DateTime(2021, 9, 1), new DateTime(2025, 6, 1), "Texas",
                    "USA", "9876543210", "456 Elm St, Austin, TX", true),
            new Student(3, "Mike Brown", "mikebrown@dsu.edu"),
            new Student(4, "Emily White", "emilywhite@dsu.edu"),
            new Student(5, "Chris Green", "chrisgreen@dsu.edu"),
            new Student(6, "Sara Blue", "sarablue@dsu.edu"),
            new Student(7, "Tom Black", "tomblack@dsu.edu"),
            new Student(8, "Nancy Yellow", "nancyyellow@dsu.edu"),
            new Student(9, "Mark Red", "markred@dsu.edu"),
            new Student(10, "Anna Violet", "annaviolet@dsu.edu")
        };

        students[4].Country = "England";

        foreach (var student in students)
        {
            Console.WriteLine("\nStudent Info:");
            Console.WriteLine($"ID: {student.ID}");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Major: {student.Major}");
            Console.WriteLine($"Email: {student.Email}");
            Console.WriteLine($"Start Date: {student.StartDate}");
            Console.WriteLine($"Anticipated Graduation Date: {student.AnticipatedGraduationDate}");
            Console.WriteLine($"State: {student.State}");
            Console.WriteLine($"Country: {student.Country}");
            Console.WriteLine($"Phone: {student.Phone}");
            Console.WriteLine($"Mailing Address: {student.MailingAddress}");
        }

        Console.WriteLine("\nActivity Log:");
        foreach (var log in Student.Log) {
            Console.WriteLine(log);
        }
    }
}
