// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

//Lesson 8 Arrays ForEach

string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000"; //Error because index is outside the bounds of the array
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

string[] names = ["Rowena", "Robin", "Bao"];
foreach (string name in names)
{
    Console.WriteLine(name);
}

Console.Clear();
//Exercise 1 Lesson 8
string[] orderIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
foreach (var ID in orderIDs)
{
   if(ID.StartsWith('B'))
    Console.WriteLine(ID);
   
}