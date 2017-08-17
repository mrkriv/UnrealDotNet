namespace Generator.Metadata
{
    public abstract class Variable
    {
        public string Name { get; set; }
    }

    public class PrimitiveVariable : Variable
    {
        public string Type { get; set; }

        public override string ToString()
        {
            return string.IsNullOrEmpty(Name) ? Type : $"{Type} {Name}";
        }
    }

    public class ClassVariable : Variable
    {
        public Class ClassType { get; set; }

        public override string ToString()
        {
            return string.IsNullOrEmpty(Name) ? ClassType.ToString() : $"{ClassType} {Name}";
        }
    }
}