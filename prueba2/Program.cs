// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Net.Http.Headers;
using System.Text;

//Lesson 8 Arrays ForEach
//Exercise 2
int[] sophiaScores = [90, 86, 87, 98, 100];
int[] andrewScores = [92, 89, 81, 96, 90];
int[] emmaScores = [90, 85, 87, 98, 68];
int[] loganScores = [90, 95, 87, 88, 96];
string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan"];

int[] studentScores = new int[10];

Console.WriteLine("Student\t\tGrade");

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

    foreach (int score in studentScores)
    {
        sumScores += score;
    }

    curentStudentAverage = (decimal)sumScores / studentScores.Length;

    if (curentStudentAverage >= 97 && curentStudentAverage <= 100)
    {
        Console.WriteLine($"{currentStudent}\t\t{curentStudentAverage}\tA+");
    }
    else if (curentStudentAverage >= 93 && curentStudentAverage < 97)
    {
        Console.WriteLine($"{currentStudent}\t\t{curentStudentAverage}\tA");
    }
    else if (curentStudentAverage >= 90 && curentStudentAverage < 93)
    {
        Console.WriteLine($"{currentStudent}\t\t{curentStudentAverage}\tA-");
    }
    else if (curentStudentAverage >= 87 && curentStudentAverage < 90)
    {
        Console.WriteLine($"{currentStudent}\t\t{curentStudentAverage}\tB+");
    }
    else if (curentStudentAverage >= 83 && curentStudentAverage < 87)
    {
        Console.WriteLine($"{currentStudent}\t\t{curentStudentAverage}\tB+");
    }
    else if (curentStudentAverage >= 80 && curentStudentAverage < 83)
    {
        Console.WriteLine($"{currentStudent}\t\t{curentStudentAverage}\tB-");
    }
    else if (curentStudentAverage >= 77 && curentStudentAverage < 80)
    {
        Console.WriteLine($"{currentStudent}\t\t{curentStudentAverage}\tC+");
    }
    else if (curentStudentAverage >= 73 && curentStudentAverage < 77)
    {
        Console.WriteLine($"{currentStudent}\t\t{curentStudentAverage}\tC");
    }
    else if (curentStudentAverage >= 70 && curentStudentAverage < 73)
    {
        Console.WriteLine($"{currentStudent}\t\t{curentStudentAverage}\tC-");
    }
    else
    {
        Console.WriteLine($"{currentStudent}\t\t{curentStudentAverage}\tF");
    }

}

Console.WriteLine("\nPress the Enter key to continue");
Console.ReadLine();

/*
Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();*/
//Option B - classroom
string[] alumnos = { "Sophia", "Andrew", "Emma", "Logan" };

// Crear un array de arrays de enteros
//Inicializar directamente
int[][] notas = new int[4][];
notas[0] = new int[] { 90, 86, 87, 98, 100 };
notas[1] = new int[] { 92, 89, 81, 96, 90 };
notas[2] = new int[] { 90, 85, 87, 98, 68 };
notas[3] = new int[] { 90, 95, 87, 88, 96 };

var indiceDeAlumno = 0;
decimal sumaDeValores = 0;
// Mostrar los nombres y sus valores asociados
foreach (var alumno in alumnos)
{
    sumaDeValores = notas[indiceDeAlumno].Sum();

    var media = sumaDeValores / (notas.Length + 1);
    indiceDeAlumno++;
    sumaDeValores = 0;


    var notaEnLetra = "F";
    if (media <= 59) { notaEnLetra = "F"; }
    else if (media <= 62) { notaEnLetra = "D-"; }
    else if (media <= 66) { notaEnLetra = "D"; }
    else if (media <= 69) { notaEnLetra = "D+"; }
    else if (media <= 72) { notaEnLetra = "C-"; }
    else if (media <= 76) { notaEnLetra = "C"; }
    else if (media <= 79) { notaEnLetra = "C+"; }
    else if (media <= 82) { notaEnLetra = "B-"; }
    else if (media <= 86) { notaEnLetra = "B"; }
    else if (media <= 89) { notaEnLetra = "B+"; }
    else if (media <= 92) { notaEnLetra = "A-"; }
    else if (media <= 96) { notaEnLetra = "A"; }
    else if (media <= 100) { notaEnLetra = "A+"; }
    else { notaEnLetra = "Out Range"; }

    Console.WriteLine($"Nombre: {alumno} \t Valores: {media} \t {notaEnLetra}");

}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();