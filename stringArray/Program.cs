// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");


//creating strings
string myString = "Grand Circus";
char[] charArray = { 'G', 'r', 'a', 'n', 'd', ' ', 'C', 'i', 'r', 'c', 'u', 's' };
string myString2 = new string(charArray);

Console.WriteLine(myString);
Console.WriteLine(myString2);

//joining strings
string myString3 = myString + myString2;
string myString4 = string.Concat(myString, myString2);

Console.WriteLine(myString3);
Console.WriteLine(myString4);

//comparing strings
if (myString3 == myString4)
{
    Console.WriteLine("The strings are equal");
}


//strings are CASE sensitive
if ("HI" == "hi")
{
    Console.WriteLine("HI is equal to hi");
}
else
{
    Console.WriteLine("HI is not equal to hi");
}

if(string.Compare(myString3, myString4) == 0)
{
    Console.WriteLine("strings are equal");
}

if (myString.Equals(myString))
{
    Console.WriteLine("strings 1 and 2 are equal");
}

//string methods

//indexof
Console.WriteLine(myString.IndexOf(" "));

//LastIndexOf
Console.WriteLine(myString3.LastIndexOf(" "));

//EndsWith
//will return true
Console.WriteLine(myString3.EndsWith("cus"));


//will return false
Console.WriteLine(myString3.EndsWith("egg"));


//Replace
Console.WriteLine(myString3.Replace(' ', '_'));

//split
string[] gcSplit = myString.Split(' ');
foreach(string x in gcSplit)
{
    Console.WriteLine(x);
}

//substring
Console.WriteLine(myString.Substring(4));

//toupper
Console.WriteLine(myString.ToUpper());

//ToLower
Console.WriteLine(myString2.ToLower());

//trim
string messy = "      fsljdfldsakjfalsjfadlskfjlaskfj         ";
Console.WriteLine("/" + messy + "/");
Console.WriteLine(messy.Trim());

//String Builder
StringBuilder strBuff = new StringBuilder("test");
strBuff.Append("\t Super!");
Console.WriteLine(StringBuilder);
