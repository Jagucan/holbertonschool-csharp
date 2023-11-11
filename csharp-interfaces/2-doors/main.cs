using System;

class Program
{
    static void Main(string[] args)
    {
        Door trapDoor = new Door();

        Console.WriteLine(trapDoor.ToString());

        trapDoor.Interact();
    }
}