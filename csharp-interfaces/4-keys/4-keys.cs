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
        this.name = name;
    }

    public void Interact()
    {
        // Interact Implementation
        Console.WriteLine("You try to open the " + name + ". It's locked.");
    }
}

class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem { get; set; }
    public int durability { get; set; }

    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new ArgumentException("Durability must be greater than 0");
        }

        this.name = name;
        this.isQuestItem = isQuestItem;
        this.durability = durability;
    }

    public void Interact()
    {
        // Interact Implementation
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (isQuestItem)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        else
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }

    public void Break()
    {
        // Break Implementation
        durability--;

        if (durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        else if (durability < 0)
        {
            Console.WriteLine($"The {name} is already broken.");
        }
        else
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
    }
}

class Key : Base, ICollectable
{
    public bool isCollected { get; set; }

    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    public void Collect()
    {
        if (!isCollected)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}

