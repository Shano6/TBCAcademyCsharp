Console.Write("Enter a number:");
string userInput = Console.ReadLine()!;

if (int.TryParse(userInput, out int number))
{
    for (int i = number; i > 0; i--)
    {
        if (number % i == 0)
        {
            Console.WriteLine(i);
        }
    }
}
else
{
    Console.WriteLine("Wrong Input");
};