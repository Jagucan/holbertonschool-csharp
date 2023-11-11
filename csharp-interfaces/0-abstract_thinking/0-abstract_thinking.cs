using System;

abstract class Base
{
    public string name;

    public override string ToString()
    {
        if (name == null)
        {
            return null;
        }
        else
        {
            return name + " is a " + GetType().Name;
        }
        
    }
}