using System;

namespace Text
{
    public class Str
    {
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            int charCount = 1;
            foreach (char character in s)
            {
                if (char.IsUpper(character))
                {
                    charCount++;
                }
            }
            return charCount;
        }
    }
}
