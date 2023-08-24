using System;
using System.Collections.Generic;

namespace Text
{
    public class Str
    {
        public static int UniqueChar(string s)
        {
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            foreach (char character in s)
            {
                if (charCounts.ContainsKey(character))
                {
                    charCounts[character]++;
                }
                else
                {
                    charCounts[character] = 1;
                }
            }

            for (int stringLetters = 0; stringLetters < s.Length; stringLetters++)
            {
                if (charCounts[s[stringLetters]] == 1)
                {
                    return stringLetters;
                }
            }

            return -1;
        }
    }
}
