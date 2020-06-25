using System;

namespace CefSharp.ExHelper
{
    public class ReflectionHelper
    {
        public static bool IsGenericType(Type type)
        {
            return type.IsGenericType;
        }

        public static Type GetBaseType(Type type)
        {
            return type.BaseType;
        }
    }
}