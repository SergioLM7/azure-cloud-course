// See https://aka.ms/new-console-template for more information
using System.Text;

//lesson 0
// Console.WriteLine("Hello World!");

//lesson 1
Console.Write("Congratulations!");
Console.Write(" ");
Console.WriteLine("You wrote your first lines of code.");

//lesson 2
string firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Liem";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);

int messagesNumber = 3;
double temperature = 34.4;
Console.WriteLine("Hello, " + firstName + "! You have " + messagesNumber + " messages in your inbox. The temperature is " + temperature + " celsius.");

//lesson 3
Console.WriteLine(@"http:\\www.msn.com");

Console.OutputEncoding = Encoding.UTF8;


Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

Console.Clear();
string greeting = "Hello, ";
string message = $"{greeting} {firstName}!";
Console.WriteLine(message);

Console.Clear();
int version = 11;
Console.WriteLine(version.ToString());
string updateText = "Update to Windows";
Console.WriteLine( $"{updateText} {version}");


//Exercise Lesson2
string projectName = "ACME";
Console.WriteLine($"View English output:\n\tc:\\Exercise\\{projectName}\\data.txt");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.WriteLine($"{russianMessage}:\n\tc:\\Exercise\\ACME\\ru-RU\\data.txt");