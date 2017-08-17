using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace Generator
{
    public static class Extensions
    {
        public static T FindFirst<T>(this ParserRuleContext Tree) where T : IParseTree
        {
            var find = Tree.GetChild<T>(0);

            if (find != null)
                return find;

            foreach (var parseTree in Tree.children)
            {
                var child = parseTree as ParserRuleContext;

                if (child == null)
                    continue;

                find = FindFirst<T>(child);
                if (find != null)
                    return find;
            }

            return default(T);
        }
    }
}