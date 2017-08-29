using Generator.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;

namespace Generator
{
    internal partial class Codegenretor
    {
        private class CPP
        {
            public static void GenarateDomain(Domain domain, string OutputDir)
            {
                Directory.GetFiles(OutputDir, "*.h").ToList().ForEach(File.Delete);

                foreach (var cl in domain.Classes.Where(c => !c.IsStructure))
                {
                    GenerateClass(cl, Path.Combine(OutputDir, cl.Name));
                }

                GenerateStructs(domain.Classes.Where(c => c.IsStructure), Path.Combine(OutputDir, "Structures"));
                GenerateCPPIndex(domain.Classes.Where(c => !c.IsStructure), Path.Combine(OutputDir, "Index"));
            }

            #region Class

            private static void GenerateClass(Class Class, string OutputPath)
            {
                var cw = new CoreWriter();

                cw.WriteLine("#pragma once");
                cw.WriteLine();
                cw.WriteLine($"#include \"CoreMinimal.h\"");
                cw.WriteLine($"#include \"{GetSourceFileName(Class)}\"");

                GenerateProtctedWrap(cw, Class);

                cw.WriteLine();
                cw.WriteLine("extern \"C\"");
                cw.OpenBlock();

                foreach (var prop in Class.Property.Where(p => !p.IsConst && p.AccessModifier == AccessModifier.Public))
                {
                    GenerateProperty(cw, Class, prop);
                }

                foreach (var method in Class.Methods)
                {
                    GenerateMethod(cw, method);
                }

                cw.CloseBlock();

                cw.SaveToFile(OutputPath + ".h");
            }

            private static void GenerateProtctedWrap(CoreWriter cw, Class Class)
            {
                var methods = Class.Methods.Where(m => m.AccessModifier == AccessModifier.Protected);

                if (!methods.Any())
                    return;

                cw.WriteLine();
                cw.WriteLine($"class {ExportProtectedPrefix}{Class.Name} : protected {Class.Name}");
                cw.OpenBlock();
                cw.WriteLine("public:");

                foreach (var mt in methods)
                {
                    GenerateMethodProtctedWrap(cw, mt);
                }

                cw.CloseBlock();
                cw.Write(";");
                cw.WriteLine();
            }

            private static string GetSourceFileName(Class Class)
            {
                var index = Class.SourceFile.IndexOf(EnginePathSeg, StringComparison.Ordinal);
                var SourceFile = index == -1
                    ? Class.SourceFile
                    : Class.SourceFile.Substring(index + EnginePathSeg.Length + 1);

                SourceFile = SourceFile.Replace("\\", "/");
                return SourceFile;
            }

            private static void GenerateMethod(CoreWriter cw, Method method)
            {
                var inputs = method.InputTypes.Select(ExportVariableCPP).ToList();
                inputs.Insert(0, "INT_PTR Self");

                var param = string.Join(", ", inputs);

                cw.WriteLine(
                    $"{CPP_API} {ExportVariableCPP(method.ReturnType)} {GetCPPMethodName(method)}({param})");
                cw.OpenBlock();

                for (var i = 0; i < method.InputTypes.Count; i++)
                {
                    var m = method.InputTypes[i];
                    cw.WriteLine($"auto _p{i} = {VarNameForCall(m)};");
                }

                cw.Write(method.ReturnType.Type != "void", "return ");

                var needClose = false;
                var retClass = method.ReturnType as ClassVariable;

                if (retClass != null && retClass.ClassType.IsStructure)
                {
                    cw.Write($"(INT_PTR) new {retClass.ClassType.Name}(");
                    needClose = true;
                }

                var call = string.Join(", ", Enumerable.Range(0, method.InputTypes.Count).Select(i =>
                {
                    if (method.InputTypes[i].NeedRefOperator())
                        return "&_p" + i;
                    return "_p" + i;
                }));

                if (method.AccessModifier == AccessModifier.Public)
                {
                    cw.Write($"(({method.OwnerClass.Name}*)Self)->{method.Name}({call})");
                }
                else
                {
                    cw.Write($"(({ExportProtectedPrefix}{method.OwnerClass.Name}*)Self)->{method.Name}{ExportProtectedPostfix}({call})");
                }

                cw.Write(needClose, ")");
                cw.WriteLine(";");

                cw.CloseBlock();
                cw.WriteLine();
            }

            private static void GenerateMethodProtctedWrap(CoreWriter cw, Method method)
            {
                var param = string.Join(", ", method.InputTypes.Select(ExportVariableCPP));

                cw.WriteLine(
                    $"{ExportVariableCPP(method.ReturnType)} {method.Name}{ExportProtectedPostfix}({param})");
                cw.OpenBlock();

                for (var i = 0; i < method.InputTypes.Count; i++)
                {
                    var m = method.InputTypes[i];
                    cw.WriteLine($"auto _p{i} = {VarNameForCall(m)};");
                }

                cw.Write(method.ReturnType.Type != "void", "return ");

                var needClose = false;
                var retClass = method.ReturnType as ClassVariable;

                if (retClass != null && retClass.ClassType.IsStructure)
                {
                    cw.Write($"(INT_PTR) new {retClass.ClassType.Name}(");
                    needClose = true;
                }

                var call = string.Join(", ", Enumerable.Range(0, method.InputTypes.Count).Select(i =>
                {
                    if (method.InputTypes[i].NeedRefOperator())
                        return "&_p" + i;
                    return "_p" + i;
                }));

                cw.Write($"{method.Name}({call})");
                cw.Write(needClose, ")");
                cw.WriteLine(";");

                cw.CloseBlock();
                cw.WriteLine();
            }

            private static string VarNameForCall(Variable variable)
            {
                var varClass = variable as ClassVariable;
                if (varClass != null)
                {
                    if (!varClass.ClassType.IsStructure)
                        return varClass.Name;

                    return $"*({varClass.ClassType.Name}*){varClass.Name}";
                }

                var result = "";
                var needClose = true;

                if (variable.Type == "TCHAR")
                {
                    result += "UTF8_TO_TCHAR(";
                }
                else if (variable.Type == "FString")
                {
                    result += "TEXT(";
                }
                else
                {
                    needClose = false;
                }

                result += variable.Name;

                if (needClose)
                    result += ")";

                return result;
            }

            #endregion Class

            #region Struct

            private static void GenerateStructs(IEnumerable<Class> Structures, string OutputPath)
            {
                var cw = new CoreWriter();

                cw.WriteLine("#pragma once");
                cw.WriteLine();
                cw.WriteLine($"#include \"CoreMinimal.h\"");

                foreach (var header in Structures.Select(GetSourceFileName).Distinct())
                {
                    cw.WriteLine($"#include \"{header}\"");
                }

                cw.WriteLine();
                cw.WriteLine("extern \"C\"");
                cw.OpenBlock();

                foreach (var Class in Structures)
                {
                    cw.WriteLine();
                    cw.WriteLine($"/*\t{Class.Name}\t*/");
                    cw.WriteLine();

                    GenerateStructUtilites(cw, Class);

                    foreach (var method in Class.Methods.Where(m => m.AccessModifier == AccessModifier.Public))
                    {
                        GenerateMethod(cw, method);
                    }
                }

                cw.CloseBlock();

                cw.SaveToFile(OutputPath + ".h");
            }

            private static void GenerateStructUtilites(CoreWriter cw, Class Class)
            {
                cw.Write($"{CPP_API} INT_PTR E_CreateStruct_{Class.Name}() {{ ");
                cw.WriteLine($"return (INT_PTR) new {Class.Name}(); }}");
                cw.WriteLine();

                foreach (var prop in Class.Property.Where(p => !p.IsConst && p.AccessModifier == AccessModifier.Public))
                {
                    GenerateProperty(cw, Class, prop);
                }
            }

            private static void GenerateProperty(CoreWriter cw, Class Class, Variable prop)
            {
                var baseName = $"{ExportPropertyPrefix}{Class.Name}_{prop.Name}";

                var propClass = prop as ClassVariable;
                if (propClass?.ClassType.IsStructure == true)
                {
                    var clName = propClass.ClassType.Name;
                    cw.WriteLine(
                        $"{CPP_API} {prop.GetTypeCPP()} {baseName}_GET(INT_PTR Ptr) {{ return (INT_PTR) new {clName}((({Class.Name}*)Ptr)->{prop.Name}); }}");

                    cw.WriteLine(
                        $"{CPP_API} void {baseName}_SET(INT_PTR Ptr, {prop.GetTypeCPP()} Value) {{ (({Class.Name}*)Ptr)->{prop.Name} = *({clName}*)Value; }}");
                }
                else
                {
                    cw.WriteLine(
                        $"{CPP_API} {prop.GetTypeCPP()} {baseName}_GET(INT_PTR Ptr) {{ return (({Class.Name}*)Ptr)->{prop.Name}; }}");

                    cw.WriteLine(
                        $"{CPP_API} void {baseName}_SET(INT_PTR Ptr, {prop.GetTypeCPP()} Value) {{ (({Class.Name}*)Ptr)->{prop.Name} = Value; }}");
                }

                cw.WriteLine();
            }

            #endregion Struct

            private static void GenerateCPPIndex(IEnumerable<Class> Classes, string OutputPath)
            {
                var cw = new CoreWriter();
                cw.WriteLine("#pragma warning(push)");
                cw.WriteLine("#pragma warning(disable:4996)");
                cw.WriteLine();

                cw.WriteLine($"#include \"Structures.h\"");

                foreach (var Class in Classes)
                {
                    cw.WriteLine($"#include \"{Class.Name}.h\"");
                }

                cw.WriteLine();
                cw.WriteLine("#pragma warning(pop)");
                cw.SaveToFile(OutputPath + ".h");
            }

            private static string ExportVariableCPP(Variable variable)
            {
                var result = variable.GetTypeCPP();

                if (!string.IsNullOrEmpty(variable.Name))
                    result += " " + variable.Name;

                return result;
            }
        }
    }
}