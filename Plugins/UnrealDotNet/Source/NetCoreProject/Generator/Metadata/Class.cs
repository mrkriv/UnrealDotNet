using System.Collections.Generic;

namespace Generator.Metadata
{
    public class Class
    {
        public string Name { get; set; }
        public Class BaseClass { get; set; }
        public List<Method> Methods { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}