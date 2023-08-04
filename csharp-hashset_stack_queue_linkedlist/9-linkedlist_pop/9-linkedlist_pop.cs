﻿using System;
using System.Collections.Generic;

class LList
{
	public static int Pop(LinkedList<int> myLList)
	{
		int headNode = myLList.First.Value;

		if (myLList.Count == 0)
        {
            return 0;
        }
        else
        {
			myLList.RemoveFirst();
            return headNode;
        }
	}
}
