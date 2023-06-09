int arrayLength = askForNumber("Enter Array Length: ");
int[] numberArr = new int[arrayLength];

for (int i = 0; i < arrayLength; i++)
{
    int number = askForNumber("Enter a number: ");
    assignIndex(i, number);
    
}

Console.Write("Sorted array: ");
foreach (var i in numberArr)
{
    Console.Write(i.ToString()+" ");
}

void assignIndex(int currentIndex, int number)
{
    if (currentIndex > 0 && number < numberArr[currentIndex - 1])
    {
        numberArr[currentIndex] = numberArr[currentIndex - 1];
        numberArr[currentIndex - 1] = number;
        assignIndex(currentIndex - 1, number);
    }
    else
    {
        numberArr[currentIndex] = number;
    }
}

int askForNumber(string message)
{
    int result=0;
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