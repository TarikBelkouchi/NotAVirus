using System;

namespace introlecture
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to the class!");

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"your name is {name}?");

            int age = 29;

            //Creating a constant
            //naming variable all CAPS for constants
            const double TAXRATE = 0.06;

            //Cannot change constants
            // TAXRATE = 1
            //Won't work

            //area of a circle
            Console.WriteLine("Please enter radius");

            /* on the code below we will combine thes 2 lines
            string entry = Console.ReadLine();
            double value = double.Parse(entry);
            */
            double value = double.Parse(Console.ReadLine());

            // Math.PI is a shortcut for PI
            double area = Math.PI * value * value;
            Console.WriteLine(area);


            //arithemtic symbols
            Console.WriteLine(5+5);
            Console.WriteLine(5-5);
            Console.WriteLine(5*5);
            Console.WriteLine(5/5);
            Console.WriteLine(5%2);
            Console.WriteLine(area++);
            Console.WriteLine(area);
            Console.WriteLine(area--);
            Console.WriteLine(area);
            Console.WriteLine(-5);

            //Assignment
            double bankAccount = 0;
            //won a bet
            bankAccount += 5;
            Console.WriteLine(bankAccount);
            //shoveled driveways
            bankAccount += 20;
            Console.WriteLine(bankAccount);
            //Celebrate with some Taco Bell
            bankAccount -= 5.99;
            Console.WriteLine(bankAccount);
            //Bills
            bankAccount -= 10000;
            bankAccount -= 50;
            bankAccount -= 60;
            Console.WriteLine(bankAccount);


            //Casting (covnerting date types)

            int myInt = 7; //less precise
            double myDouble = 32.51; //more precise

            double castedDouble = myInt;
            Console.WriteLine(castedDouble);

            //doesn't work, can't turn a more precise data type to a less precise data type
            //unlesss you do a exclusive cast
            //   int castedInt = myDouble;
            //to do it right follow below
            int castedInt = (int)myDouble;
            Console.WriteLine(castedInt);


        }

    }
}
