using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;

public static class Extensions
{
    public static string ChildText<T>(this ParserRuleContext tree) where T : IParseTree
    {
        return tree?.GetChild<T>(0)?.GetText();
    }

    public static T Child<T>(this ParserRuleContext tree) where T : IParseTree
    {
        return tree == null ? default(T) : tree.GetChild<T>(0);
    }

    public static bool FoundChild<T>(this ParserRuleContext tree) where T : IParseTree
    {
        return tree != null && tree.GetChild<T>(0) != null;
    }

    public static T FindFirst<T>(this ParserRuleContext tree, bool recursive = true) where T : IParseTree
    {
        if (tree == null)
            return default(T);

        var find = tree.GetChild<T>(0);

        if (find != null || tree.children == null || !recursive)
            return find;

        foreach (var parseTree in tree.children)
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

    public static T FindLast<T>(this ParserRuleContext tree, bool recursive = true) where T : IParseTree
    {
        if (tree == null)
            return default(T);

        var find = tree.GetChild<T>(0);

        if (find != null || tree.children == null || !recursive)
            return find;

        foreach (var parseTree in tree.children.Reverse())
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

    public static IEnumerable<T> FindAll<T>(this ParserRuleContext tree, bool searchInResults = false) where T : IParseTree
    {
        var result = new List<T>();

        if (tree?.children == null)
            return result;

        foreach (var parseTree in tree.children.Reverse())
        {
            if (parseTree is T)
            {
                result.Add((T)parseTree);

                if (!searchInResults)
                    continue;
            }

            var child = parseTree as ParserRuleContext;

            if (child != null)
                result.AddRange(child.FindAll<T>(searchInResults));
        }

        return result;
    }

    /// <summary>
    /// For parcer
    /// </summary>
    public static int CompareTo(this string self, string b)
    {
        return string.Compare(self, b, StringComparison.Ordinal);
    }

    public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
    {
        foreach (var item in enumerable)
        {
            action(item);
        }
    }

    public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> enumerable)
    {
        if (enumerable.Any())
        {
            return enumerable.Aggregate((current, t) => current.Concat(t));
        }

        return Enumerable.Empty<T>();
    }
}