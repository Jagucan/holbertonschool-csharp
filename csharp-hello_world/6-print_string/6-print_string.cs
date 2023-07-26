using System;

namespace _6_print_string {
    class Program {
        static void Main(string[] args) {
            string str = "Holberton School";
            string separator = " ";
            string[] tokens = str.Split(separator);
            Console.Write(str);
            Console.Write(str);
            Console.WriteLine(str);
            Console.WriteLine(String.Join(Environment.NewLine, tokens[0]));
        }
    }
}