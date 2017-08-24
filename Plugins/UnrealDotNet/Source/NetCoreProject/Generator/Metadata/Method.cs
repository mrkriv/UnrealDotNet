using System;
using System.Collections.Generic;
using System.Linq;

namespace Generator.Metadata
{
    public class Method : IEquatable<Method>
    {
        public Variable ReturnType { get; set; }
        public List<Variable> InputTypes { get; set; }
        public Class OwnerClass { get; set; }
        public bool IsConst { get; set; }
        public bool IsVirtual { get; set; }
        public bool IsOverride { get; set; }
        public bool IsStatic { get; set; }
        public bool IsTemplate { get; set; }
        public string Operator { get; set; }

        public string Name { get; set; }

        public Method(string Name)
        {
            InputTypes = new List<Variable>();
            this.Name = Name;
        }

        public IEnumerable<Class> Dependent
        {
            get
            {
                var list = InputTypes.OfType<ClassVariable>().Select(v => v.ClassType).ToList();

                var returnClass = ReturnType as ClassVariable;
                if (returnClass != null)
                    list.Insert(0, returnClass.ClassType);

                return list.Distinct();
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

            if (InputTypes.Count != other.InputTypes.Count ||
                !Equals(ReturnType, other.ReturnType) ||
                !Equals(OwnerClass, other.OwnerClass) ||
                IsConst != other.IsConst ||
                IsTemplate != other.IsTemplate &&
                !string.Equals(Name, other.Name))
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
    }
}