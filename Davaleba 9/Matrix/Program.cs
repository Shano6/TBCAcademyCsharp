using MatrixApp;

Console.WriteLine("Enter the values for a 2x2 matrix:");

Console.Write("Value for row 1, column 1: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Value for row 1, column 2: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Value for row 2, column 1: ");
double c = Convert.ToDouble(Console.ReadLine());

Console.Write("Value for row 2, column 2: ");
double d = Convert.ToDouble(Console.ReadLine());

Matrix m1 = new Matrix(a, b, c, d);
Matrix m2 = 2; 

Console.WriteLine("\nMatrix m1:");
Console.WriteLine(m1);

Console.WriteLine("\nMatrix m2:");
Console.WriteLine(m2);

Matrix sum = m1 + m2;
Matrix difference = m1 - m2;
Matrix product = m1 * m2;
Matrix inverted = -m1;

Console.WriteLine("\nMatrix Sum (m1 + m2):");
Console.WriteLine(sum);

Console.WriteLine("\nMatrix Difference (m1 - m2):");
Console.WriteLine(difference);

Console.WriteLine("\nMatrix Product (m1 * m2):");
Console.WriteLine(product);

Console.WriteLine("\nInverted Matrix (-m1):");
Console.WriteLine(inverted);

Console.WriteLine("\nEquality Check (m1 == m2): " + (m1.Equals(m2) ? "Equal" : "Not Equal"));

Console.ReadLine();


namespace MatrixApp
{
    public class Matrix
    {
        private double[,] data = new double[2, 2];

        public double this[int row, int col]
        {
            get { return data[row, col]; }
            set { data[row, col] = value; }
        }

        public Matrix(double a, double b, double c, double d)
        {
            data[0, 0] = a;
            data[0, 1] = b;
            data[1, 0] = c;
            data[1, 1] = d;
        }

        public static implicit operator Matrix(double scalar)
        {
            return new Matrix(scalar, scalar, scalar, scalar);
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            Matrix result = new Matrix(0, 0, 0, 0);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = m1[i, j] + m2[i, j];
                }
            }

            return result;
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            Matrix result = new Matrix(0, 0, 0, 0);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = m1[i, j] - m2[i, j];
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            Matrix result = new Matrix(0, 0, 0, 0);

            result[0, 0] = m1[0, 0] * m2[0, 0] + m1[0, 1] * m2[1, 0];
            result[0, 1] = m1[0, 0] * m2[0, 1] + m1[0, 1] * m2[1, 1];
            result[1, 0] = m1[1, 0] * m2[0, 0] + m1[1, 1] * m2[1, 0];
            result[1, 1] = m1[1, 0] * m2[0, 1] + m1[1, 1] * m2[1, 1];

            return result;
        }

        public static Matrix operator -(Matrix m)
        {
            Matrix result = new Matrix(0, 0, 0, 0);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = -m[i, j];
                }
            }

            return result;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Matrix other = (Matrix)obj;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (data[i, j] != other[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override string ToString()
        {
            return $"{data[0, 0]}  {data[0, 1]}\n{data[1, 0]}  {data[1, 1]}";
        }
    }
}
