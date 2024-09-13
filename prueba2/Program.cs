// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

//Lesson 7 Conditionals
//Option 1
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total2 = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total2}");
//Option 2 without sum
Console.WriteLine($"Dice roll: {dice.Next(3, 19)}");
//Option 3 without sum
var total = 0;
var tirada = 0;

Console.Write($"Dice roll: ");
for (int i = 0; i < 3; i++)
{
    tirada = dice.Next(1, 7);
    total += tirada;

    if (i == 2)
    {
        Console.Write($"{tirada}. ");
    }
    else
    {
        Console.Write($"{tirada} + ");
    }

}
Console.WriteLine($"Total: {total}");
//Conditional to resolve if you win or lose
if (total >= 14)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("Sorry, you lose.");
}

//Console.WriteLine('a' > 'c');

//Option 4 with an array
var total3 = 0;
int[] tirada3 = new int[3];

Console.Write($"Dice roll: ");
for (int i = 0; i < 3; i++)
{
    tirada3[i] = dice.Next(1, 7);
    total3 += tirada3[i];
    if (i == 2)
    {
        Console.Write($"{tirada3[i]}. ");
    }
    else
    {
        Console.Write($"{tirada3[i]} + ");
    }

}

//Comprueba si la tirada ha sido triple y si no, si ha sido doble
if (tirada3[0] == tirada3[1] && tirada3[1] == tirada3[2])
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}
else if ((tirada3[0] == tirada3[1]) || (tirada3[1] == tirada3[2]) || (tirada3[0] == tirada3[2]))
{
    Console.Write("You rolled doubles! +2 bonus to total! ");
    total3 += 2;
}
Console.WriteLine($"Total: {total3}");