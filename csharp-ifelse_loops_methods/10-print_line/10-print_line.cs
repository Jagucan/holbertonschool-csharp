using System;

namespace _10_print_line
{
    class Line
    {
        public static void PrintLine(int length)
        {
            for (int item = 0; item < length; item++)
            {
                Console.Write("_");
            }
            Console.WriteLine();
        }
    }
}
