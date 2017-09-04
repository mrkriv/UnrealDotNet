using System;
using System.Collections.Generic;

namespace Generator.Metadata
{
    public class Enum : Type
    {
        public List<Field> Fields { get; set; }

        public class Field : Primitive
        {
            public string Value { get; set; }

            public override string ToString()
            {
                return string.IsNullOrEmpty(Value) ? Name : $"{Name} ({Value})";
            }
        }

        public Enum(string Name)
        {
            Fields = new List<Field>();

            var i = Name.IndexOf(":", StringComparison.Ordinal);
            this.Name = i != -1 ? Name.Substring(0, i) : Name;
        }
    }
}