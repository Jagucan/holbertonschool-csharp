﻿using System;

namespace _4_print_hexa {
    class Program {
        static void Main(string[] args) {
            for (int num = 0; num <= 99; num++) {
                if (num < 99) {
                    Console.Write("{0:D2}, ", num);
                }
                else {
                    Console.Write("{0}", num);
                }
            }
        }
    }
}