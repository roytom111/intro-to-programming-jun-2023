


using GeneralUtilities;

Console.WriteLine("Enter you first name");
string firstName = Console.ReadLine();
Console.WriteLine("enter you last name");
string  lastName = Console.ReadLine();


string fullName = Formatters.FormatName(firstName, lastName);
Console.WriteLine($"hello, {lastName} {firstName}");