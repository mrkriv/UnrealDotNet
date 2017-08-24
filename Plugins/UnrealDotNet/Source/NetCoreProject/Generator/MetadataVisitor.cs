using Generator.Metadata;
using System.Collections.Generic;
using System.Linq;
using static UHeaderParser;

namespace Generator
{
    public class MetadataVisitor : UHeaderBaseVisitor<object>
    {
        private readonly Dictionary<string, Class> Classes = new Dictionary<string, Class>();
        private Class CurrentClass;
        private string CurrentFile;
        private bool Ignore;
        private bool IsPublicBlock;
        private int PreprocessorIfCount;

        public Domain GetDomain() => new Domain { Classes = Classes.Values.OrderBy(c => c.Name).ToList() };

        public void Append(TranslationUnitContext Translationunit, string file)
        {
            PreprocessorIfCount = 0;
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
            var NamespaceBaseClass = CurrentClass;

            CurrentClass = GetClass(context.ChildText<ClassNameContext>());

            CurrentClass.SourceFile = CurrentFile;
            CurrentClass.IsImplemented = true;
            CurrentClass.IsStructure = context.ChildText<ClassOrStructContext>() == "struct";
            CurrentClass.IsTemplate = context.FoundChild<TemplateDefineContext>();

            IsPublicBlock = CurrentClass.IsStructure;
            Ignore = IsPublicBlock;

            var parentClassName = context.Child<ClassParentListContext>()?.FindFirst<ClassNameContext>()?.GetText();
            if (parentClassName != null)
            {
                CurrentClass.BaseClass = GetClass(parentClassName);
            }

            VisitClassBody(context.Child<ClassBodyContext>());

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

            CurrentClass.Property.Add(variable);

            return null;
        }

        public override object VisitMethod(MethodContext context)
        {
            if (Ignore || CurrentClass == null)
                return null;

            var method = new Method(context.methodName().GetText())
            {
                IsConst = context.isConst() != null,
                IsStatic = context.isStatic() != null,
                IsVirtual = context.isVirtual() != null,
                IsOverride = context.isOverride() != null,
                IsTemplate = context.templateDefine() != null,
                OwnerClass = CurrentClass,
                Operator = context.methodName().methodOperator()?.GetText(),

                ReturnType = ParceType(context.type()),
                InputTypes = context.FindAll<MethodParametrContext>().Reverse()
                    .Select(ParceParam).ToList()
            };

            if (!CurrentClass.Methods.Any(m => m.Equals(method)))
                CurrentClass.Methods.Add(method);

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

            variable.IsConst = context.isConst().Length != 0;
            variable.IsPointer = context.isPtrQuant().Length != 0;
            variable.IsReference = context.isRefQuant().Length != 0;

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
                    Ignore = !IsPublicBlock;
                }
            }

            return base.VisitPreprocessDerective(context);
        }

        public override object VisitAccessSpecifier(AccessSpecifierContext context)
        {
            IsPublicBlock = context.GetText() == "public";
            Ignore = !(IsPublicBlock && PreprocessorIfCount == 0);

            return null;
        }
    }
}