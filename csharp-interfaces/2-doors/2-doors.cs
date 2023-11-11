using System;

abstract class Base
{
    public string name { get; set; }

    public override string ToString()
    {
        if (name == null)
        {
            return "is a " + GetType().Name;
        }
        else
        {
            return name + " is a " + GetType().Name;
        }

    }
}

interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability { get; set; }
    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

class Door : Base, IInteractive
{
    public Door(string name = null)
    {
        if (name == null)
        {
            this.name = "Door";
        }
        else
        {
            this.name = name;
        }
    }

    public void Interact()
    {
        // Interact Implementation
        Console.WriteLine("You try to open the " + name + ". It's locked.");
    }
}