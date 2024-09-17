// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Net.Http.Headers;
using System.Text;

//Lesson 8 Arrays ForEach
//Exercise 2 - IMPROVED with additional scores (10%)
int examAssignments = 5;

int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
int[] andrewScores = [92, 89, 81, 96, 90, 89];
int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganScores = [90, 95, 87, 88, 96, 96];
string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan"];

int[] studentScores = new int[10];

Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit");

foreach (var student in studentNames)
{
    string currentStudent = student;
    if (student == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int sumScores = 0;
    decimal curentStudentAverage;

    int gradedAssignments = 0;
    decimal curentStudentExamsAverage = 0;

    foreach (int score in studentScores)
    {
        // increment the assignment counter
        gradedAssignments ++;

        if (gradedAssignments <= examAssignments) 
        {
            // add the exam score to the sum and calculate the average only for the exams
            sumScores += score;
            curentStudentExamsAverage = (decimal)sumScores / examAssignments;
        }
        else
            // add the extra credit points to the sum - bonus points equal to 10% of an exam score
            sumScores += score / 10;
    }

    curentStudentAverage = (decimal)sumScores / examAssignments;
    decimal extraCredit = curentStudentAverage - curentStudentExamsAverage;

    if (curentStudentAverage >= 97 && curentStudentAverage <= 100)
    {
        Console.WriteLine($"{currentStudent}\t\t{curentStudentExamsAverage}\t\t{curentStudentAverage}\tA+\t({extraCredit} pts)");
    }
    else if (curentStudentAverage >= 93 && curentStudentAverage < 97)
    {
        Console.WriteLine($"{currentStudent}\t\t{curentStudentExamsAverage}\t\t{curentStudentAverage}\tA\t({extraCredit} pts)");
    }
    else if (curentStudentAverage >= 90 && curentStudentAverage < 93)
    {
        Console.WriteLine($"{currentStudent}\t\t{curentStudentExamsAverage}\t\t{curentStudentAverage}\tA-\t({extraCredit} pts)");
    }
    else if (curentStudentAverage >= 87 && curentStudentAverage < 90)
    {
        Console.WriteLine($"{currentStudent}\t\t{curentStudentExamsAverage}\t\t{curentStudentAverage}\tB+\t({extraCredit} pts)");
    }
    else if (curentStudentAverage >= 83 && curentStudentAverage < 87)
    {
        Console.WriteLine($"{currentStudent}\t\t{curentStudentExamsAverage}\t\t{curentStudentAverage}\tB+\t({extraCredit} pts)");
    }
    else if (curentStudentAverage >= 80 && curentStudentAverage < 83)
    {
        Console.WriteLine($"{currentStudent}\t\t{curentStudentExamsAverage}\t\t{curentStudentAverage}\tB-\t({extraCredit} pts)");
    }
    else if (curentStudentAverage >= 77 && curentStudentAverage < 80)
    {
        Console.WriteLine($"{currentStudent}\t\t{curentStudentExamsAverage}\t\t{curentStudentAverage}\tC+\t({extraCredit} pts)");
    }
    else if (curentStudentAverage >= 73 && curentStudentAverage < 77)
    {
        Console.WriteLine($"{currentStudent}\t\t{curentStudentExamsAverage}\t\t{curentStudentAverage}\tC\t({extraCredit} pts)");
    }
    else if (curentStudentAverage >= 70 && curentStudentAverage < 73)
    {
        Console.WriteLine($"{currentStudent}\t\t{curentStudentExamsAverage}\t\t{curentStudentAverage}\tC-\t({extraCredit} pts)");
    }
    else
    {
        Console.WriteLine($"{currentStudent}\t\t{curentStudentExamsAverage}\t\t{curentStudentAverage}\tF\t({extraCredit} pts)");
    }
}
Console.WriteLine("\nPress the Enter key to continue");
Console.ReadLine();