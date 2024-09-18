// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Net.Http.Headers;
using System.Text;

//Lesson 9 Loops
//Exercise Role Battle 
Random random = new Random();
int heroHealth = 10;
int monsterHealth = 10;
int roll = random.Next(1, 11);

do
{
    monsterHealth -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monsterHealth} health.");

    if (monsterHealth <= 0)
    {
        Console.WriteLine("Hero wins!");
    }
    else if (monsterHealth > 0)
    {
        roll = random.Next(1, 11);
        heroHealth -= roll;
        Console.WriteLine($"Hero was damaged and lost {roll} health and now has {heroHealth} health.");
        if (heroHealth <= 0)
        {
            Console.WriteLine("Monster wins!");
        }
        else if (heroHealth > 0)
        {
            roll = random.Next(1, 11);
        }
    }

} while (heroHealth > 0 && monsterHealth > 0);
