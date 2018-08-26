using System.Collections.Generic;
using System.Linq;

namespace CodeGenerator.Metadata
{
    public class Class : Type
    {
        public Class(string name)
        {
            Methods = new List<Method>();
            Property = new List<Variable>();
            Constructors = new List<Method>();

            IsImplemented = false;
            Name = name;
        }

        public Class BaseClass { get; set; }
        public List<Method> Methods { get; set; }
        public List<Method> Constructors { get; set; }
        public List<Variable> Property { get; set; }
        public bool IsStructure { get; set; }
        public bool IsReadOnly { get; set; }
        public bool IsFinal { get; set; }

        public char Litera => Name.First();
        public string BaseName => Name.Substring(1);

        public IEnumerable<Type> Dependent
        {
            get
            {
                return Methods.Select(x => x.Dependent).Flatten()
                    .Concat(Constructors.Select(x => x.Dependent).Flatten())
                    .Concat(Property.Select(x => x.Type))
                    .Distinct();
            }
        }

        public bool IsChild(string className)
        {
            var cl = this;
            while (cl != null)
            {
                if (cl.Name == className)
                    return true;

                cl = cl.BaseClass;
            }

            return false;
        }
    }
}