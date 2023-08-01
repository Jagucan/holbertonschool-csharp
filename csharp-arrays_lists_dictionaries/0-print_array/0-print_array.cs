﻿using System;

namespace _0_print_array
{
    class Array
    {
        public static int[] CreatePrint(int size)
        {
            if (size == 0)
            {
                Console.WriteLine();
                return new int[0];
            }
            else if (size < 0)
            {
                Console.Write("Size cannot be negative");
                return null;
            }
            else
            {
                int[] newArray = new int[size];

                for (int num = 0; num < size; num++)
                {
                    newArray[num] = num;
                    Console.Write("{0} ", newArray[num]);
                }
                Console.WriteLine();
                return newArray;
            }
        }
    }
}
