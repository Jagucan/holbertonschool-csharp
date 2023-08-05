using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[,] array = new int[5, 5];

        for (int row = 0; row < 5; row++)
        {
            for (int column = 0; column < 5; column++)
            {
                array[row, column] = 0;
            }
        }

        array[2, 2] = 1;
    
        for (int row = 0; row < 5; row++)
        {
            for (int column = 0; column < 5; column++)
            {
                if (array[row, column] < 50)
                {
                    Console.Write(array[row, column] + " ");
                }
                else
                {
                    Console.Write(array[row, column] + "");
                }
                
            }
            Console.WriteLine();
        }
    }
}
