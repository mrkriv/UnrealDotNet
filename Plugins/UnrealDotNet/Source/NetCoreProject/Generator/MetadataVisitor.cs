using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Transactions;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Generator.Metadata;
using static UHeaderParser;

namespace Generator
{
    public class MetadataVisitor : UHeaderBaseVisitor<object>
    {
        private readonly Dictionary<string, Class> Classes = new Dictionary<string, Class>();
        private Class CurrentClass;
        private string CurrentFile;
        private bool Ignore;

        public Domain GetDomain() => new Domain { Classes = Classes.Values.ToList() };

        public void Append(TranslationUnitContext Translationunit, string file)
        {
            CurrentFile = file;
            Visit(Translationunit);
        }

        private Class GetClass(string name)
        {
            Classes.TryGetValue(name, out Class Class);

            if (Class != null)
                return Class;

            Class = new Class(name);
            Classes.Add(name, Class);

            return Class;
        }

        public override object VisitClassDeclaration(ClassDeclarationContext context)
        {
            CurrentClass = GetClass(context.ChildText<ClassNameContext>());

            CurrentClass.SourceFile = CurrentFile;
            CurrentClass.IsImplemented = true;
            CurrentClass.IsStructure = context.ChildText<ClassTypeContext>() == "struct";

            var parentClassName = context.Child<ClassParentListContext>()?.FindFirst<ClassNameContext>()?.GetText();
            if (parentClassName != null)
            {
                CurrentClass.BaseClass = GetClass(parentClassName);
            }

            VisitClassBody(context.Child<ClassBodyContext>());

            return null;
        }

        public override object VisitMethod(MethodContext context)
        {
            if (Ignore || CurrentClass == null)
                return null;

            var method = new Method(context.ChildText<MethodNameContext>())
            {
                ReturnType = ParceType(context.Child<TypeContext>()),
                InputTypes = context.FindAll<MethodParametrContext>().Reverse()
                    .Select(ParceParam).ToList()
            };

            CurrentClass.Methods.Add(method);

            return base.VisitMethod(context);
        }

        private Variable ParceParam(MethodParametrContext context)
        {
            var variable = ParceType(context.Child<TypeContext>());
            variable.Name = context.ChildText<MethodParametrNameContext>();

            return variable;
        }

        private Variable ParceType(TypeContext context)
        {
            var typeName = context.GetText();
            Variable variable;

            if (PrimitiveVariable.PrimitiveTypes.Contains(typeName))
                variable = new PrimitiveVariable(typeName);
            else
                variable = new ClassVariable(GetClass(typeName));

            return variable;
        }

        public override object VisitAccessSpecifier(AccessSpecifierContext context)
        {
            Ignore = context.GetText() != "public";
            return null;
        }
    }
}