using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        LinkedListNode<int> currentNode = myLList.First;
		int nodePosition = 0;

        while (currentNode != null)
        {
            if (currentNode.Value == value)
            {
                return nodePosition;
            }

            currentNode = currentNode.Next;
			nodePosition++;
        }

        return -1;
    }
}
