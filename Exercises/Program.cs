// See https://aka.ms/new-console-template for more information

//ex6

string choice = "y";
do
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Would  you like to continue? y/n ");
    choice = Console.ReadLine();
}
while (choice == "y");

//ex 7
Console.WriteLine("Enter some text:");
string entry = Console.ReadLine()