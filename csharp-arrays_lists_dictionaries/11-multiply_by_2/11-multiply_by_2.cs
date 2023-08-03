using System;
using System.Collections.Generic;

class Dictionary
{
	public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
	{
		Dictionary<string, int> newDict = new Dictionary<string, int>();
		int factor = 2;

		foreach (var data in myDict)
		{
			newDict[data.Key] = data.Value * factor;
		}
		return newDict;
	}
}
