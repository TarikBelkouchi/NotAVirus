// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Welcome to our Room Calculator!");
Console.WriteLine("To start, How many meters is the width: ");
double width = double.Parse(Console.ReadLine());
Console.WriteLine("And the length in meters: ");
double length = double.Parse(Console.ReadLine());

double paremeter = 2 * (width + length);


Console.WriteLine($"With the width and length of the room  being {width} meters and {length} meters, the paremeter of your room is {paremeter} meters!");

Console.WriteLine("For more information, please provide me with the height of the room in meters!");
double height = double.Parse(Console.ReadLine());


double volume = height * width * length;
Console.WriteLine($"The volume of your room is {volume} meters!");

double surface = 2 * (length * width) + 2 * (length * height) + 2 * (height * width);
Console.WriteLine($"The surface of your room is {surface} meters");

if (surface < 250)
{
    Console.WriteLine("The room is small.");
}
if (surface > 250 && surface <650)
{
    Console.WriteLine("the room is medium.");
}
if (surface >650)
{
    Console.WriteLine("the room is large.");
}

