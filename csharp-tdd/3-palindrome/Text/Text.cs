﻿using System;
using System.Text.RegularExpressions;

namespace Text
{
    public class Str
    {
        public static bool IsPalindrome(string s)
        {
            string cleanedString = Regex.Replace(s, @"[^a-zA-Z0-9]", "").ToLower();

            int left = 0;
            int right = cleanedString.Length - 1;

            while (left < right)
            {
                if (cleanedString[left] != cleanedString[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}