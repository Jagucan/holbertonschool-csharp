using System;

namespace _11_print_diagonal
{
    class Line
    {
        public static void PrintDiagonal(int length)
        {
            for (int item = 0; item < length; item++)
            {
                for (int space = 0; space < item; space++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("\\");
            }
            Console.WriteLine();
        }
    }
}
