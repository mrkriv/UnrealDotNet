using System;
using System.Reflection;

namespace UnrealEngine
{
    public class PropertyConvert
    {
        public static bool CanEditPropertyInEditor(PropertyInfo p)
        {
            return p.CanWrite;
        }

        public static bool FilterPropertyForEditor(PropertyInfo p)
        {
            var attribute1 = p.GetCustomAttribute<EditAnywhereAttribute>();
            var attribute2 = p.GetCustomAttribute<EditDefaultsOnlyAttribute>();

            var isBlueprint = attribute1 != null || attribute2 != null;
            var isPrimitive = Type.GetTypeCode(p.PropertyType) != TypeCode.Object;

            return isPrimitive && isBlueprint;
        }
    }
}