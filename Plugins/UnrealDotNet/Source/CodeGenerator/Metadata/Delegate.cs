using System.Collections.Generic;
using System.Linq;

namespace CodeGenerator.Metadata
{
    public class Delegate : Type
    {
        public Delegate(string name)
        {
            Parametrs = new List<Variable>();
            Name = name;
        }

        public List<Variable> Parametrs { get; set; }

        public IEnumerable<Type> Dependent
        {
            get { return Parametrs.Select(x => x.Type).Distinct(); }
        }
    }
}