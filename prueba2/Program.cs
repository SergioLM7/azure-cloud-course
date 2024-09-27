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
//Exercise 3 - UPDATED
//Lesson 13 Methods
//Exercise 3
/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/
string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255", };

bool validLength;
bool validNumber;

foreach (string ip in ipv4Input)
{
    string[] address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

    ValidateLength(address);
    ValidateNumber(address);

    if (validLength && validNumber)
    {
        Console.WriteLine($"{ip} is a valid IPv4 address");
    }
    else
    {
        Console.WriteLine($"{ip} is an INVALID IPv4 address");
    }
}

bool ValidateLength(string[] address)
{
    return validLength = address.Length == 4;
};


bool ValidateNumber(string[] address)
{
    foreach (string number in address)
    {
        if (number.Length > 1 && number.StartsWith("0"))
        {
            return validNumber = false;
        }
        else
        {
            int value = int.Parse(number);
            if (value < 0 || value > 255)
            {
                return validNumber = false;

            }
        }
    }
    return validNumber = true;
};