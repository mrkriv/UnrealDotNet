using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeGenerator.Metadata
{
    public enum AccessModifier
    {
        Private,
        Protected,
        Public
    }

    public class Method : Primitive, IEquatable<Method>
    {
        public Method(string name)
        {
            ReturnType = new PrimitiveVariable("void");
            InputTypes = new List<Variable>();
            Name = name;
        }

        public Variable ReturnType { get; set; }
        public List<Variable> InputTypes { get; set; }
        public Class OwnerClass { get; set; }
        public bool IsConst { get; set; }
        public bool IsFinal { get; set; }
        public bool IsStatic { get; set; }
        public bool IsFriend { get; set; }
        public bool IsVirtual { get; set; }
        public bool IsOverride { get; set; }
        public string Operator { get; set; }
        public int OverloadIndex { get; set; }

        public IEnumerable<Type> Dependent
        {
            get { return InputTypes.Concat(new[] {ReturnType}).Select(x => x.Type).Distinct(); }
        }

        public bool Equals(Method other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            if (Name != other.Name ||
                !EqualsInputTypes(other) ||
                !Equals(ReturnType, other.ReturnType) ||
                !Equals(OwnerClass, other.OwnerClass) ||
                IsConst != other.IsConst ||
                IsTemplate != other.IsTemplate)
                return false;

            return true;
        }

        public override string ToString()
        {
            return $"{ReturnType} {Name} ({string.Join(',', InputTypes)})";
        }

        public bool EqualsInputTypes(Method other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            if (InputTypes.Count != other.InputTypes.Count) return false;

            if (InputTypes.Where((t, i) => !t.Equals(other.InputTypes[i])).Any()) return false;

            return true;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Method) obj);
        }

        public override int GetHashCode()
        {
            var hashCode = -1034007683;
            hashCode = hashCode * -1521134295 + EqualityComparer<Variable>.Default.GetHashCode(ReturnType);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Variable>>.Default.GetHashCode(InputTypes);
            hashCode = hashCode * -1521134295 + EqualityComparer<Class>.Default.GetHashCode(OwnerClass);
            hashCode = hashCode * -1521134295 + IsConst.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }
    }
}