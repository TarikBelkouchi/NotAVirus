Console.WriteLine("Welcome to the number analyzer may I please have your name!");
string user = Console.ReadLine();


bool continueRunning = true;
while (continueRunning)
{


Console.WriteLine($"Thanks {user}, can you please provide me with a number between 1-100!");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 1 && num < 60)
{
    Console.WriteLine($"{user}, looks like your number is odd and less than 60!");

}

if (num % 2 == 0 && num <25 && num >1)
{
    Console.WriteLine($"{user}, looks like your number is even and less than 25!");
}

if (num % 2 == 0 && num > 25 && num < 60)
{
    Console.WriteLine($"{user}, looks like your number is even and between 26 and 60 inclusive!");

}

if (num % 2 == 0 && num > 60)
{
    Console.WriteLine($"{user}, looks like your number is even and greater than 60");
}

if (num % 2 == 1 && num > 60)
{
    Console.WriteLine($"{user}, looks like your number is odd and greater than 60");
}


    Console.WriteLine("Do you want to try another number? y/n");
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