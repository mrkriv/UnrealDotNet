using System;

namespace Generator.Metadata
{
    public abstract class Variable
    {
        public bool IsConst { get; set; }
        public bool IsPointer { get; set; }
        public bool IsReference { get; set; }
        public bool IsVoid => Type == "void";

        public string Type { get; protected set; }
        public string Name { get; set; }

        public override string ToString()
        {
            var result = "";

            if (IsConst)
                result += "const ";
            if (IsPointer)
                result += "ptr ";
            if (IsReference)
                result += "ref ";

            return result;
        }
    }

    public class PrimitiveVariable : Variable
    {
        public static readonly string[] PrimitiveTypes =
        {
            "void",
            "int",
            "uint8",
            "int16",
            "int32",
            "int64",
            "bool",
            "FString",
            "FName",
            "string",
            "float",
            "double",
            "char",
            "byte",
            "IntPtr"
        };

        public PrimitiveVariable(string Type)
        {
            this.Type = Type;
        }

        public override string ToString()
        {
            var b = base.ToString();
            return string.IsNullOrEmpty(Name) ? b + Type : $"{b}{Type} {Name}";
        }
    }

    public class ClassVariable : Variable
    {
        public Class ClassType { get; }

        public ClassVariable(Class ClassType)
        {
            this.ClassType = ClassType;
            this.Type = ClassType.Name;
        }

        public override string ToString()
        {
            var b = base.ToString();
            return string.IsNullOrEmpty(Name) ? b + ClassType : $"{b}{ClassType} {Name}";
        }
    }
}