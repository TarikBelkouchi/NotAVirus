using System;

namespace MiniExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User!");
            Console.WriteLine("Can I have your first number?");
            string entry1 = Console.ReadLine();
            double num1 = double.Parse(entry1);

            Console.WriteLine("Can I have your second number?");
            string entry2 = Console.RfeadLine();
            double num2 = double.Parse(entry2);

            double sumAdd = num1 + num2;
            double sumSub = num1 - num2;
            double sumMul = num1 * num2;
            double sumDiv = num1 / num2;

            Console.WriteLine($"If added your sum is {sumAdd}");
            Console.WriteLine($"If subtracted your sum is {sumSub}");
            Console.WriteLine($"If multiplied your sum is {sumMul}");
            Console.WriteLine($"If divided your sum is {sumDiv}");


        }
    }
}
