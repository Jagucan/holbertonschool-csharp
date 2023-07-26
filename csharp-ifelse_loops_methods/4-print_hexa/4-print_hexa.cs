using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseHex = 16;
            for (int num = 0; num <= 98; num++)
            {
                string hex = Convert.ToString(num, baseHex);
                Console.Write("{0} = 0x{1}\n", num, hex);
            }
        }
    }
}
