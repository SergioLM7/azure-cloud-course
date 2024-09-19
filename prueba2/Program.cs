// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Net.Http.Headers;
using System.Text;
using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("es-ES");

//Lesson 10 Do While
//Exercise 1

/*int userNumber = 0;
string? userInput;
Console.WriteLine("Please, introduce a number between 5 and 10.");

do
{
    userInput = Console.ReadLine();
    bool isInt = int.TryParse(userInput, out int numericValue);
    if (!isInt)
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again.");
    }
    else
    {
        if (numericValue < 5 || numericValue > 10)
        {
            Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
        }
        else
        {
            Console.WriteLine($"Your input value {numericValue} has been accepted.");
            Environment.Exit(0);
        }
    }


} while (userNumber > 10 || userNumber < 5);

//Exercise 2

string? userRole = "";
string? userInput2;
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do
{
    userInput2 = Console.ReadLine();
    if (userInput2 != null)
    {
        userRole = userInput2.Trim();
        if (userRole == "Administrator" || userRole == "Manager" || userRole == "User")
        {
            Console.WriteLine($"Your input value {userInput2} has been accepted.");
             Environment.Exit(0);
        }
        else
        {
            Console.WriteLine($"The role name that you entered, {userRole} is not valid. Enter your role name (Administrator, Manager, or User)");
        }
    } else {
        Console.WriteLine($"Your input value must be a string.");
    }




} while (userRole != "Administrator" || userRole != "Manager" || userRole != "User");
*/
//Exercise 3
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}

