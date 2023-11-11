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

class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem { get; set; }
    public int durability { get; set; }

    public Decoration(string name = null, int durability = 1, bool isQuestItem = false)
    {
        if (name == null)
        {
            this.name = "Decoration";
        }
        else
        {
            this.name = name;
        }

        if (durability <= 0)
        {
            throw new ArgumentException("Durability must be greater than 0");
        }
        else
        {
            this.durability = durability;
        }

        this.isQuestItem = isQuestItem;
    }

    public void Interact()
    {
        // Interact Implementation
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }

        if (isQuestItem == true)
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
