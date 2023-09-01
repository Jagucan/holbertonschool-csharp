using System;

namespace _2_subclass
{
    class Obj
    {
        public static bool IsOnlyASubclass(Type derivedType, Type baseType)
        {
            return baseType.IsAssignableFrom(derivedType) && derivedType != baseType;
        }
    }
}
