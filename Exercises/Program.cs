// See https://aka.ms/new-console-template for more information

//ex1
Console.WriteLine("Enter some text:");
string entry = Console.ReadLine();
Console.WriteLine(entry);


//ex2
Console.WriteLine("Enter a number :");
int numEX2 = int.Parse(Console.ReadLine());
Console.WriteLine(numEX2 + 1);

//ex3
Console.WriteLine("Enter a number :");
double numEX3 = double.Parse(Console.ReadLine());
Console.WriteLine(numEX3 + 0.5);

//ex4



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



bool continueRunning = true;
while (continueRunning)
{
    Console.WriteLine("Enter some text:");
    entry = Console.ReadLine();
    Console.WriteLine(entry);

    Console.WriteLine("Do you want would you like to continue (y/n)");
    string loopChoice = Console.ReadLine();
    if (loopChoice == "y")
    {
        continueRunning = true;
    }
    else if (loopChoice == "n")
    {
        continueRunning = false;
    }
}




