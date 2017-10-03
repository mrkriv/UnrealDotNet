using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Generator.Metadata
{
    public class Class : Type
    {
        public Class BaseClass { get; set; }
        public List<Method> Methods { get; set; }
        public List<Method> Constructors { get; set; }
        public List<Variable> Property { get; set; }
        public bool IsStructure { get; set; }
        public bool IsReadOnly { get; set; }
        public bool IsFinal { get; set; }

        public Class(string Name)
        {
            Methods = new List<Method>();
            Property = new List<Variable>();
            Constructors = new List<Method>();

            IsImplemented = false;
            this.Name = Name;
        }

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
    }
}