Console.Write("Enter a number:");
string userInput = Console.ReadLine()!;

if (int.TryParse(userInput, out int number)) 
{
	for (int i = number-1; i > 1; i--)
	{
        if (number%i == 0)
		{
			Console.WriteLine("The number is Composite");
			return;
		}
	}
    Console.WriteLine("The number is Prime");
}
else
{
    Console.WriteLine("Wrong Input");
};