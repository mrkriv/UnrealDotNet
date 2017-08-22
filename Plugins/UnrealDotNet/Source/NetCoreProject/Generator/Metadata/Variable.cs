using System;
using System.Reflection;

namespace Generator.Metadata
{
    public abstract class Variable
    {
        public bool IsConst { get; set; }
        public bool IsPointer { get; set; }
        public bool IsReference { get; set; }
        public bool IsVoid => Type == "void";

        public string Type { get; protected set; }
        public string Default { get; set; }
        public string Name { get; set; }

        public virtual string GetTypeCS()
        {
            return Type;
        }

        public virtual string GetTypeCPP()
        {
            return Type;
        }

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

        public override string GetTypeCS()
        {
            switch (Type)
            {
                case "uint8":
                    return "byte";

                case "int32":
                    return "int";

                case "uint32":
                    return "uint";

                case "int64":
                    return "long";

                case "uint64":
                    return "ulong";

                case "FString":
                case "FText":
                case "FName":
                    return "string";

                case "INT_PTR":
                    return "IntPtr";

                default:
                    return Type;
            }
        }

        public override string GetTypeCPP()
        {
            switch (Type)
            {
                case "FString":
                case "FText":
                case "FName":
                    return "char*";

                default:
                    return Type;
            }
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

        public override string GetTypeCPP()
        {
            if (IsReference)
                return ClassType.Name + "&";

            if (IsPointer)
                return ClassType.Name + "*";

            return ClassType.Name;
        }

        public override string ToString()
        {
            var b = base.ToString();
            return string.IsNullOrEmpty(Name) ? b + ClassType : $"{b}{ClassType} {Name}";
        }
    }
}