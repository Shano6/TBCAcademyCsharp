Console.Write("Enter a number:");
string userInput = Console.ReadLine()!;

if (int.TryParse(userInput, out int number))
{
    int longestLength = number + (number - 1);
    for (int fullDots = 1; fullDots < longestLength + 1; fullDots+=2)
    {
        Console.WriteLine(generateLine(fullDots, longestLength));
    }
}
else
{
    Console.WriteLine("Wrong Input");
}

string generateLine(int fullDots, int longestLength)
{
    string generatedLine = "";
    int emptyDots = (longestLength - fullDots) / 2;
    for (int i = 0; i < emptyDots + fullDots; i++)
    {
        generatedLine += i < emptyDots ? " " : "*";
    }
    return generatedLine;
}