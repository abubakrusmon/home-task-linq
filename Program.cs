List<Student> students = new List<Student>
{
    new Student { Id = 1, FirstName = "Ali",    LastName = "Aliev",   Age = 22, Gender1 = Gender.Male,   Status1 = Status.Active,   DateOfBirth = new DateTime(2003, 5, 10),  DateOfStart = new DateTime(2019, 9, 1), DateOfFinish = new DateTime(2024, 6, 1) },
    new Student { Id = 2, FirstName = "Sara",   LastName = "Saidova", Age = 19, Gender1 = Gender.Female, Status1 = Status.InActive, DateOfBirth = new DateTime(2006, 3, 2),   DateOfStart = new DateTime(2022, 9, 1), DateOfFinish = new DateTime(2025, 6, 1) },
    new Student { Id = 3, FirstName = "Ivan",   LastName = "Petrov",  Age = 25, Gender1 = Gender.Male,   Status1 = Status.Active,   DateOfBirth = new DateTime(1999, 8, 20),  DateOfStart = new DateTime(2017, 9, 1), DateOfFinish = new DateTime(2026, 6, 1) },
    new Student { Id = 4, FirstName = "Madina", LastName = "Mirova",  Age = 15, Gender1 = Gender.Female, Status1 = Status.Active,   DateOfBirth = new DateTime(2010, 1, 15),  DateOfStart = new DateTime(2023, 9, 1), DateOfFinish = new DateTime(2027, 6, 1) },
    new Student { Id = 5, FirstName = "Anvar",  LastName = "Karimov", Age = 15, Gender1 = Gender.Male,   Status1 = Status.Active,   DateOfBirth = new DateTime(2010, 11, 5),  DateOfStart = new DateTime(2024, 1, 1), DateOfFinish = new DateTime(2028, 6, 1) },
    new Student { Id = 6, FirstName = "John",   LastName = "Smith",   Age = 28, Gender1 = Gender.Male,   Status1 = Status.InActive, DateOfBirth = new DateTime(1997, 4, 9),   DateOfStart = new DateTime(2015, 9, 1), DateOfFinish = new DateTime(2019, 6, 1) },
};

// Task 1
var task1 = students.Where(s => s.Gender1 == Gender.Male);
foreach(var a in task1)
{
    System.Console.WriteLine($"{a.FirstName} {a.Age}");
}

// Task 2
var task2 = students.Where(s => s.Status1 == Status.InActive);
foreach(var a in task2)
{
    System.Console.WriteLine($"{a.FirstName} {a.Age}");
}

// Task 3
var task3 = students.Where(s => s.DateOfBirth.Year > 2000);
foreach(var a in task3)
{
    System.Console.WriteLine($"{a.FirstName} {a.Age}");
}

// Task 4
var task4 = students.Where(s => s.Age > 20 && s.Status1 == Status.Active);
foreach(var a in task4)
{
    System.Console.WriteLine($"{a.FirstName} {a.Age}");
}

// Task 5
var task5 = students.Where(s => s.DateOfStart.Year - s.DateOfBirth.Year == 16);
foreach(var a in task5)
{
    System.Console.WriteLine($"{a.FirstName} {a.Age}");
}

// Task 6
var task6 = students.Where(s => s.DateOfStart.Year - s.DateOfBirth.Year >= 18)
.Select(s => new{s.Id , s.FirstName , s.LastName , s.DateOfBirth , s.DateOfStart});
foreach(var a in task6)
{
    System.Console.WriteLine(a);
}

// Task 7
var task7 = students.Where(s => s.FirstName.StartsWith("A") || s.FirstName.StartsWith("I"))
.Select(s => new{s.Id , s.FirstName , s.LastName});
foreach(var a in task7)
{
    System.Console.WriteLine(a);
}

// Task 8
var task8 = students.Where(s => s.FirstName[0] == s.LastName[0])
.Select(s => new{s.Id , s.FirstName , s.LastName});
foreach(var a in task8)
{
    System.Console.WriteLine(a);
}

// Task 9
var task9 = students.Where(s => s.DateOfBirth.AddYears(18) >= s.DateOfStart 
&& s.DateOfBirth.AddYears(18) <= s.DateOfFinish);
foreach(var a in task9)
{
    System.Console.WriteLine($"{a.FirstName} {a.Age}");
}

// Task 10
var task10 = students.Where(s => s.Gender1 != Gender.Female
&& s.Status1 == Status.Active 
&& s.DateOfFinish.Year - s.DateOfStart.Year > 2
&& s.Age < 16);
foreach(var a in task10)
{
    System.Console.WriteLine($"{a.FirstName} {a.Age}");
}
