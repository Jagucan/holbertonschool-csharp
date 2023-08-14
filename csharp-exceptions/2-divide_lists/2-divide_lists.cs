using System;
using System.Collections.Generic;
class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();

        try
        {
            for (int i = 0; i < listLength; i++)
            {
                int item1 = i < list1.Count ? list1[i] : 0;
                int item2 = i < list2.Count ? list2[i] : 1;

                if (item2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                    result.Add(0);
                }
                else if (i >= list1.Count || i >= list2.Count)
                {
                    Console.WriteLine("Out of range");
                }
                else
                {
                    result.Add(item1 / item2);
                }
            }
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }

        return result;
    }
}
