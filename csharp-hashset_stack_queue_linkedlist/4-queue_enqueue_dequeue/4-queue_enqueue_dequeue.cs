using System;
using System.Collections.Generic;

class MyQueue
{
	public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
	{
		if (aQueue == null)
        {
            Console.WriteLine("Queue is empty");
        }

        else if (aQueue.Count == 0)
		{
			bool containsSearch = aQueue.Contains(search);
			Console.WriteLine("Number of items: {0}", aQueue.Count);
            Console.WriteLine("Queue is empty");
			Console.WriteLine("Queue contains \"{0}\": {1}", search, containsSearch);
			aQueue.Enqueue(newItem);
        }

		else
        {
            Console.WriteLine("Number of items: {0}", aQueue.Count);
            Console.WriteLine("Top item: {0}", aQueue.Peek());

            bool containsSearch = aQueue.Contains(search);
            Console.WriteLine("Queue contains \"{0}\": {1}", search, containsSearch);

            if (containsSearch)
            {
                Queue<string> tempQueue = new Queue<string>();
                string currentItem;

                do
                {
                    currentItem = aQueue.Dequeue();
                } while (currentItem != search && aQueue.Count > 0);
            }

            aQueue.Enqueue(newItem);
        }

        return aQueue;
	}
}
