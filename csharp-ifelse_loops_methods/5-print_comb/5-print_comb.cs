using System;

namespace _4_print_hexa {
    class Program {
        static void Main(string[] args) {
            string[] numbers = new string[100];
            for (int num = 0; num <= 99; num++) {
                numbers[num] = num.ToString("D2");
            }
            string result = string.Join(", ", numbers);
            Console.Write(result);
        }
    }
}