using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generator.Metadata
{
    public class Delegate : Type
    {
        public List<Variable> Parametrs { get; set; }

        public Delegate(string name)
        {
            Parametrs = new List<Variable>();
            Name = name;
        }

        public IEnumerable<Type> Dependent
        {
            get
            {
                return Parametrs.Select(x => x.Type).Distinct();
            }
        }
    }
}
