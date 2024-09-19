// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Net.Http.Headers;
using System.Text;
using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("es-ES");

//Lesson 11 Array Methods
//Exercise 1
string pangram = "The quick brown fox jumps over the lazy dog";
string [] pangramArray = pangram.Split(' ');
string pangramReversed = "";
foreach (var word in pangramArray)
{
    //Console.WriteLine(word);
    char[] letters = word.ToCharArray();
    Array.Reverse(letters);
    var wordReversed = String.Join("", letters);
    //Console.WriteLine(wordReversed);
    pangramReversed += wordReversed + " ";

}

 Console.WriteLine(pangramReversed);