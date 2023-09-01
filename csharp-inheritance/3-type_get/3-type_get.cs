using System;
using System.Reflection;

public class Obj
{
    public static void Print(object myObj)
    {
        Type int32Type = typeof(Int32);
        Console.WriteLine($"{int32Type.Name} Properties:");
        Console.WriteLine($"{int32Type.Name} Methods:");
        foreach (MemberInfo member in int32Type.GetMembers())
        {
            Console.WriteLine(member.Name);
        }

        Type objectType = myObj.GetType();
        Console.WriteLine($"{objectType.Name} Properties:");
        foreach (MemberInfo member in objectType.GetMembers())
        {
            if (member is PropertyInfo property && property.PropertyType == typeof(int))
            {
                Console.WriteLine(property.Name);
            }
        }
        Console.WriteLine($"{objectType.Name} Methods:");
        foreach (MemberInfo member in objectType.GetMembers())
        {
            if (member is MethodInfo method && method.ReturnType == typeof(int))
            {
                Console.WriteLine(method.Name);
            }
        }
    }
}
