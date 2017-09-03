using System.Collections.Generic;
using System.Linq;

namespace Generator.Metadata
{
    public class Class
    {
        public Dictionary<string, string> UMeta { get; set; }
        public string Name { get; }
        public Domain Domain { get; set; }
        public Class BaseClass { get; set; }
        public Class NamespaceBaseClass { get; set; }
        public List<Method> Methods { get; set; }
        public List<Method> Constructors { get; set; }
        public List<Variable> Property { get; set; }
        public bool IsImplemented { get; set; }
        public bool IsStructure { get; set; }
        public bool IsTemplate { get; set; }
        public bool IsReadOnly { get; set; }
        public bool IsFinal { get; set; }

        public string Description { get; set; }
        public string SourceFile { get; set; }

        public string FullName => NamespaceBaseClass != null ? NamespaceBaseClass.FullName + "." + Name : Name;

        public IEnumerable<Class> PropertyDependent
        {
            get
            {
                var list = Property.OfType<ClassVariable>().Select(v => v.ClassType);
                return list.Where(cl => cl != this).Distinct().OrderBy(cl => cl.Name);
            }
        }

        public IEnumerable<Class> Dependent
        {
            get
            {
                var list = Methods.Select(m => m.Dependent).Aggregate(PropertyDependent, (current, md) => current.Concat(md));

                return list.Where(cl => cl != this).Distinct().OrderBy(cl => cl.Name);
            }
        }

        public Class(string Name)
        {
            Methods = new List<Method>();
            Property = new List<Variable>();
            Constructors = new List<Method>();
            UMeta = new Dictionary<string, string>();

            IsImplemented = false;
            this.Name = Name;
        }

        public bool IsChild(string ClassName)
        {
            var cl = this;
            while (cl != null)
            {
                if (cl.Name == ClassName)
                    return true;

                cl = cl.BaseClass;
            }

            return false;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}