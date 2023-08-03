using System;
using System.Collections.Generic;

class List
{
	public static int Sum(List<int> myList)
	{
        int sum = 0;
        HashSet<int> uniqueNumbers = new HashSet<int>();

        foreach (var num in myList)
        {
            if (!uniqueNumbers.Contains(num))
            {
                sum += num;
                uniqueNumbers.Add(num);
            }
        }

        return sum;
	}
}
