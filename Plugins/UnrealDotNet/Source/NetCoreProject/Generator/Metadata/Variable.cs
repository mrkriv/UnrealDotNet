using System;
using System.Collections.Generic;

namespace Generator.Metadata
{
    public abstract class Variable : Primitive, IEquatable<Variable>
    {
        public bool IsConst { get; set; }
        public bool IsPointer { get; set; }
        public bool IsReference { get; set; }

        public Type Type { get; protected set; }
        public string Default { get; set; }

        protected Variable()
        {
            UMeta = new Dictionary<string, string>();
        }

        public virtual string GetTypeCS()
        {
            return Type.Name;
        }

        public virtual bool IsReadOnly()
        {
            return false;
        }

        public virtual string GetTypeCSForExtend(bool ForReturn = false)
        {
            return Type.Name;
        }

        public virtual string GetTypeCPP(bool ForReturn = false)
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

        public string GetTypeCPPOgiginal(bool NoName = false)
        {
            var result = "";

            if (IsConst)
                result += "const ";

            result += Type;

            if (IsPointer)
                result += "*";
            if (IsReference)
                result += "&";

            if (!string.IsNullOrEmpty(Name) && !NoName)
                result += " " + Name;

            return result;
        }

        public bool Equals(Variable other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return IsConst == other.IsConst && IsPointer == other.IsPointer && IsReference == other.IsReference && string.Equals(Type, other.Type);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Variable)obj);
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

        public PrimitiveVariable(string Type)
        {
            this.Type = new PrimitiveType(Type);
        }

        public override string GetTypeCS()
        {
            switch (Type.Name)
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
                    return Type.Name;
            }
        }

        public override string GetTypeCSForExtend(bool ForReturn = false)
        {
            if(!ForReturn)
                return GetTypeCS();

            switch (Type.Name)
            {
                case "FString":
                case "FText":
                case "FName":
                    return "StringWrapper";

                default:
                    return GetTypeCS();
            }
        }

        public override string GetTypeCPP(bool ForReturn = false)
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

        public override string GetTypeCPP(bool ForReturn = false)
        {
            if (((Class)Type).IsStructure)
                return "INT_PTR";
            
            if (ForReturn)
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
            return ((Class)Type).IsReadOnly;
        }

        public override string GetTypeCS()
        {
            return ((Class)Type).Name;
        }

        public override string GetTypeCSForExtend(bool ForReturn = false)
        {
            if (!((Class)Type).IsStructure && ForReturn)
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
            this.Type = Enum;
        }

        public override string GetTypeCPP(bool ForReturn = false)
        {
            return Type.Name;
        }

        public override string GetTypeCS()
        {
            return Type.Name;
        }

        public override string GetTypeCSForExtend(bool ForReturn = false)
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
        public DelegateVariable(Delegate DelegateType)
        {
            Type = DelegateType;
        }

        public override string GetTypeCPP(bool ForReturn = false)
        {
            return Type.Name;
        }

        public override bool IsReadOnly()
        {
            return false;
        }

        public override string GetTypeCS()
        {
            return Type.Name;
        }

        public override string GetTypeCSForExtend(bool ForReturn = false)
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