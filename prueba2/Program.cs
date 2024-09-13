// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

//Lesson 6
//var dice = new Random();
/*Random dice = new(); //Istanciacion directa
var roll = dice.Next(1, 7); //Genera un valor entero aleatorio entre los 2 que le indiquemos como argumentos. 
//El segundo no se incluye. El primero, si
Console.WriteLine(roll);*/

Random dice = new Random();
int roll = dice.Next();
Console.WriteLine(roll);

//Refactorizacion
//Imprimimos en pantalla una tirada de dados
Console.WriteLine(new Random().Next(1,7));

//Exercise 1 Lesson 6
int firstValue = 1000;
int secondValue = 600;
int largerValue = Math.Max(firstValue,secondValue); //Metodo que devuelve el valor mas grande

Console.WriteLine(largerValue);