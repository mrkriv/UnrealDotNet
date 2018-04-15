using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Generator.Metadata
{
    public abstract class Primitive
    {
        protected static readonly Regex DisplayReplaceNameRegex = new Regex(@"[^\w_]");
        protected static readonly Regex DisplayValidNameRegex = new Regex(@"^[A-Za-z]\w+");

        public Dictionary<string, string> UMeta { get; set; }
        public AccessModifier AccessModifier { get; set; }
        public virtual bool IsTemplate { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public string SourceFile { get; set; }
        public int SourceLine { get; set; }

        protected Primitive()
        {
            AccessModifier = AccessModifier.Public;
            UMeta = new Dictionary<string, string>();
        }

        public string GetDisplayName()
        {
            if (UMeta.ContainsKey("DisplayName"))
            {
                var displayName = DisplayReplaceNameRegex.Replace(UMeta["DisplayName"], "");

                if (DisplayValidNameRegex.IsMatch(displayName))
                    return displayName;
            }

            return Name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}