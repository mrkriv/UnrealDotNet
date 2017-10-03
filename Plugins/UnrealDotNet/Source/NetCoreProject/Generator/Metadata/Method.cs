using System;
using System.Collections.Generic;
using System.Linq;

namespace Generator.Metadata
{
    public enum AccessModifier
    {
        Private,
        Protected,
        Public
    }

    public class Method : Primitive, IEquatable<Method>
    {
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

        public Method(string Name)
        {
            ReturnType = new PrimitiveVariable("void");
            InputTypes = new List<Variable>();
            this.Name = Name;
        }

        public IEnumerable<Type> Dependent
        {
            get
            {
                return InputTypes.Concat(new[] { ReturnType }).Select(x => x.Type).Distinct();
            }
        }

        public override string ToString()
        {
            return $"{ReturnType} {Name} ({string.Join(',', InputTypes)})";
        }

        public bool Equals(Method other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            if (Name != other.Name ||
                InputTypes.Count != other.InputTypes.Count ||
                !Equals(ReturnType, other.ReturnType) ||
                !Equals(OwnerClass, other.OwnerClass) ||
                IsConst != other.IsConst ||
                IsTemplate != other.IsTemplate)
            {
                return false;
            }

            return !InputTypes.Where((t, i) => !t.Equals(other.InputTypes[i])).Any();
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Method)obj);
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