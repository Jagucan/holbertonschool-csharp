using System;

class Program
{
    static void Main(string[] args)
    {
        Decoration teacup = new Decoration("Teacup", 1, false);

        Console.WriteLine(teacup.ToString());

        teacup.Interact();
        teacup.Break();
        teacup.Break();
        teacup.Interact();
        Console.WriteLine("isQuestItem: " + teacup.isQuestItem);
    }
}