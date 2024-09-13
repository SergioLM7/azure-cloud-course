// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;


//Exercise Lesson 5 Option B: more optimized and reusable one
//Class Course
class Course(string name, double grade, int credit)
{
    public string Name { get; set; } = name;
    public double Grade { get; set; } = grade;
    public int Credit { get; set; } = credit;
}

//Class Student
class Student
{
    public string Name { get; set; }
    public List<Course> Courses { get; set; }

    public Student(string name)
    {
        Name = name;
        Courses = new List<Course>();
    }

    public void AddCourse(Course course)
    {
        Courses.Add(course);
    }

    public double CalculateGPA()
    {
        double sumGradeByCredit = 0;
        int sumCredits = 0;

        foreach (var course in Courses)
        {
            sumGradeByCredit += course.Grade * course.Credit;
            sumCredits += course.Credit;
        }

        return sumCredits > 0 ? sumGradeByCredit / sumCredits : 0;
    }

    public void ShowInformation()
    {
        Console.WriteLine($"Student: {Name}\n\nCourse\t\t\tGrade\t\tCredit Hours");

        foreach (var course in Courses)
        {
            if (course.Name == "Computer Science I")
            {
                Console.WriteLine($"{course.Name}\t{course.Grade}\t\t{course.Credit}");
            }
            else
            {
                Console.WriteLine($"{course.Name}\t\t{course.Grade}\t\t{course.Credit}");
            }
        }

        Console.WriteLine($"\nFinal GPA: \t\t{Math.Round(CalculateGPA(), 2)}");
    }
}


//Class Calculator (runs the program)
class Calculator
{
    static void Main()
    {
        // Create a student
        Student student = new Student("Sophia Johnson");

        // Add courses to Alumn
        student.AddCourse(new Course("English 101", 4, 3));
        student.AddCourse(new Course("Algebra 101", 3, 3));
        student.AddCourse(new Course("Biology 101", 3, 4));
        student.AddCourse(new Course("Computer Science I", 3, 4));
        student.AddCourse(new Course("Psychology 101", 4, 3));

        // Show the information and the GPA
        student.ShowInformation();
    }
}