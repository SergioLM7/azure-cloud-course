// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Net.Http.Headers;
using System.Text;
using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

//Lesson 12 DateTime
Console.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss.fff"));
Console.WriteLine(DateTime.UtcNow.ToShortTimeString());
Console.WriteLine(DateTime.UtcNow.AddHours(2).ToShortTimeString());

var date = DateTime.UtcNow;
Console.WriteLine(date.AddDays(31));

var date2 = new DateTime(2024, 01, 31);
Console.WriteLine(date2.AddMonths(1).Ticks);
