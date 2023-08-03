using System;
using System.Collections.Generic;

class List
{
	public static List<int> CommonElements(List<int> list1, List<int> list2)
	{
		HashSet<int> commonNumbers = new HashSet<int>();
        foreach (var num in list1)
        {
            if (list2.Contains(num))
            {
                commonNumbers.Add(num);
            }
        }

        return new List<int>(commonNumbers);
	}
}