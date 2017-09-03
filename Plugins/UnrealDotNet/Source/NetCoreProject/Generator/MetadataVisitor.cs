using System;
using Generator.Metadata;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Concurrent;
using static UHeaderParser;

namespace Generator
{
    public class MetadataVisitor : UHeaderBaseVisitor<object>
    {
        private readonly ConcurrentDictionary<string, Class> Classes;
        private Dictionary<string, string> CurrentUMeta;
        private Class CurrentClass;
        private string CurrentFile;
        private string CurrentComment;
        private bool Ignore;
        private AccessModifier AccessModifier;
        private int PreprocessorIfCount;

        public MetadataVisitor(ConcurrentDictionary<string, Class> classes)
        {
            Classes = classes;
        }

        public Domain GetDomain() => new Domain(Classes.Values.OrderBy(c => c.Name));

        public void Append(TranslationUnitContext Translationunit, string file)
        {
            PreprocessorIfCount = 0;
            CurrentComment = "";
            CurrentFile = file;

            Visit(Translationunit);
        }

        private Class GetClass(string name)
        {
            Classes.TryGetValue(name, out Class Class);

            return Class ?? Classes.GetOrAdd(name, new Class(name));
        }

        public override object VisitClassDeclaration(ClassDeclarationContext context)
        {
            var NamespaceBaseClass = CurrentClass;

            CurrentClass = GetClass(context.ChildText<ClassNameContext>());

            CurrentClass.SourceFile = CurrentFile;
            CurrentClass.IsImplemented = true;
            CurrentClass.IsStructure = context.ChildText<ClassOrStructContext>() == "struct";
            CurrentClass.IsTemplate = context.FoundChild<TemplateDefineContext>();
            CurrentClass.IsFinal = context.FoundChild<IsFinalContext>();
            CurrentClass.UMeta = CurrentUMeta ?? CurrentClass.UMeta;
            CurrentClass.Description = CurrentComment;

            AccessModifier = CurrentClass.IsStructure ? AccessModifier.Public : AccessModifier.Private;
            Ignore = AccessModifier == AccessModifier.Private;

            var parentClassName = context.Child<ClassParentListContext>()?.FindFirst<ClassNameContext>()?.GetText();
            if (parentClassName != null)
            {
                CurrentClass.BaseClass = GetClass(parentClassName);
            }

            VisitClassBody(context.Child<ClassBodyContext>());
            CurrentUMeta = null;
            CurrentComment = "";

            CurrentClass.NamespaceBaseClass = NamespaceBaseClass;
            CurrentClass = NamespaceBaseClass;

            return null;
        }

        public override object VisitProperty(PropertyContext context)
        {
            if (Ignore || CurrentClass == null)
                return null;

            var variable = ParceType(context.type());
            variable.Name = context.propertyName().GetText();
            variable.Default = context.propertyDefaultValue()?.GetText();
            variable.UMeta = CurrentUMeta ?? variable.UMeta;
            variable.Description = CurrentComment;
            variable.AccessModifier = AccessModifier;

            CurrentClass.Property.Add(variable);
            CurrentUMeta = null;
            CurrentComment = "";

            return null;
        }

        public override object VisitMethod(MethodContext context)
        {
            if (Ignore || CurrentClass == null)
                return null;

            var method = new Method(context.methodName().GetText())
            {
                IsConst = context.FoundChild<IsConstContext>(),
                IsFinal = context.FoundChild<IsFinalContext>(),
                IsStatic = context.FoundChild<IsStaticContext>(),
                IsFriend = context.FoundChild<IsFriendContext>(),
                IsVirtual = context.FoundChild<IsVirtualContext>(),
                IsOverride = context.FoundChild<IsOverrideContext>(),
                IsTemplate = context.FoundChild<TemplateDefineContext>(),
                UMeta = CurrentUMeta ?? new Dictionary<string, string>(),
                AccessModifier = AccessModifier,
                Description = CurrentComment,
                OwnerClass = CurrentClass,
                Operator = context.methodName().methodOperator()?.GetText(),

                ReturnType = ParceType(context.type()),
                InputTypes = context.FindAll<MethodParametrContext>().Reverse()
                    .Select(ParceParam).ToList()
            };

            if (!CurrentClass.Methods.Any(m => m.Equals(method)))
                CurrentClass.Methods.Add(method);

            CurrentUMeta = null;
            CurrentComment = "";
            return null;
        }

        public override object VisitConstructor(ConstructorContext context)
        {
            if (Ignore || CurrentClass == null)
                return null;

            var method = new Method(context.methodName().GetText())
            {
                IsConst = context.FoundChild<IsConstContext>(),
                UMeta = CurrentUMeta ?? new Dictionary<string, string>(),
                Description = CurrentComment,
                OwnerClass = CurrentClass,
                Operator = context.methodName().methodOperator()?.GetText(),
                AccessModifier = AccessModifier,

                InputTypes = context.FindAll<MethodParametrContext>().Reverse()
                    .Select(ParceParam).ToList()
            };

            if (!CurrentClass.Constructors.Any(m => m.Equals(method)))
                CurrentClass.Constructors.Add(method);

            CurrentUMeta = null;
            CurrentComment = "";
            return null;
        }

        public override object VisitUMeta(UMetaContext context)
        {
            CurrentUMeta = new Dictionary<string, string>();

            VisitUMetaParametrList(context.uMetaParametrList());

            return null;
        }

        public override object VisitUMetaParametr(UMetaParametrContext context)
        {
            var key = context.uMetaParamKey().GetText();
            var value = context.uMetaParamValue()?.GetText();
            var paramList = context.uMetaParametrList();

            if (paramList != null)
            {
                VisitUMetaParametrList(paramList);
            }
            else if (!CurrentUMeta.ContainsKey(key))
            {
                CurrentUMeta.Add(key, value != null ? value.Trim('"') : "");
            }

            return null;
        }

        private Variable ParceParam(MethodParametrContext context)
        {
            var variable = ParceType(context.type());
            variable.Name = context.methodParametrName()?.GetText();
            variable.Default = context.methodParametrDefaultValue()?.GetText();

            return variable;
        }

        private Variable ParceType(TypeContext context)
        {
            var typeName = context.typeName().GetText();
            Variable variable;

            if (PrimitiveVariable.PrimitiveTypes.Contains(typeName))
                variable = new PrimitiveVariable(typeName);
            else
                variable = new ClassVariable(GetClass(typeName));

            variable.IsConst = context.FoundChild<IsConstContext>();
            variable.IsPointer = context.FoundChild<IsPtrQuantContext>();
            variable.IsReference = context.FoundChild<IsRefQuantContext>();

            return variable;
        }

        public override object VisitPreprocessDerective(PreprocessDerectiveContext context)
        {
            var text = context.GetText();
            if (text.StartsWith("#if "))
            {
                if (text.StartsWith("#if WITH_EDITOR"))
                {
                    Ignore = true;
                }

                if (Ignore)
                    PreprocessorIfCount++;
            }
            else if (text.StartsWith("#endif") && Ignore)
            {
                PreprocessorIfCount--;
                if (PreprocessorIfCount == 0)
                {
                    Ignore = AccessModifier == AccessModifier.Private;
                }
            }

            return base.VisitPreprocessDerective(context);
        }

        public override object VisitAccessSpecifier(AccessSpecifierContext context)
        {
            System.Enum.TryParse(typeof(AccessModifier), context.GetText(), true, out var result);
            AccessModifier = (AccessModifier)result;

            Ignore = AccessModifier == AccessModifier.Private || PreprocessorIfCount != 0;

            return null;
        }

        public override object VisitComment(CommentContext context)
        {
            if (Classes != null)
                CurrentComment = context.GetText();

            return null;
        }
    }
}