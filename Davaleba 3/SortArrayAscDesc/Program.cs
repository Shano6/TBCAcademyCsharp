int array1Length = askForNumber("Enter Array 1 Length: ");
int[] arr1 = new int[array1Length];

Console.WriteLine("Enter Array 1 values");
for (int i = 0; i < array1Length; i++)
{
    int number = askForNumber("Enter a number: ");
    arr1[i] = number;
}

int array2Length = askForNumber("Enter Array 2 Length: ");
int[] arr2 = new int[array2Length];

Console.WriteLine("Enter Array 2 values");
for (int i = 0; i < array2Length; i++)
{
    int number = askForNumber("Enter a number: ");
    arr2[i] = number;
}

int[] arrUnified = new int[arr1.Length + arr2.Length];
arr1.CopyTo(arrUnified, 0);
arr2.CopyTo(arrUnified, arr1.Length);


Console.WriteLine("Sort Ascending or descending ? Enter (A/D)");
string input = Console.ReadLine()!.ToLower();

if (input == "a")
{
    ascendingSort(arrUnified);
}
else if (input == "d")
{
    descendingSort(arrUnified);
}
else
{
    Console.WriteLine("Wrong input");
    return;
}

foreach (int i in arrUnified)
{
    Console.Write(i + " ");
}

void ascendingSort(int[] arr)
{
    int n = arr.Length;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}

void descendingSort(int[] arr)
{
    int n = arr.Length;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (arr[j] < arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
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