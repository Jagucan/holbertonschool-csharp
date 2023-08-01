using System;

class Array
{
	public static int[] CreatePrint(int size)
	{
		int[] myArray = new int[size];

		if (size < 0)
		{
			Console.WriteLine("Size cannot be negative");
			return null;
		}

		if (size == 0)
		{
			Console.WriteLine();
			return myArray;
		}
		
		for (int num = 0; num < size; num++)
		{
			myArray[num] = num;
			if (num < size - 1)
			{
				Console.Write("{0} ", myArray[num]);
			}
			else
			{
				Console.WriteLine(myArray[num]);
			}
		}
		return myArray;
	}
}
