using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = 0;
            string output = "";

            for (int firstDigit = 0; firstDigit <= 9; firstDigit++)
            {
                for (int secondDigit = firstDigit + 1; secondDigit <= 9; secondDigit++)
                {
                    nums = firstDigit * 10 + secondDigit;
                    if (nums < 89)
                    {
                        output += $"{nums:D2}, ";
                    }
                    else
                    {
                        output += $"{nums:D2}";
                        break;
                    }
                }
            }

            Console.Write(output);
        }
    }
}
