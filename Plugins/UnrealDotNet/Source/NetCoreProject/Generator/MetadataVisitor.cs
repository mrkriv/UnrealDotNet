using System;
using Generator.Metadata;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Concurrent;
using static UHeaderParser;
using Enum = Generator.Metadata.Enum;
using Type = Generator.Metadata.Type;

namespace Generator
{
    public class MetadataVisitor : UHeaderBaseVisitor<object>
    {
        private readonly ConcurrentDictionary<string, Type> Types;
        private Dictionary<string, string> CurrentUMeta;
        private AccessModifier AccessModifier;
        private Class CurrentClass;
        private Enum CurrentEnum;
        private string CurrentFile;
        private string CurrentComment;
        private bool Ignore;
        private int PreprocessorIfCount;

        public MetadataVisitor(ConcurrentDictionary<string, Type> types)
        {
            Types = types;
        }

        public void Append(TranslationUnitContext Translationunit, string file)
        {
            PreprocessorIfCount = 0;
            CurrentComment = "";
            CurrentFile = file;

            Visit(Translationunit);
        }

        private Type GetType(string name)
        {
            var liter = name.First();
            return Types.GetOrAdd(name, liter == 'E' ? (Type)new Enum(name) : new Class(name));
        }

        private Class GetClass(string name)
        {
            return (Class)Types.GetOrAdd(name, new Class(name));
        }

        private Enum GetEnum(string name)
        {
            return (Enum)Types.GetOrAdd(name, new Enum(name));
        }

        public override object VisitClassDeclaration(ClassDeclarationContext context)
        {
            var NamespaceBaseClass = CurrentClass;

            CurrentClass = GetClass(context.ChildText<ClassNameContext>());

            CurrentClass.SourceFile = CurrentFile;
            CurrentClass.IsImplemented = true;
            CurrentClass.IsStructure = CurrentClass.Name.First() == 'F';    //context.ChildText<ClassOrStructContext>() == "struct";
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

            CurrentUMeta = null;
            CurrentComment = "";

            VisitClassBody(context.Child<ClassBodyContext>());

            CurrentClass.NamespaceBaseType = NamespaceBaseClass;
            CurrentClass = NamespaceBaseClass;

            return null;
        }

        public override object VisitEnumDeclaration(EnumDeclarationContext context)
        {
            var name = context.enumName()?.GetText();

            if (string.IsNullOrEmpty(name))
                return null;

            CurrentEnum = GetEnum(name);
            CurrentEnum.UMeta = CurrentUMeta ?? new Dictionary<string, string>();
            CurrentEnum.Description = CurrentComment;
            CurrentEnum.IsImplemented = true;

            CurrentUMeta = null;
            CurrentComment = "";

            var body = context.enumElementList();

            if (body != null)
                VisitEnumElementList(body);

            CurrentEnum = null;
            return null;
        }

        public override object VisitEnumElement(EnumElementContext context)
        {
            CurrentEnum?.Fields.Add(new Enum.Field
            {
                Name = context.enumElementName().GetText(),
                Value = context.propertyDefaultValue()?.GetText(),
                UMeta = CurrentUMeta ?? new Dictionary<string, string>(),
                Description = CurrentComment,
            });

            CurrentUMeta = null;
            CurrentComment = "";

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

            var name = context.methodName().GetText();

            if (name == CurrentClass.Name)
            {
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
            }

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
            {
                variable = new PrimitiveVariable(typeName);
            }
            else
            {
                var type = GetType(typeName);
                if (type is Class)
                {
                    variable = new ClassVariable((Class)type);
                }
                else
                {
                    variable = new EnumVariable((Enum)type);
                }
            }

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
            if (CurrentClass != null || CurrentEnum != null)
                CurrentComment = context.GetText();

            return null;
        }
    }
}