Console.Write("Enter the temperature in Celsius: ");
string input = Console.ReadLine()!;

if (int.TryParse(input, out int temperature))
{
    if (temperature < 0)
    {
        Console.WriteLine("It's cold");
    }
    else if (temperature >= 0 && temperature <= 30)
    {
        Console.WriteLine("It's good weather");
    }
    else
    {
        Console.WriteLine("It's hot");
    }
}
else
{
    Console.WriteLine("Wrong Input");
}

