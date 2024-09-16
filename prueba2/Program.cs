// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

//Lesson 7 Conditionals
//Last Exercise
Random random = new Random();
bool continua = true;

while (continua)
{
    Console.Clear();

    int daysUntilExpiration = random.Next(12);
    int discountPercentage = 0;
    Console.WriteLine(daysUntilExpiration);
    if (daysUntilExpiration <= 10)
    {
        if (daysUntilExpiration <= 5)
        {
            if (daysUntilExpiration == 1)
            {
                discountPercentage = 20;
                Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
            }
            else if (daysUntilExpiration < 1)
            {
                Console.WriteLine("Your subscription has expired.");
            }
            else
            {
                discountPercentage = 10;
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!.");
            }
        }
        else
        {
            Console.WriteLine("Your subscription will expire soon. Renew now!");
        }
    }

    //Pulsando una tecla en la consola me vuela a generar un nuevo valor random hasta que pulso la q del teclado, que me saca del bucle
    Console.WriteLine("\nPress any key to generate a new random value, or 'q' to quit.");
    var key = Console.ReadKey();
     if (key.KeyChar == 'q')
            {
                continua = false;
            }
}