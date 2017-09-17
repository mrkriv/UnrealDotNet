using System;
using System.Collections.Generic;
using System.Text;

namespace UnrealEngine
{
    public class FDotnetTypeName
    {
        public string FullName { get; set; }

        public FDotnetPropertyValue[] PropertyValue { get; set; }
    }

    public class FDotnetPropertyValue
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}