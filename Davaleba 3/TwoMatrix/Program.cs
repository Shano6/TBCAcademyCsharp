int[,] matrix1;
int[,] matrix2;

while (true)
{
    Console.WriteLine("Enter the dimensions for the first matrix (N x M):");
    int n = ReadPositiveInteger("N");
    int m = ReadPositiveInteger("M");

    Console.WriteLine("Enter the dimensions for the second matrix (M x K):");
    int k = ReadPositiveInteger("K");

    matrix1 = ReadMatrix(n, m);
    matrix2 = ReadMatrix(m, k);

    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("The number of columns in the first matrix must match the number of rows in the second matrix. Please try again.\n");
    }
    else
    {
        break;
    }
}

Console.WriteLine("\nFirst matrix:");
PrintMatrix(matrix1);

Console.WriteLine("\nSecond matrix:");
PrintMatrix(matrix2);

int[,] result = MultiplyMatrices(matrix1, matrix2);

Console.WriteLine("\nResultant matrix (N x K):");
PrintMatrix(result);

static int ReadPositiveInteger(string dimension)
{
    int value;
    while (true)
    {
        Console.Write($"Enter the value for {dimension}: ");
        if (int.TryParse(Console.ReadLine(), out value) && value > 0)
        {
            return value;
        }
        Console.WriteLine("Invalid input. Please enter a positive integer.\n");
    }
}

static int[,] ReadMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    Console.WriteLine("Enter the elements for the matrix:");

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"[{i}][{j}]: ");
            matrix[i, j] = int.Parse(Console.ReadLine()!);
        }
    }

    return matrix;
}

static void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int columns1 = matrix1.GetLength(1);
    int columns2 = matrix2.GetLength(1);

    int[,] result = new int[rows1, columns2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            for (int x = 0; x < columns1; x++)
            {
                result[i, j] += matrix1[i, x] * matrix2[x, j];
            }
        }
    }

    return result;
}