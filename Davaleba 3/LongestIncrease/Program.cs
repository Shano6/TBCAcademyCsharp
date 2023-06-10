int arrLength = askForNumber("Enter array length: ");
int[] array = new int[arrLength];

for (int i = 0; i < arrLength; i++)
{
    array[i] = askForNumber("Enter a number: ");
}

int maxLength = 1; 
int maxStartIndex = 0;
int currentLength = 1;
int currentStartIndex = 0;

for (int i = 1; i < array.Length; i++)
{
    if (array[i] > array[i - 1])
    {
        currentLength++;

        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            maxStartIndex = currentStartIndex;
        }
    }
    else
    {
        currentLength = 1;
        currentStartIndex = i;
    }
}

for (int i = maxStartIndex; i < maxStartIndex + maxLength; i++)
{
    Console.Write(array[i] + " ");
}

int askForNumber(string message)
{
    int result = 0;
    bool isNumber = false;
    int i = 0;
    while (!isNumber)
    {
        if (i > 0) Console.WriteLine("Wrong input, Try again");
        Console.Write(message);
        string numberString = Console.ReadLine()!;
        isNumber = int.TryParse(numberString, out result);
        i++;
    }
    return result;
}