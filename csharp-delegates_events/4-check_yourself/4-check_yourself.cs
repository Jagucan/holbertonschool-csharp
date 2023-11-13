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

// CurrentHPArgs class
public class CurrentHPArgs : EventArgs
{
    // Properties
    public float currentHp { get; }

    // Constructor
    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
}

//Player Class
public class Player
{
    // Player Properties
    private string status;
    public string name { get; set; }
    public float maxHp { get; set; }
    public float hp { get; set; }

    // Event delegate
    public delegate void HPCheckEventHandler(object sender, CurrentHPArgs e);

    // Event
    public event HPCheckEventHandler HPCheck;

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
        this.status = $"{name} is ready to go!";

        // Subscribe CheckStatus to the HPCheck event
        HPCheck += CheckStatus;
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
            
            // Print the status
            Console.WriteLine(status);
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

        // Trigger the HPCheck event and pass hp as the CurrentHPArgs value
        HPCheck?.Invoke(this, new CurrentHPArgs(hp));
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

    // Check the HP Status
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        float currentHp = e.currentHp;

        if (currentHp == maxHp)
        {
            status = $"{name} is in perfect health!";
        }
        else if (currentHp >= maxHp / 2 && currentHp < maxHp)
        {
            status = $"{name} is doing well!";
        }
        else if (currentHp >= maxHp / 4 && currentHp < maxHp / 2)
        {
            status = $"{name} isn't doing too great...";
        }
        else if (currentHp > 0 && currentHp < maxHp / 4)
        {
            status = $"{name} needs help!";
        }
        else if (currentHp == 0)
        {
            status = $"{name} is knocked out!";
        }

        
    }
}

