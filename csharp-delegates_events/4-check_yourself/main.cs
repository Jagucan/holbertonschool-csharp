using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Floppy Fish");
        CalculateModifier mod = new CalculateModifier(player.ApplyModifier);

        player.PrintHealth();
        Console.WriteLine();

        player.TakeDamage(mod(99f, Modifier.Base));
        player.PrintHealth();
    }
}