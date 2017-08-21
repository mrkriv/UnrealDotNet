using System.Collections.Generic;

namespace Generator.Metadata
{
    public class Class
    {
        public string Name { get; }
        public Class BaseClass { get; set; }
        public List<Method> Methods { get; set; }
        public bool IsImplemented { get; set; }
        public string SourceFile { get; set; }

        public Class(string Name)
        {
            Methods = new List<Method>();
            IsImplemented = false;
            this.Name = Name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}