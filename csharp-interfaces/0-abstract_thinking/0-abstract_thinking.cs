using System;

abstract class Base
{
    public string name = string.Empty;

    public override string ToString()
    {
        if (name == null)
        {
            return "is a " +  GetType().Name;
        }
        else
        {
            return name + " is a " + GetType().Name;
        }
        
    }
}