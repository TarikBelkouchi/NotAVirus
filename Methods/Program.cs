//main section
string value = ReturnHelloUser("Justin");

Console.WriteLine(value);
Console.WriteLine(ReturnHelloUser("Dustin"));
SayGoodbye();
Console.WriteLine(adder(3, 7));
Console.WriteLine(subtractor(3, 7));
Console.WriteLine(multiplier(3, 7));
Console.WriteLine(divider(3, 7));


CountUp(7);
CountDown(7);

Console.WriteLine(convertMinuteToSeconds(30));
Console.WriteLine(areaTriangle(6, 8));
Console.WriteLine(convertNegative(45));
Console.WriteLine(convertPositive(-45));
greetUser();


Console.WriteLine(getRandom(21));








//method section
static string ReturnHelloUser(string user)
{
    string greeting = $"Hello {user}";
    return greeting;
}






static void SayGoodbye()
{
    Console.WriteLine("Have a great day!");
}

static double adder (double x, double y)
{
    return x + y;
}
static double subtractor (double x, double y)
{
    return x -y;
}
static double multiplier (double x, double y)
{
    return x * y;
}
static double divider (double x, double y)
{
    return x / y;
}

//exercises

//count up
static void CountUp (int x)
{
    for (int i = 1; i <= x; i++)
    {
        Console.WriteLine(i);
    }
}

//count down
static void CountDown (int x)
{
    for (int i = x; i >= 1; i--)
    {
        Console.WriteLine(i);
    }
}

static int convertMinuteToSeconds (int minutes)
{
    int seconds = minutes * 60;
    return seconds;
}

static double areaTriangle (double height, double Base)
{
    double area = (height * Base);
    return area;
}


static int convertNegative(int n)
{
    if (n <= 0)
    {
        return n;
    }
    else
    {
        return n * -1;
    }
}

static int convertPositive(int p)
{
    if (p >= 0)
    {
        return p;
    }
    else
    {
        return p * -1;
    }
}

static void greetUser()
{
    Console.WriteLine("What is your name?");
    string name = Console.ReadLine();
    Console.WriteLine($"Hello {name}!");
}

static int getRandom (int max)
{
    Random rnd = new Random();
    //we put a plus one to make sure its in the range we want
    //0-max
    //return rnd.Next(max + 1);

    //1-max
    return rnd.Next(max) + 1;
}

