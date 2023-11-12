using System;

public class Player
{
    // Properties
    public string name { get; set; }
    public float maxHp { get; set; }
    public float hp { get; set; }

    // Constructor
    public Player(string name = "Player", float maxHp = 100f)
    {
        // Default maxHp: 100f
        if (maxHp <= 0f)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }

        // Assign parameters to properties
        this.name = name;
        this.maxHp = maxHp;
        this.hp = this.maxHp;
    }

    // Method
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}
