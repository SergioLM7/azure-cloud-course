// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Net.Http.Headers;
using System.Text;

//Lesson 9 Ternary operator
//Exercise 2
Random coin = new();
int flip = coin.Next(1, 3);
Console.WriteLine(flip == 1 ? "heads" : "tails");

//Exercise 2 version 1 line
Console.WriteLine(new Random().Next(1, 3) == 1 ? "heads" : "tails");

/*Use la clase Random para generar un valor.

Tenga en cuenta el intervalo de números necesarios.

Según el valor generado, use el operador condicional para mostrar heads o tails.

Debería haber una posibilidad del 50 % de que el resultado sea cara o cruz.

El código debe ser fácil de leer, pero con el menor número posible de líneas.

Debería lograr el resultado deseado en tres líneas de código o menos.*/

//Exercise 3 version 1 line
string permission = "Admin"; //Admin or Manager
int level = 30;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else if (level <= 55)
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level > 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else if (level <= 20)
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
} else {
    Console.WriteLine("You do not have sufficient privileges.");
}

