// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Net.Http.Headers;
using System.Text;
using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

//Lesson 12 String Methods - IndexOf and Substring
//Exercise 1
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

var indexOfSpan = input.IndexOf("<span>");
var lastIndexOfSpan = input.IndexOf("</span>");
var length = lastIndexOfSpan - (indexOfSpan+6);
quantity = input.Substring(indexOfSpan+6,length);
var indexOfDiv = input.IndexOf("<div>");
var lastIndexOfDiv = input.IndexOf("</div>");
var length2 = lastIndexOfDiv - (indexOfDiv+5);
output = input.Substring(indexOfDiv+5,length2).Replace("&trade", "&reg");

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");