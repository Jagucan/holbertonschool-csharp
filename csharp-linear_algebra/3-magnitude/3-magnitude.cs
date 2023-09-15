using System;

public class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        int dimension = vector.Length;

        if (dimension == 2 || dimension == 3)
        {
            double sumOfSquares = 0.0;

            foreach (double component in vector)
            {
                sumOfSquares += component * component;
            }

            double magnitude = Math.Sqrt(sumOfSquares);
            magnitude = Math.Round(magnitude, 2);
            
            return magnitude;
        }
        else
        {
            return -1;
        }
    }
}
