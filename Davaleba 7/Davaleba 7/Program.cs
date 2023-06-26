public static class Calculator
{
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return a / b;
    }

    public static double Pow(double x, int power)
    {
        if (power < 0)
        {
            throw new ArgumentException("Power must be a non-negative integer.");
        }
        double result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= x;
        }
        return result;
    }

    public static double Sqrt(double x)
    {

        if (x > 0)
        {
            double root = x / 3;
            int i;
            for (i = 0; i < 32; i++)
                root = (root + x / root) / 2;
            return root;
        }
        else
        {
            throw new ArgumentException("Number must be non-negative.");
        }
    }
}
