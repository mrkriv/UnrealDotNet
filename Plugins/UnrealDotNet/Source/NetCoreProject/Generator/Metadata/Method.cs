using System.Collections.Generic;
using System.Linq;

namespace Generator.Metadata
{
    public class Method
    {
        public Variable ReturnType { get; set; }
        public List<Variable> InputTypes { get; set; }
        public Class OwnerClass { get; set; }
        public bool IsConst { get; set; }
        public bool IsVirtual { get; set; }
        public bool IsStatic { get; set; }
        public bool IsTemplate { get; set; }

        public string Name { get; set; }

        public Method(string Name)
        {
            InputTypes = new List<Variable>();
            this.Name = Name;
        }

        public IEnumerable<Class> Dependent
        {
            get
            {
                var list = InputTypes.OfType<ClassVariable>().Select(v => v.ClassType).ToList();

                var returnClass = ReturnType as ClassVariable;
                if (returnClass != null)
                    list.Insert(0, returnClass.ClassType);

                return list;
            }
        }

        public override string ToString()
        {
            return $"{ReturnType} {Name} ({string.Join(',', InputTypes)})";
        }
    }
}