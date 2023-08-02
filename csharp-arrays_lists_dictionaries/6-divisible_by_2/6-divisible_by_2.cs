using System;
using System.Collections.Generic;

class List
{
	public static List<bool> DivisibleBy2(List<int> myList)
	{
		List<bool> result = new List<bool>();

        foreach (int num in myList)
        {
            bool numDiv2 = num % 2 == 0;
            result.Add(numDiv2);
        }
        return result;
	}
}
