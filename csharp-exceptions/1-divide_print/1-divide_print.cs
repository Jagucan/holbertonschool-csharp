using System;
using System.Collections.Generic;

class Int
{
    public static void divide(int a, int b)
    {
        int div = 0;

        try
        {
            div = a / b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            if (b != 0)
            {
                div = a / b;
                Console.WriteLine("{0} / {1} = {2}", a, b, div);
            }
            else
            {
                Console.WriteLine("{0} / {1} = 0", a, b);
            }
        }
    }
}