using System;

namespace CodeGenerator.Metadata
{
    public class PrimitiveType : Type, IEquatable<PrimitiveType>
    {
        public PrimitiveType(string name)
        {
            IsImplemented = true;

            Name = name;
        }

        public bool Equals(PrimitiveType other)
        {
            return other?.Name == Name;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((PrimitiveType) obj);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}