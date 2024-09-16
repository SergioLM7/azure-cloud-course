// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

//Lesson 8 Arrays ForEach
//Exercise 2
int[] sophiaScores = [90, 86, 87, 98, 100];
int[] andrewScores = [92, 89, 81, 96, 90];
int[] emmaScores = [90, 85, 87, 98, 68];
int[] loganScores = [90, 95, 87, 88, 96];

int sophiaSum = 0;
decimal sophiaAverage;

foreach (var score in sophiaScores)
{
    sophiaSum += score;
}

sophiaAverage = (decimal)sophiaSum / sophiaScores.Length;

Console.WriteLine(sophiaAverage);

if(sophiaSum >= 97 && sophiaSum <= 100) 
{
    Console.WriteLine($"Sophia:\t\t{(decimal)sophiaSum / sophiaScores.Length}\tA+");
} else if(sophiaSum >= 93 && sophiaSum <= 96) 
{
    Console.WriteLine($"Sophia:\t\t{(decimal)sophiaSum / sophiaScores.Length}\tA");
} else if(sophiaSum >= 90 && sophiaSum <= 92) 
{
    Console.WriteLine($"Sophia:\t\t{(decimal)sophiaSum / sophiaScores.Length}\tA-");
} else if(sophiaSum >= 87 && sophiaSum <= 89) 
{
    Console.WriteLine($"Sophia:\t\t{(decimal)sophiaSum / sophiaScores.Length}\tB+");
} else if(sophiaSum >= 83 && sophiaSum <= 86) 
{
    Console.WriteLine($"Sophia:\t\t{(decimal)sophiaSum / sophiaScores.Length}\tB");
} else if(sophiaSum >= 80 && sophiaSum <= 82) 
{
    Console.WriteLine($"Sophia:\t\t{(decimal)sophiaSum / sophiaScores.Length}\tB-");
} else if(sophiaSum >= 77 && sophiaSum <= 79) 
{
    Console.WriteLine($"Sophia:\t\t{(decimal)sophiaSum / sophiaScores.Length}\tC+");
} else if(sophiaSum >= 73 && sophiaSum <= 76) 
{
    Console.WriteLine($"Sophia:\t\t{(decimal)sophiaSum / sophiaScores.Length}\tC");
} else if(sophiaSum >= 70 && sophiaSum <= 72) 
{
    Console.WriteLine($"Sophia:\t\t{(decimal)sophiaSum / sophiaScores.Length}\tC-");
}
  

/*
Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();*/