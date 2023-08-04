using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        if (aStack == null)
        {
            Console.WriteLine("Stack is empty");
        }

        else if (aStack.Count == 0)
		{
			bool containsSearch = aStack.Contains(search);
			Console.WriteLine("Number of items: {0}", aStack.Count);
            Console.WriteLine("Stack is empty");
			Console.WriteLine("Stack contains \"{0}\": {1}", search, containsSearch);
			aStack.Push(newItem);
        }

		else
        {
            Console.WriteLine("Number of items: {0}", aStack.Count);
            Console.WriteLine("Top item: {0}", aStack.Peek());

            bool containsSearch = aStack.Contains(search);
            Console.WriteLine("Stack contains \"{0}\": {1}", search, containsSearch);

            if (containsSearch)
            {
                Stack<string> tempStack = new Stack<string>();
                string currentItem;

                do
                {
                    currentItem = aStack.Pop();
                } while (currentItem != search && aStack.Count > 0);
            }

            aStack.Push(newItem);
        }

        return aStack;
    }
}
