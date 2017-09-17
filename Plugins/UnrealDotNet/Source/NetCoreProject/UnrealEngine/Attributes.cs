using System;
using System.Collections.Generic;
using System.Text;

namespace UnrealEngine
{
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
