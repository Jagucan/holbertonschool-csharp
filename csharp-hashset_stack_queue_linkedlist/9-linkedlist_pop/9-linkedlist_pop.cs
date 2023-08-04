using System;
using System.Collections.Generic;

class LList
{
	public static int Pop(LinkedList<int> myLList)
	{
		int headNode = 0;

		if (myLList.Count == 0)	
        {
            return 0;
        }

        else
        {
			headNode = myLList.First.Value;
			myLList.RemoveFirst();
            return headNode;
        }
	}
}
