string[] arr1 = new string[askForNumber("Enter Array 1 Length: ")];

for (int i = 0; i < arr1.Length; i++)
{
    Console.Write("Enter a string: ");
    arr1[i] = Console.ReadLine()!;
}

string[] arr2 = new string[askForNumber("Enter Array 2 Length: ")];

for (int i = 0; i < arr2.Length; i++)
{
    arr2[i] = askForNumber("Enter a number: ").ToString();
}

Console.WriteLine("your arrays:");
Console.Write("array 1: ");
foreach (var i in arr1)
{
    Console.Write(i.ToString() + " ");
}

Console.WriteLine();
Console.Write("array 2: ");
foreach (var i in arr2)
{
    Console.Write(i.ToString() + " ");
}

int length1 = arr1.Length;
int length2 = arr2.Length;
int mergedLength = length1 + length2;

string[] mergedArray = new string[mergedLength];

int index = 0;
int index1 = 0;
int index2 = 0;

while (index1 < length1 && index2 < length2)
{
    mergedArray[index++] = arr1[index1++];
    mergedArray[index++] = arr2[index2++];
}

while (index1 < length1)
{
    mergedArray[index++] = arr1[index1++];
}

while (index2 < length2)
{
    mergedArray[index++] = arr2[index2++];
}

Console.WriteLine();
Console.Write("Merged array is: ");
foreach (var e in mergedArray)
{
    Console.Write(e + " ");
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