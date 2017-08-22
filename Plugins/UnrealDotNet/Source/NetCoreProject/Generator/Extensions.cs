using System;
using System.Collections.Generic;
using System.Linq;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

public static class Extensions
{
    public static string ChildText<T>(this ParserRuleContext Tree) where T : IParseTree
    {
        return Tree?.GetChild<T>(0)?.GetText();
    }

    public static T Child<T>(this ParserRuleContext Tree) where T : IParseTree
    {
        return Tree == null ? default(T) : Tree.GetChild<T>(0);
    }

    public static bool FoundChild<T>(this ParserRuleContext Tree) where T : IParseTree
    {
        return Tree != null && Tree.GetChild<T>(0) != null;
    }

    public static T FindFirst<T>(this ParserRuleContext Tree, bool Recursive = true) where T : IParseTree
    {
        if (Tree == null)
            return default(T);

        var find = Tree.GetChild<T>(0);

        if (find != null || Tree.children == null || !Recursive)
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

    public static T FindLast<T>(this ParserRuleContext Tree, bool Recursive = true) where T : IParseTree
    {
        if (Tree == null)
            return default(T);

        var find = Tree.GetChild<T>(0);

        if (find != null || Tree.children == null || !Recursive)
            return find;

        foreach (var parseTree in Tree.children.Reverse())
        {
            var child = parseTree as ParserRuleContext;

            if (child == null)
                continue;

            find = FindLast<T>(child);
            if (find != null)
                return find;
        }

        return default(T);
    }

    public static IEnumerable<T> FindAll<T>(this ParserRuleContext Tree, bool SearchInResults = false) where T : IParseTree
    {
        var result = new List<T>();

        if (Tree?.children == null)
            return result;

        foreach (var parseTree in Tree.children.Reverse())
        {
            if (parseTree is T)
            {
                result.Add((T)parseTree);

                if (!SearchInResults)
                    continue;
            }

            var child = parseTree as ParserRuleContext;

            if (child != null)
                result.AddRange(child.FindAll<T>(SearchInResults));
        }

        return result;
    }

    /// <summary>
    /// For parcer
    /// </summary>
    public static int compareTo(this string Self, string B)
    {
        return string.Compare(Self, B, StringComparison.Ordinal);
    }
}