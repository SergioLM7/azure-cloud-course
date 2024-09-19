// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Net.Http.Headers;
using System.Text;
using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("es-ES");

//Lesson 10 Variables converssion
//Exercise 1
string[] values = { "12,3", "45", "ABC", "11", "DEF" };
string message = "";
double total = 0;

foreach (var value in values)
{
    if (double.TryParse(value, out double result)) {
        total += result;
    } else {
        message += value;
    }
}

Console.WriteLine("Message: " + message); 
Console.WriteLine("Total: " + total);

//Exercise 2
int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

decimal result1 = (decimal) value1 / value2;
Console.WriteLine($"Divide value1 by value2, display the result as an int: {Math.Round(result1)}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");