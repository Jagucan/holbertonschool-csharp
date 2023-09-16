using System;

class VectorMath
{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        int dimensionV1 = vector1.Length;
        int dimensionV2 = vector2.Length;
        
        if ((dimensionV1 != 2 && dimensionV2 != 3) || dimensionV1 != dimensionV2)
        {
            int[] result = new int[1];
            result[0] = -1;
            return result;
        }
        else
        {
            int[] result = new int[dimensionV1];
            for (int i = 0; i < dimensionV1; i++)
            {
                result[i] = dimensionV1[i] + dimensionV2[i];
            }
            return result;
        }
    }
}
