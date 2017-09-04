using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Generator.Metadata
{
    public abstract class Primitive
    {
        protected static readonly Regex DisplayNameRegex = new Regex(@"[^\w_]");

        public Dictionary<string, string> UMeta { get; set; }
        public AccessModifier AccessModifier { get; set; }
        public bool IsTemplate { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        protected Primitive()
        {
            AccessModifier = AccessModifier.Public;
            UMeta = new Dictionary<string, string>();
        }

        public string GetDisplayName()
        {
            return UMeta.ContainsKey("DisplayName") ? DisplayNameRegex.Replace(UMeta["DisplayName"], "") : Name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}