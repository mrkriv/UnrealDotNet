using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeGenerator.Metadata
{
    public abstract class Variable : Primitive, IEquatable<Variable>
    {
        protected Variable()
        {
            UMeta = new Dictionary<string, string>();
        }

        public bool IsConst { get; set; }
        public bool IsStatic { get; set; }
        public bool IsPointer { get; set; }
        public bool IsReference { get; set; }
        public bool IsArray { get; set; }
        public int ArrayLenght { get; set; }
        public Class OwnerClass { get; set; }
        public override bool IsTemplate => base.IsTemplate || Type.IsTemplate;

        public Type Type { get; protected set; }
        public string Default { get; set; }

        public bool Equals(Variable other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return IsConst == other.IsConst && IsPointer == other.IsPointer && IsReference == other.IsReference &&
                   Equals(Type, other.Type);
        }

        public virtual string GetTypeCs()
        {
            return Type.Name;
        }

        public virtual bool IsReadOnly()
        {
            return false;
        }

        public virtual string GetTypeCsForExtend(bool forReturn = false)
        {
            return Type.Name;
        }

        public virtual string GetTypeCpp(bool forReturn = false)
        {
            return Type.Name;
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

        public string GetTypeCppOgiginal(bool noName = false)
        {
            var result = "";

            if (IsConst)
                result += "const ";

            if (IsTemplate)
            {
                result += Type.Name.Substring(0, Type.Name.IndexOf("__", StringComparison.Ordinal));
                result += "<" + string.Join(", ", Type.TemplateTypes.Select(x => x.GetTypeCppOgiginal(noName))) + ">";
            }
            else
            {
                result += Type.Name;
            }

            if (IsPointer)
                result += "*";
            else if (IsReference)
                result += "&";

            if (!string.IsNullOrEmpty(Name) && !noName)
                result += " " + Name;

            return result;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Variable) obj);
        }

        public override int GetHashCode()
        {
            var hashCode = -1979447941;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type.Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
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
            "FText",
            "FName",
            "string",
            "float",
            "double",
            "char",
            "byte",
            "IntPtr"
        };

        public PrimitiveVariable(string type)
        {
            Type = new PrimitiveType(type);
        }

        public override string GetTypeCs()
        {
            switch (Type.Name)
            {
                case "uint8":
                    return "byte";

                case "int32":
                    return "int";

                case "int16":
                    return "short";

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
                    return Type.Name;
            }
        }

        public override string GetTypeCsForExtend(bool forReturn = false)
        {
            if (!forReturn)
                return GetTypeCs();

            switch (Type.Name)
            {
                case "FString":
                case "FText":
                case "FName":
                    return "StringWrapper";

                default:
                    return GetTypeCs();
            }
        }

        public override string GetTypeCpp(bool forReturn = false)
        {
            switch (Type.Name)
            {
                case "FString":
                case "FText":
                case "FName":
                    return "char*";

                default:
                    return Type.Name;
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
        public ClassVariable(Class Class)
        {
            Type = Class;
        }

        public override string GetTypeCpp(bool forReturn = false)
        {
            if (IsTemplate) return forReturn ? "TemplatePointerDescription" : "INT_PTR";

            if (((Class) Type).IsStructure)
                return "INT_PTR";

            if (forReturn)
                return "ObjectPointerDescription";

            var name = Type.Name;

            if (IsReference)
                return name + "&";

            if (IsPointer)
                return name + "*";

            return name;
        }

        public override bool IsReadOnly()
        {
            return ((Class) Type).IsReadOnly;
        }

        public override string GetTypeCs()
        {
            if (IsTemplate)
            {
                var baseName = Type.Name.Substring(0, Type.Name.IndexOf("__", StringComparison.Ordinal));
                baseName += "<";

                foreach (var type in Type.TemplateTypes) baseName += type.GetTypeCs();

                baseName += ">";

                return baseName;
            }

            return ((Class) Type).Name;
        }

        public override string GetTypeCsForExtend(bool forReturn = false)
        {
            if (IsTemplate && forReturn)
                return "TemplatePointerDescription";

            if (!((Class) Type).IsStructure && forReturn)
                return "ObjectPointerDescription";

            return "IntPtr";
        }

        public override string ToString()
        {
            var b = base.ToString();
            return string.IsNullOrEmpty(Name) ? b + Type : $"{b}{Type} {Name}";
        }
    }

    public class EnumVariable : Variable
    {
        public EnumVariable(Enum Enum)
        {
            Type = Enum;
        }

        public override string GetTypeCpp(bool forReturn = false)
        {
            return Type.Name;
        }

        public override string GetTypeCs()
        {
            return Type.Name;
        }

        public override string GetTypeCsForExtend(bool forReturn = false)
        {
            return "byte";
        }

        public override string ToString()
        {
            var b = base.ToString();
            return string.IsNullOrEmpty(Name) ? b + Type : $"{b}{Type} {Name}";
        }
    }

    public class DelegateVariable : Variable
    {
        public DelegateVariable(Delegate delegateType)
        {
            Type = delegateType;
        }

        public override string GetTypeCpp(bool forReturn = false)
        {
            return Type.Name;
        }

        public override bool IsReadOnly()
        {
            return false;
        }

        public override string GetTypeCs()
        {
            return Type.Name;
        }

        public override string GetTypeCsForExtend(bool forReturn = false)
        {
            return Type.Name;
        }

        public override string ToString()
        {
            var b = base.ToString();
            return string.IsNullOrEmpty(Name) ? b + Type : $"{b}{Type} {Name}";
        }
    }
}