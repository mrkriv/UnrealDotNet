using System;

namespace UnrealEngine
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ManageTypeAttribute : Attribute
    {
        public string CppTypeName { get; set; }

        public ManageTypeAttribute(string cppTypeName)
        {
            CppTypeName = cppTypeName;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class BlueprintReadWriteAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class BlueprintReadOnlyAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class EditAnywhereAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class EditDefaultsOnlyAttribute : Attribute
    {
    }
}