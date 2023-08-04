using System;
using System.Collections.Generic;

class List
{
	public static List<int> DifferentElements(List<int> list1, List<int> list2)
	{
		HashSet<int> uniqueNumbers1 = new HashSet<int>(list1);
        HashSet<int> uniqueNumbers2 = new HashSet<int>(list2);

        uniqueNumbers1.SymmetricExceptWith(uniqueNumbers2);

        List<int> result = new List<int>(uniqueNumbers1);
        result.Sort();

        return result;
	}
}
