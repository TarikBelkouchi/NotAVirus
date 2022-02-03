Console.WriteLine("Learn your squares and cubes!");
Console.WriteLine();
bool Continue = true;
while (Continue)
{
    //ask if they would like to continue
    while (true)
    {
        Console.WriteLine("Enter an integer: ");
        int Num = int.Parse(Console.ReadLine());

        int num1 = 0;
        num1++;


        while (num1 <= 100)
        {
            Console.WriteLine("Number \tSquared \tCubed");
            Console.WriteLine("======= \t======= \t=======");
            Console.WriteLine($"{num1} \t\t{squared(num1)} \t\t{cubed(num1)} ");
            
            if (num1 == Num)
            {


                break;
            }
            num1++;
        }


        Console.WriteLine("Try again? y/n");
        string choice = Console.ReadLine();
        if (choice.Trim().ToLower() == "y")
        {
            Continue = true;
            break;
        }
        else if (choice.Trim().ToLower() == "n")
        {
            Continue = false;
            break;
        }
        else
        {
            Console.WriteLine("Not a valid response");
        }
    }
}
     









static  int squared(int x)
{
    return x * x;
}

static int cubed(int x)
{
    return x * x * x;
}
