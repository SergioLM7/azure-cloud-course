// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Net.Http.Headers;
using System.Text;

//Lesson 9 Loops
//Exercise 1 Fizz Buzz


for (int i = 1; i < 101; i++)
{
    if ((i % 5 == 0) && (i % 3 == 0))
    {
        Console.WriteLine(i + " - FizzBuzz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine(i + " - Buzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine(i + " - Fizz");
    }
    else
    {
        Console.WriteLine(i);
    }
}