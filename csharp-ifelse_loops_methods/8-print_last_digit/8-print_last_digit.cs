using System;

namespace _8_print_last_digit
{
    class Number
    {
        public static int PrintLastDigit(int number)
        {
            int positiveNum = 0;
            int lastDigit = number % 10;

            if (number < 0)
            {
                positiveNum = lastDigit * -1;
                Console.Write(positiveNum);
                return positiveNum;
            }
            else
            {
                Console.Write(lastDigit);
                return lastDigit;
            }
        }
    }
}

