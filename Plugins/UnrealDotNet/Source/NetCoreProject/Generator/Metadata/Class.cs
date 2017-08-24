using System.Collections.Generic;
using System.Linq;

namespace Generator.Metadata
{
    public class Class
    {
        public string Name { get; }
        public Class BaseClass { get; set; }
        public Class NamespaceBaseClass { get; set; }
        public List<Method> Methods { get; set; }
        public List<Variable> Property { get; set; }
        public bool IsImplemented { get; set; }
        public bool IsStructure { get; set; }
        public bool IsTemplate { get; set; }
        public string SourceFile { get; set; }

        public string FullName => NamespaceBaseClass != null ? NamespaceBaseClass.FullName + "." + Name : Name;

        public IEnumerable<Class> Dependent
        {
            get
            {
                var list = Property.OfType<ClassVariable>().Select(v => v.ClassType);
                list = Methods.Select(m => m.Dependent).Aggregate(list, (current, md) => current.Concat(md));

                return list.Distinct().OrderBy(cl => cl.Name);
            }
        }

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