using System;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student(
                101,
                "Alice Johnson",
                "alicej@univ.edu",
                "Physics",
                new DateTime(2023, 8, 15),
                new DateTime(2027, 5, 20),
                "New York",
                "USA",
                "3216549870",
                "789 Pine St, New York, NY",
                true
            ),
            new Student(
                102,
                "Bob Williams",
                "bobw@univ.edu",
                "Engineering",
                new DateTime(2020, 9, 10),
                new DateTime(2024, 6, 15),
                "Florida",
                "USA",
                "4561237890",
                "321 Oak St, Miami, FL",
                false
            ),
            new Student(
                103,
                "Charlie Adams",
                "charliea@univ.edu",
                "Biology",
                new DateTime(2022, 9, 1),
                new DateTime(2026, 6, 1),
                "Illinois",
                "USA",
                "6549873210",
                "555 Birch St, Chicago, IL",
                true
            ),
            new Student(
                104,
                "Diana Carter",
                "dianac@univ.edu",
                "Economics",
                new DateTime(2021, 8, 20),
                new DateTime(2025, 5, 15),
                "Ohio",
                "USA",
                "7893216540",
                "777 Cedar St, Columbus, OH",
                false
            ),
            new Student(105, "Ethan Miller", "ethanm@univ.edu"),
            new Student(106, "Fiona Harris", "fionah@univ.edu"),
            new Student(107, "George Clark", "georgec@univ.edu"),
            new Student(108, "Hannah Lewis", "hannahl@univ.edu"),
            new Student(109, "Ian Roberts", "ianr@univ.edu"),
            new Student(110, "Julia Turner", "juliat@univ.edu"),
        };

        foreach (var student in students)
        {
            Console.WriteLine("\nStudent Info:");
            Console.WriteLine($"ID: {student.ID}");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Major: {student.Major}");
            Console.WriteLine($"Mailing Address: {student.MailingAddress}");
            Console.WriteLine($"Start Date: {student.StartDate}");
            Console.WriteLine($"Email: {student.Email}");
            Console.WriteLine($"Anticipated Graduation Date: {student.AnticipatedGraduationDate}");
            Console.WriteLine($"Country: {student.Country}");
            Console.WriteLine($"State: {student.State}");
            Console.WriteLine($"Phone: {student.Phone}");
        }

        Console.WriteLine("\nActivity Log:");
        foreach (var log in Student.Log)
        {
            Console.WriteLine(log);
        }
    }
}
