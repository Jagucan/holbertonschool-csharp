﻿using System;

namespace _11_concat_edges {
    class Program {
        static void Main(string[] args) {
            string str = "C# (pronounced \"See Sharp\") is a simple, modern, object-oriented, and type-safe programming language. C# has its roots in the C family of languages and will be immediately familiar to C, C++, Java, and JavaScript programmers.";
		    str = str.Substring(49, 15) + " " + str.Substring(80, 12) + str.Substring(119, 3) + str.Substring(0, 2);
		    Console.WriteLine(str);
        }
    }
}