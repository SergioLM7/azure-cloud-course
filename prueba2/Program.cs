// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Net.Http.Headers;
using System.Text;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Transactions;
using Microsoft.VisualBasic;
CultureInfo.CurrentCulture = new CultureInfo("es-ES");

//Lesson 14 Methods
//Exercise - Dice Game
Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
var key = Console.ReadKey(true);

if (ShouldPlay(key.KeyChar)) 
{
    PlayGame();
}

string WinOrLose(int target, int roll)
{
    return target > roll ? "You lose!" : "You win!";
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = random.Next(1,6);
        var roll = random.Next(1,7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine("Roll your six-faces dice with the Enter key...");
        Console.ReadLine();
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");
        var key = Console.ReadKey(true);
        play = ShouldPlay(key.KeyChar);
    }
}

bool ShouldPlay(char key) 
{
    if (key == 'y') {
        return true;
    } else if (key == 'n') {
        return false;
    } else {
        return false;
    }
}