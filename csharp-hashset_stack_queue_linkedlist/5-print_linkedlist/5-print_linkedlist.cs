﻿using System;
using System.Collections.Generic;

class LList
{
	public static LinkedList<int> CreatePrint(int size)
	{
		LinkedList<int> list = new LinkedList<int>();
        for (int num = 0; num < size; num++)
        {
            list.AddLast(num);
			Console.WriteLine(num);
        }
		return list;
	}
}
