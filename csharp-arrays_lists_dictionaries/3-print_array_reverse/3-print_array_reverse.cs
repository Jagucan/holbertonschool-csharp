using System;
using System.Linq;

class Array
{
	public static void Reverse(int[] array)
	{
		if (array == null)
		{
			Console.WriteLine();
			return;
		}
		
		int[] reverse = Enumerable.Reverse(array).ToArray();
		
		if (reverse.Length >= array.Length - 1)
		{
			Console.WriteLine(String.Join(" ", reverse));
		}
		else
		{
			Console.WriteLine(String.Join("", reverse));  
		}	
	}
}
