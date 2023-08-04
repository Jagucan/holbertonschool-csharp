using System;
using System.Collections.Generic;

class LList
{
	public static int GetNode(LinkedList<int> myLList, int n)
	{
		int nodePosistion = 0;
		foreach (int i in myLList)
		{
			nodePosistion++;
			if (nodePosistion == n + 1)
			{
				return i;
			}
		}
		return 0;
	}
}
