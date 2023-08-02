using System;
using System.Collections.Generic;

class List
{
	public static List<int> CreatePrint(int size)
	{
		if (size == 0)
		{
			Console.WriteLine();
		}
		if (size < 0)
		{
			Console.WriteLine("Size cannot be negative");
			return null;
		}
		else
		{
			List<int> myList = new List<int>();

			for (int num = 0; num < size; num++)
			{
				myList.Add(num);
				if (num < size -1)
				{
					Console.Write("{0} ", num);
				}
				else
				{
					Console.WriteLine("{0}", num);
				}
			}
			return myList;
		}
	}
}
