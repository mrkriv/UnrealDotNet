using Generator.Metadata;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using static UHeaderParser;
using Delegate = Generator.Metadata.Delegate;
using Enum = Generator.Metadata.Enum;
using Type = Generator.Metadata.Type;

namespace Generator
{
    public class MetadataVisitor : UHeaderBaseVisitor<object>
    {
        private readonly ConcurrentDictionary<string, Type> Types;
        private Dictionary<string, string> CurrentUMeta;
        private AccessModifier AccessModifier;
        private Variable CurrentDelegateVariable;
        private Delegate CurrentDelegate;
        private Class CurrentClass;
        private Enum CurrentEnum;
        private string CurrentFile;
        private string CurrentComment;
        private bool Ignore_OfPragma;
        private bool Ignore_OfAccessModifier;
        private int PreprocessorIfCount;

        private bool Ignore => Ignore_OfPragma || Ignore_OfAccessModifier;

        public MetadataVisitor(ConcurrentDictionary<string, Type> types)
        {
            Types = types;
        }

        public void Append(TranslationUnitContext Translationunit, string file)
        {
            PreprocessorIfCount = 0;
            Ignore_OfAccessModifier = false;
            Ignore_OfPragma = false;
            CurrentComment = "";
            CurrentFile = file;

            CurrentDelegateVariable = null;
            CurrentDelegate = null;
            CurrentClass = null;
            CurrentEnum = null;

            Visit(Translationunit);
        }

        private Type GetType(TypeContext context)
        {
            var name = context.typeName().GetText();

            if (Types.TryGetValue(name, out var val))
                return val;

            if (name.StartsWith("E"))
            {
                return Get<Enum>(context);
            }
            if (name.EndsWith("Signature"))
            {
                return Get<Delegate>(context);
            }

            return Get<Class>(context);
        }
        
        private T Get<T>(TypeContext context) where T : Type
        {
            var name = context.typeName().GetText();

            if (name.Contains("<"))
            {
                name = context.typeName().Identifier().First().GetText();
                var templateTypes = context.typeName().type();

                name += "__";
                name += string.Join(", ", templateTypes.Select(x => x.typeName().Identifier().First().GetText()));
            }

            if (Types.TryGetValue(name, out var val))
            {
                if (val is T)
                    return (T)val;

                throw new InvalidOperationException($"Элемент уже использован как {val.GetType()}");
            }

            var def = (Type)Activator.CreateInstance(typeof(T), name);
            Types.TryAdd(name, def);

            foreach (var nameContext in context.typeName().type())
            {
                def.TemplateTypes.Add(ParceType(nameContext)); 
            }

            return (T)def;
        }

        public override object VisitClassDeclaration(ClassDeclarationContext context)
        {
            if (Ignore_OfPragma)
                return null;

            var NamespaceBaseClass = CurrentClass;

            CurrentClass = Get<Class>(context.type());

            var isStructReal = context.classOrStruct().GetText() == "struct";

            CurrentClass.SourceFile = CurrentFile;
            CurrentClass.SourceLine = context.Start.Line;
            CurrentClass.IsImplemented = true;
            CurrentClass.IsTemplate = context.FoundChild<TemplateDefineContext>();
            CurrentClass.IsFinal = context.FoundChild<IsFinalContext>();
            CurrentClass.UMeta = CurrentUMeta ?? CurrentClass.UMeta;
            CurrentClass.Description = CurrentComment;

            switch (CurrentClass.Name.First())
            {
                case 'U':
                    CurrentClass.IsStructure = false;
                    break;

                case 'F':
                    CurrentClass.IsStructure = true;
                    break;

                default:
                    CurrentClass.IsStructure = isStructReal;
                    break;
            }

            AccessModifier = isStructReal
                ? AccessModifier.Public
                : AccessModifier.Private;

            Ignore_OfAccessModifier = AccessModifier == AccessModifier.Private;

            var parentClassName = context.Child<ClassParentListContext>()?.type();
            if (parentClassName != null)
            {
                CurrentClass.BaseClass = Get<Class>(parentClassName);
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
            if (Ignore_OfPragma)
                return null;

            var name = context.type()?.GetText();

            if (string.IsNullOrEmpty(name))
                return null;

            CurrentEnum = Get<Enum>(context.type());
            CurrentEnum.SourceFile = CurrentFile;
            CurrentEnum.SourceLine = context.Start.Line;
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
            variable.AccessModifier = AccessModifier;
            variable.Default = context.propertyDefaultValue()?.GetText();
            variable.Description = CurrentComment;
            variable.IsStatic = context.FoundChild<IsStaticContext>();
            variable.Name = context.propertyName().GetText();
            variable.UMeta = CurrentUMeta ?? variable.UMeta;
            variable.OwnerClass = CurrentClass;

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

            if (context.isDestructor() != null)
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
                    ReturnType = new ClassVariable(CurrentClass),

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

        public override object VisitUDefine(UDefineContext context)
        {
            if (Ignore_OfPragma)
                return null;

            var name = context.uDefineName().GetText();

            if (name.StartsWith("DECLARE_DYNAMIC_MULTICAST_DELEGATE"))
            {
                var ls = context.uMeta().uMetaParametrList();

                CurrentDelegate = Get<Delegate>(ls.uMetaParametr().uMetaParamKey().type());
                CurrentDelegate.SourceFile = CurrentFile;
                CurrentDelegate.SourceLine = context.Start.Line;
                CurrentDelegate.IsImplemented = true;
                CurrentDelegate.IsTemplate = context.FoundChild<TemplateDefineContext>();
                CurrentDelegate.Description = CurrentComment;

                CurrentDelegateVariable = null;
                CurrentUMeta = new Dictionary<string, string>();

                if (ls.uMetaParametrList() != null)
                    VisitChildren(ls.uMetaParametrList());

                CurrentDelegate = null;
                CurrentUMeta = null;
                CurrentComment = "";
            }

            return base.VisitUDefine(context);
        }

        public override object VisitUMeta(UMetaContext context)
        {
            var ls = context.uMetaParametrList();

            if (ls != null)
            {
                CurrentUMeta = new Dictionary<string, string>();
                VisitUMetaParametrList(ls);
            }

            return null;
        }

        public override object VisitUMetaParametr(UMetaParametrContext context)
        {
            var key = context.uMetaParamKey().GetText();
            var value = context.uMetaParamValue()?.GetText();
            var paramList = context.uMetaParametrList();

            if (!CurrentUMeta.ContainsKey(key))
            {
                if (CurrentDelegate != null)
                {
                    ParceDelegateKey(context);
                }
                else
                    CurrentUMeta.Add(key, value != null ? value.Trim('"') : "");
            }
            if (paramList != null)
            {
                VisitUMetaParametrList(paramList);
            }

            return null;
        }

        private void ParceDelegateKey(UMetaParametrContext context)
        {
            if (CurrentDelegate == null)
                return;

            if (CurrentDelegateVariable == null)
            {
                CurrentDelegateVariable = ParceType(context.FindFirst<TypeContext>());
            }
            else
            {
                var key = context.uMetaParamKey().GetText();
                CurrentDelegateVariable.Name = key;

                CurrentDelegate.Parametrs.Add(CurrentDelegateVariable);
                CurrentDelegateVariable = null;
            }
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
                var type = GetType(context);
                if (type is Class)
                {
                    variable = new ClassVariable((Class)type);
                }
                else if (type is Delegate)
                {
                    variable = new DelegateVariable((Delegate)type);
                }
                else if(type is Enum)
                {
                    variable = new EnumVariable((Enum)type);
                }
                else
                {
                    throw new InvalidOperationException();
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
                    Ignore_OfPragma = true;
                }

                if (Ignore_OfPragma)
                    PreprocessorIfCount++;
            }
            else if (text.StartsWith("#endif") && Ignore_OfPragma)
            {
                PreprocessorIfCount--;
                if (PreprocessorIfCount == 0)
                {
                    Ignore_OfPragma = false;
                }
            }

            return base.VisitPreprocessDerective(context);
        }

        public override object VisitAccessSpecifier(AccessSpecifierContext context)
        {
            System.Enum.TryParse(typeof(AccessModifier), context.GetText(), true, out var result);
            AccessModifier = (AccessModifier)result;

            Ignore_OfAccessModifier = AccessModifier == AccessModifier.Private;

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