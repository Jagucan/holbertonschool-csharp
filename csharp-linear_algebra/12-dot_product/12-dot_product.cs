using System;

class VectorMath
{
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        int dimensionV1 = vector1.Length;
        int dimensionV2 = vector2.Length;
            
        if ((dimensionV1 != 2 && dimensionV2 != 3) || dimensionV1 != dimensionV2)
        {
            double result = -1;
            return result;
        }

        else
        {
            double[] productVectors = new double[dimensionV1];
            double result = 0;
            for (int i = 0; i < dimensionV1; i++)
            {
                productVectors[i] = vector1[i] * vector2[i];
                result += productVectors[i];
            }
            return result;
        }
    }
}
