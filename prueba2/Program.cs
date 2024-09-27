// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Net.Http.Headers;
using System.Text;
using System.Globalization;
using System.Runtime.ExceptionServices;
CultureInfo.CurrentCulture = new CultureInfo("es-ES");

//Lesson 13 Methods
//Project 1
string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

printEmails(corporate);
printEmails(external, externalDomain);

void printEmails(string[,] company, string domain = "contoso.com")
{
    for (int i = 0; i < company.GetLength(0); i++)
    {
        if (string.IsNullOrWhiteSpace(company[i, 0]) || string.IsNullOrWhiteSpace(company[i, 1]))
        {
            Console.WriteLine($"Row {i+1}: Missing or incomplete employee data. Cannot create email.");
        }
        else
        {
            string finalEmail = $"{createEmail(company[i, 0], company[i, 1])}{domain}";
            Console.WriteLine(finalEmail);
        }
    }
};


string createEmail(string name, string surname)
{
    string firstLetters = name.Substring(0, 2).ToLower();
    string email = $"{firstLetters}{surname.ToLower()}@";
    return email;
};