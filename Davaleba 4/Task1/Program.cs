int[] numbers = { 123, 456, 789 };
int index = 2;
int sum = CalculateSum(numbers, index);
Console.WriteLine("Sum: ", index, sum);

int CalculateSum(int[] array, int index)
{
    if (index < 0 || index >= array.Length)
    {
        throw new IndexOutOfRangeException("Index is out of range");
    }

    int element = array[index];
    int sum = 0;

    while (element != 0)
    {
        int digit = element % 10;
        sum += digit;
        element /= 10;
    }

    return sum;
}