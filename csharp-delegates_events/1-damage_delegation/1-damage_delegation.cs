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

    // Method
    public void PrintHealth()
	{
		Console.WriteLine($"{name} has {hp} / {maxHp} health");
	}

    public void TakeDamage(float damage)
	{	
		if (damage < 0)
		{
			damage = 0;
			Console.WriteLine($"{name} takes 0 damage!");
		}
        else
        {
            Console.WriteLine($"{name} takes {damage} damage!");
        }
    }

    public void HealDamage(float heal)
	{		
		if (heal < 0)
		{
			heal = 0;
            Console.WriteLine($"{name} heals 0 HP!");
        }
        else
        {
            Console.WriteLine($"{name} heals {heal} HP!");
        }
    }
}
