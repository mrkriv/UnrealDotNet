using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Generator.Metadata;
using static CPP14Parser;

namespace Generator
{
    public class GenMetadataVisitor : CPP14BaseVisitor<object>
    {
        private readonly Dictionary<string, Class> Classes = new Dictionary<string, Class>();
        private Class CurrentClass;
        private bool Ignore;

        public List<Class> GetClasses()
        {
            return Classes.Values.ToList();
        }

        public void Append(TranslationunitContext Translationunit)
        {
            Visit(Translationunit);
        }

        private Class GetClass(string name)
        {
            Classes.TryGetValue(name, out Class Class);

            if (Class == null)
            {
                Class = new Class { Name = name };
                Classes.Add(name, Class);
            }

            return Class;
        }

        public override object VisitClassspecifier(ClassspecifierContext context)
        {
            var head = context.GetChild<ClassheadContext>(0);
            var name = head.FindFirst<ClassheadnameContext>().GetText();

            CurrentClass = GetClass(name);

            var baseDec = head.FindFirst<BaseclauseContext>();
            if (baseDec != null)
            {
                var baseName = baseDec.FindFirst<BasetypespecifierContext>().GetText();
                CurrentClass.BaseClass = GetClass(baseName);
            }

            Ignore = true;
            VisitChildren(context);

            CurrentClass = null;
            return null;
        }

        public override object VisitMemberdeclaration(MemberdeclarationContext context)
        {
            if (Ignore || CurrentClass == null)
                return null;

            var returnType = context.FindFirst<DeclspecifierseqContext>().GetText();

            var method = new Method();
            method.Name = context.FindFirst<UnqualifiedidContext>().GetText();

            return null;
        }

        public override object VisitAccessspecifier(AccessspecifierContext context)
        {
            Ignore = context.GetText() != "public";
            return null;
        }
    }
}