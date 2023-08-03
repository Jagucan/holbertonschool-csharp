using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
	public static void PrintSorted(Dictionary<string, string> myDict)
	{
		List<KeyValuePair<string, string>> sortedList = myDict.ToList();

        sortedList.Sort((pair1, pair2) => pair1.Key.CompareTo(pair2.Key));

        foreach (var data in sortedList)
        {
            Console.WriteLine("{0}: {1}", data.Key, data.Value);
        }
	}
}
