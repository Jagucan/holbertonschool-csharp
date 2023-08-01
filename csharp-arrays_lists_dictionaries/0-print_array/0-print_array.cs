using System;

class Array
{
	public static int[] CreatePrint(int size)
	{
		
		if (size == 0)
		{
			Console.WriteLine();
			return new int[0];
		}
		else if (size < 0)
		{
			Console.WriteLine("Size cannot be negative");
			return null;
		}
		else
		{
			int[] myArray = new int[size];

			for (int num = 0; num < size; num++)
			{
				myArray[num] = num;
				if (num < size -1)
				{
					Console.Write("{0} ", myArray[num]);
				}
				else
				{
					Console.Write("{0}", myArray[num]);
				}
			}
			Console.WriteLine();
			return myArray;
		}
	}
}

