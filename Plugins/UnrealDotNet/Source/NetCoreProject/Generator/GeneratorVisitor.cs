using System.Collections.Generic;
using static CPP14Parser;

namespace Generator
{
    public class GeneratorVisitor : CPP14BaseVisitor<object>
    {
        private CoreWriter cs;
        private bool Ignore;

        public override object VisitClassspecifier(ClassspecifierContext context)
        {
            var head = context.GetChild<ClassheadContext>(0);
            var name = head.GetChild<ClassheadnameContext>(0).GetText();

            using (cs = new CoreWriter($"{name}.cs"))
            {
                cs.WriteLine("using System;");
                cs.WriteLine("using System.Runtime.InteropServices;");
                cs.WriteLine();
                cs.WriteLine("namespace UnrealEngine");
                cs.OpenBlock();

                cs.Write($"public partial class {name}");

                var baseDec = head.GetChild<BaseclauseContext>(0);
                if (baseDec != null)
                {
                    var baseName = baseDec.FindFirst<BasetypespecifierContext>().GetText();
                    cs.Write($": {baseName}");
                }
                cs.WriteLine();
                cs.OpenBlock();

                Ignore = true;
                VisitChildren(context);

                cs.CloseBlock();
                cs.CloseBlock();
            }

            return null;
        }

        public override object VisitMemberdeclaration(MemberdeclarationContext context)
        {
            if (Ignore)
                return null;

            var returnType = context.FindFirst<DeclspecifierseqContext>().GetText();
            var name = context.FindFirst<UnqualifiedidContext>().GetText();

            cs.Write($"public {returnType} {name}()");
            cs.WriteLine();

            cs.OpenBlock();

            cs.CloseBlock();
            cs.WriteLine();
            return null;
        }

        public override object VisitAccessspecifier(AccessspecifierContext context)
        {
            Ignore = context.GetText() != "public";
            return null;
        }

        private IEnumerable<KeyValuePair<string, string>> GetParams()
        {
            return null;
        }
    }
}