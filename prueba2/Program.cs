// See https://aka.ms/new-console-template for more information
using System.Text;

//lesson 3
int firstNumber = 12;
int secondNumber = 7;
var sumNumbers = firstNumber + secondNumber;
Console.WriteLine(sumNumbers);

string firstName = "Bob";
int widgetSold = 7;
Console.WriteLine(firstName + " sold " + widgetSold + " widgets.");
Console.WriteLine(firstName + " sold " + widgetSold + 7 + " widgets.");
Console.WriteLine(firstName + " sold " + (widgetSold + 7) + " widgets.");

//Exercise lesson 3
var firstNumber2 = 45;
var secondNumber2 = 2;
double decimalNumber1 = 4.5;
double decimalNumber2 = 2.35;

//Sum two int
var sum = firstNumber2 + secondNumber2;
Console.WriteLine("This is the result of a sum: " + sum);

//Substr two int
var substraction = firstNumber2 - secondNumber2;
Console.WriteLine("This is the result of a subs: " +substraction);

//Mult two int
var multiplication = firstNumber2 * secondNumber2;
Console.WriteLine("This is the result of a mult: " + multiplication);

//Div and decimal Div
var div = firstNumber2 / secondNumber2;
decimal decimalDivResult = firstNumber2 / Convert.ToDecimal(secondNumber2);
decimal decimalDivResultV2 = firstNumber2 / (decimal)secondNumber2;
Console.WriteLine("This is the result of a div: " + div);
Console.WriteLine("This is the result of a decimal div: " + decimalDivResult);
Console.WriteLine("This is the result of a decimal div V2: " + decimalDivResultV2);

//Div two doubles
var decimalDiv = decimalNumber1 / decimalNumber2;
Console.WriteLine("This is the result of a div of two doubles: " + decimalDiv);

//Rest of a div of int
var restDiv = firstNumber2 % secondNumber2;
Console.WriteLine("This is the rest of a div: " + restDiv);

//Otra opcion de obtener resultados decimales de una division
decimal a = 10 / 3m;
Console.WriteLine(a);

//Exercise 2 lesson 3
/* int value = 0;
 value = value + 5;
 value += 5;

Console.Write(value);*/

//Exercise Farenheit to Celsius
//Para convertir temperaturas de grados Fahrenheit a Celsius, primero reste 32 y luego multiplique por cinco novenos (5/9).
var farenheitTemperature = 78;
var farenheitToCelsius = (farenheitTemperature - 32) * 5/9m;
var celsiusOneDecimal =  Math.Round(farenheitToCelsius, 1);
Console.WriteLine(farenheitToCelsius); //25.555555555555555555555555556
Console.WriteLine($"The temperature of {farenheitTemperature}F is {celsiusOneDecimal}º Celsius."); //The temperature of 78F is 25.6º Celsius.

//Options B and C
var celsiusOneDecimal2 = decimal.Round(farenheitToCelsius, 1);
Console.WriteLine(celsiusOneDecimal2); //25.6
Console.WriteLine("The temperature is " + farenheitToCelsius.ToString("##.#") + " Celsius."); //Mascara de una cadena de texto