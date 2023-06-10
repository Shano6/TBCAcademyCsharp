int[,] matrix;
int size;

Console.WriteLine("Enter the size of the matrix (2 for 2x2, 3 for 3x3):");
if (!int.TryParse(Console.ReadLine(), out size) || (size != 2 && size != 3))
{
    Console.WriteLine("Invalid size. Please enter 2 or 3.");
    return;
}

matrix = new int[size, size];

Console.WriteLine("Enter the matrix elements:");

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write("Enter element [{0}, {1}]: ", i, j);
        if (!int.TryParse(Console.ReadLine(), out matrix[i, j]))
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
            return;
        }
    }
}

Console.WriteLine("\nMatrix:");
PrintMatrix(matrix, size);

int determinant = CalculateDeterminant(matrix, size);
Console.WriteLine("\nDeterminant: {0}", determinant);

static void PrintMatrix(int[,] matrix, int size)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

static int CalculateDeterminant(int[,] matrix, int size)
{
    if (size == 2)
    {
        return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }
    else if (size == 3)
    {
        return matrix[0, 0] * matrix[1, 1] * matrix[2, 2] +
          matrix[0, 1] * matrix[1, 2] * matrix[2, 0] +
          matrix[0, 2] * matrix[1, 0] * matrix[2, 1] -
          matrix[0, 2] * matrix[1, 1] * matrix[2, 0] -
          matrix[0, 0] * matrix[1, 2] * matrix[2, 1] -
          matrix[0, 1] * matrix[1, 0] * matrix[2, 2];
    }

    return 0;
}