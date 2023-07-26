using System;

namespace _9_print_specifiers {
    class Program {
        static void Main(string[] args) {
            double percent = .755322;
		    double currency = 98765.4321;
            Console.WriteLine("Percent: {0:P2}", percent);
            Console.WriteLine("Currency: {0:C}", currency);
        }
    }
}