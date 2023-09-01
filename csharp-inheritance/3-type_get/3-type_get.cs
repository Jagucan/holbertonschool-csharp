using System;
using System.Reflection;

public class Obj
{
    public static void Print(object myObj)
    {
        Type objectType = myObj.GetType();
        
        Console.WriteLine($"Properties and Methods of {objectType.Name}:");

        foreach (MemberInfo member in objectType.GetMembers())
        {
            Console.WriteLine(member.Name);
        }
    }
}

