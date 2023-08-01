using System;

class Array
{
	public static int[] CreatePrint(int size)
	{
		int[] myArray = new int[size];

		if (size == 0)
		{
			Console.WriteLine();
			return myArray;
		}
		else if (size < 0)
		{
			Console.Write("Size cannot be negative");
			return null;
		}
		else
		{
			for (int num = 0; num < size; num++)
			{
				myArray[num] = num;
				Console.Write("{0} ", myArray[num]);
			}
			Console.WriteLine();
			return myArray;
		}
	}
}
