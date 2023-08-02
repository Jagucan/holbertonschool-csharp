using System;
using System.Collections.Generic;

class List
{
    public static void DeleteAt(List<int> myList, int index)
    {
        if (index >= 0 && index < myList.Count)
        {
            List<int> newList = new List<int>();

            for (int num = 0; num < myList.Count; num++)
            {
                if (num != index)
                {
                    newList.Add(myList[num]);
                }
            }

            myList.Clear();
            myList.AddRange(newList);
        }
        else
        {
            Console.WriteLine("Index is out of range");
        }
    }
}
