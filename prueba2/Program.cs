// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Net.Http.Headers;
using System.Text;
using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

//Lesson 11 Array Methods - String interpolation
//Exercise 2
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.\n");
Console.WriteLine("Here's a quick comparison:\n");

string currentProductAligned = currentProduct.PadRight(20);
string newProductAligned = newProduct.PadRight(20);
string currentReturnAligned = string.Format("{0:P2}", currentReturn).PadRight(10);
string newReturnAligned = string.Format("{0:P2}", newReturn).PadRight(10);

Console.WriteLine($"{currentProductAligned}{currentReturnAligned}{currentProfit:C}\n{newProductAligned}{newReturnAligned}{newProfit:C}");


