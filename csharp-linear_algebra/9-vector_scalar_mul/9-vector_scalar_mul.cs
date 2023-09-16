using System;

class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        int dimension = vector.Length;

        if (dimension != 2 && dimension != 3)
        {
            double[] result = new double[1];
            result[0] = -1;
            return result;
        }
        else
        {
            double[] result = new double[dimension];
            for (int i = 0; i < dimension; i++)
            {
                result[i] = vector[i] * scalar;
            }
            return result;
        }
    }
}
