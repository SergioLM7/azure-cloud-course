// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;


//Exercise Lesson4
//Calculate grade averages of every student
var gradesSophia = 93 + 87 + 98 + 95 + 100;
var gradesNicolas = 80 +  83 +  82 +  88 + 85;
var gradesZafirah = 84 +  96 +  73 +  85 + 79;
var gradesJeong = 90 +  92 +  98 +  100 + 97;
decimal currentAssigments = 5m;

var averageSophia = gradesSophia / currentAssigments;
var averageNicolas = gradesNicolas / currentAssigments;
var averageZafirah = gradesZafirah / currentAssigments;
var averageJeong = gradesJeong / currentAssigments;

Console.WriteLine("Student\t\tGrade");
Console.WriteLine($"Sophia\t\t{averageSophia}\t\t");
Console.WriteLine($"Nicolas\t\t{averageNicolas}");
Console.WriteLine($"Zafirah\t\t{averageZafirah}");
Console.WriteLine($"Jeong\t\t{averageJeong}");


//Exercise Lesson5
//Calculate the GPA of a student and represent it in a provided format

//Option A: long and unoptimized one
string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeCourse1 = 4;
int gradeCourse2 = 3;
int gradeCourse3 = 3;
int gradeCourse4 = 3;
int gradeCourse5 = 4;

var multCourse1 = gradeCourse1 * course1Credit;
var multCourse2 = gradeCourse2 * course2Credit;
var multCourse3 = gradeCourse3 * course3Credit;
var multCourse4 = gradeCourse4 * course4Credit;
var multCourse5 = gradeCourse5 * course5Credit;

var finalGPA = (decimal)(multCourse1+multCourse2+multCourse3+multCourse4+multCourse5) / (course1Credit + course2Credit + course3Credit + course4Credit + course5Credit);

Console.WriteLine($"Student: {studentName}\n\nCourse\t\t\tGrade\t\tCredit Hours");
Console.WriteLine($"{course1Name}\t\t{gradeCourse1}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t{gradeCourse2}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t{gradeCourse3}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{gradeCourse4}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{gradeCourse5}\t\t{course5Credit}\n");
Console.WriteLine($"Final GPA:\t\t{decimal.Round(finalGPA, 2)}");