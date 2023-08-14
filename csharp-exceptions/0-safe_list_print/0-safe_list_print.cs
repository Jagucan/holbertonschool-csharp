using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int nums = 0;

        for (int i = 0; i < myList.Count && nums < n; i++)
        {
            Console.WriteLine(myList[i]);
            nums++;
        }
        
        return nums;
    }
}

