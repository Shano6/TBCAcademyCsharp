char[] array = GetUserInputArray();

Console.Write("Enter a symbol to search in the array: ");
char symbol = Convert.ToChar(Console.ReadLine()!);

int count = CountOccurrences(array, symbol);

PrintOccurrences(symbol, count);

char[] GetUserInputArray()
{
    Console.Write("Enter the size of the array: ");
    int size = Convert.ToInt32(Console.ReadLine());

    char[] array = new char[size];

    Console.WriteLine("Enter the elements of the array:");

    for (int i = 0; i < size; i++)
    {
        Console.Write("Element {0}: ", i + 1);
        array[i] = Convert.ToChar(Console.ReadLine()!);
    }

    return array;
}
int CountOccurrences(char[] array, char symbol)
{
    int count = 0;

    foreach (char element in array)
    {
        if (element == symbol)
        {
            count++;
        }
    }

    return count;
}

void PrintOccurrences(char symbol, int count)
{
    Console.WriteLine("Symbol '{0}' was found {1} time(s).", symbol, count);
}


