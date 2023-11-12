using System;

// Modifier
public enum Modifier
{
    Weak,
    Base, 
    Strong
}

// Delegate
public delegate float CalculateModifier(float baseValue, Modifier modifier);


//Player Class
public class Player
{
    // Player Properties
    public string name { get; set; }
    public float maxHp { get; set; }
    public float hp { get; set; }

    // Player Constructor
    public Player(string name = "Player", float maxHp = 100f)
    {
        // Default maxHp: 100f
        if (maxHp <= 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
        }

        // Assign parameters to properties
        this.name = name;
        this.hp = this.maxHp;
    }

    // Delegate
    delegate float CalculateHealth();

    // Methods
    // Print The Healt
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    // Calculate the Damage Received 
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0;
            Console.WriteLine($"{name} takes 0 damage!");
        }
        else
        {
            ValidateHP(hp - damage);
            Console.WriteLine($"{name} takes {damage} damage!");
        }
    }

    // Calculate the Healed Damage
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
            Console.WriteLine($"{name} heals 0 HP!");
        }
        else
        {
            ValidateHP(hp + heal);
            Console.WriteLine($"{name} heals {heal} HP!");
        }
    }

    // Calculate de Current HP
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            hp = 0;
        }
        else if (newHp > maxHp)
        {
            hp = maxHp;
        }
        else
        {
            hp = newHp;
        }
    }

    // Apply the Modifier Value
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
        {
            return baseValue * 0.5f;
        }

        if (modifier == Modifier.Base)
        {
            return baseValue;
        }

        if (modifier == Modifier.Strong)
        {
            return baseValue * 1.5f;
        }
        return baseValue;
    }
}
