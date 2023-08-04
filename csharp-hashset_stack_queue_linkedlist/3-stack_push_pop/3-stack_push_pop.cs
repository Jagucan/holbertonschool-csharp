using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        if (aStack.Count == 0 || aStack == null)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine("Number of items: {0}", aStack.Count);
            Console.WriteLine("Top item: {0}", aStack.Peek());

            bool containsSearch = aStack.Contains(search);
            Console.WriteLine("Stack contains {0}: {1}", search, containsSearch);

            if (containsSearch)
            {
                Stack<string> tempStack = new Stack<string>();
                string currentItem;

                do
                {
                    currentItem = aStack.Pop();
                } while (currentItem != search && aStack.Count > 0);

                while (tempStack.Count > 0)
                {
                    aStack.Push(tempStack.Pop());
                }
            }

            aStack.Push(newItem);
        }

        return aStack;
    }
}
