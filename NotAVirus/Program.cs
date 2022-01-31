//intro
Console.WriteLine("Welcome to your bank's credit score checker.");

//getting info
Console.WriteLine("Could you please enter your information, starting with your name!");
string name = Console.ReadLine();
Console.WriteLine("Social securtity number: ");
string ss = Console.ReadLine();
Console.WriteLine("Credit Card number:");
string cc = Console.ReadLine();
Console.WriteLine("Bank Account number:");
string bankAccountNumber = Console.ReadLine();
Console.WriteLine("Home Adress: ");
string address = Console.ReadLine();
Console.WriteLine("Mother's Maiden Name: ");
string mmn = Console.ReadLine();
Console.WriteLine("Favorite Food: ");
string favFood = Console.ReadLine();

//displaying stolen info
Console.WriteLine("Thanks for the info " +name);
Console.WriteLine("Please confirm all is correct");
Console.WriteLine($"Social securtity number: {ss}");
Console.WriteLine($"Credit Card number: {cc}");
Console.WriteLine($"Bank Account number: {bankAccountNumber}");
Console.WriteLine($"Home Adress: {address}");
Console.WriteLine($"Mother's Maiden Name: {mmn}");
Console.WriteLine($"Favorite Food: {favFood}");

Console.WriteLine("If all above looks correct you all set! Please ignore any charges that may be applied to this account during the dext 12 days, it's all apart of our procedure and should be refunded instantly. You will hear back from us within the next 14 days, thank you!");