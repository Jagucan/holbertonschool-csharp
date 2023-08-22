using System;

namespace MyMath
{
    public class Matrix
    {
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }

            if (matrix == null)
            {
                return null;
            }

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int[,] result = new int[rows, columns];

            try
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        result[i, j] = matrix[i, j] / num;
                    }
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Divide by zero.");
                return null;
            }

            return result;
        }
    }
}
