Console.Write("Enter a number:");
string userInput = Console.ReadLine()!;

if (int.TryParse(userInput, out int number)&& number>0)
{
    int sum = 0;
    for (int i = number; i > 0; i--)
    {
        sum += i;
    }

    Console.WriteLine("Arithmetical average for that number is: " + sum / number);
}
else
{
    Console.WriteLine("Wrong Input");
};