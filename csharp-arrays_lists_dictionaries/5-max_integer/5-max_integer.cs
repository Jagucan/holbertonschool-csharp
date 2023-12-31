﻿using System;
using System.Collections.Generic;

class List
{
	public static int MaxInteger(List<int> myList)
	{
		if (myList == null || myList.Count == 0)
		{
			Console.WriteLine("List is empty");
			return -1;
		}
		int num = 0;
		int maxNum = 0;
		int contList = myList.Count;

		for (int item = 0; item < contList; item++)
		{
				num = myList[item];

				if (maxNum < num)
				{
					maxNum = num;
				}
		}
		if (num < 0)
		{
			return -1;
		}
		else
		{
			return maxNum;
		}
	}
}
