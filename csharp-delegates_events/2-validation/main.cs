using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Fire Fox", 640f);

        player.PrintHealth();

        player.TakeDamage(777.77f);

        player.PrintHealth();
    }
}