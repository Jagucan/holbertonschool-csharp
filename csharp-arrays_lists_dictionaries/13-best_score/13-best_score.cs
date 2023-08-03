using System;
using System.Collections.Generic;

class Dictionary
{
	public static string BestScore(Dictionary<string, int> myList)
	{
		if (myList == null || myList.Count == 0)
		{
			return "None";
		}
		KeyValuePair<string,int> max = new KeyValuePair<string,int>(); 
		foreach (var entry in myList) {
			if (entry.Value > max.Value) {
				max = entry;
			}
		}
		return max.Key;
	}
}
