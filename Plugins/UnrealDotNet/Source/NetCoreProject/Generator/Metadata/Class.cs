using System.Collections.Generic;

namespace Generator.Metadata
{
    public class Class
    {
        public string Name { get; }
        public Class BaseClass { get; set; }
        public List<Method> Methods { get; set; }
        public List<Variable> Property { get; set; }
        public bool IsImplemented { get; set; }
        public bool IsStructure { get; set; }
        public bool IsTemplate { get; set; }
        public string SourceFile { get; set; }

        public Class(string Name)
        {
            Methods = new List<Method>();
            Property = new List<Variable>();

            IsImplemented = false;
            this.Name = Name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}