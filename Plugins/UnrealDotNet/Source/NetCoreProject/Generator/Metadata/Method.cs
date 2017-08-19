using System.Collections.Generic;

namespace Generator.Metadata
{
    public class Method
    {
        public Variable ReturnType { get; set; }
        public List<Variable> InputTypes { get; set; }
        public Class OwnerClass { get; set; }

        public string Name { get; set; }

        public Method(string Name)
        {
            InputTypes = new List<Variable>();
            this.Name = Name;
        }

        public override string ToString()
        {
            return $"{ReturnType} {Name} ({string.Join(',', InputTypes)})";
        }
    }
}