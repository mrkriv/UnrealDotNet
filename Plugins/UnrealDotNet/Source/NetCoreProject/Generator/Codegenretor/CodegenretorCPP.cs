using Generator.Metadata;
using System;
using System.Collections.Generic;
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
                var Classes = domain.Classes.Where(DefaultClassFilter);

                Directory.GetFiles(OutputDir, "*.h").ToList().ForEach(File.Delete);

                foreach (var cl in Classes)
                {
                    GenerateClass(cl, Path.Combine(OutputDir, cl.Name));
                }

                GenerateCPPIndex(Classes, Path.Combine(OutputDir, "Index"));
            }

            private static void GenerateClass(Class Class, string OutputPath)
            {
                var cw = new CoreWriter();

                var methods = Class.Methods.Where(DefaultMethodFilter);
                methods = methods.Where(m => m.Operator == null);

                var index = Class.SourceFile.IndexOf(EnginePathSeg, StringComparison.Ordinal);
                var SourceFile = index == -1
                    ? Class.SourceFile
                    : Class.SourceFile.Substring(index + EnginePathSeg.Length + 1);

                SourceFile = SourceFile.Replace("\\", "/");

                cw.WriteLine("#pragma once");
                cw.WriteLine();
                cw.WriteLine($"#include \"CoreMinimal.h\"");
                cw.WriteLine($"#include \"{SourceFile}\"");

                foreach (var cl in Class.Dependent.Where(cl => cl.IsImplemented && cl.IsStructure && cl != Class))
                {
                    cw.WriteLine($"#include \"{cl.Name}.h\"");
                }

                cw.WriteLine();
                GenerateClassUtilitesTop(cw, Class);

                cw.WriteLine();
                cw.WriteLine("extern \"C\"");
                cw.OpenBlock();

                foreach (var method in methods)
                {
                    GenerateMethod(cw, Class, method);
                }

                cw.CloseBlock();
                cw.SaveToFile(OutputPath + ".h");
            }

            private static void GenerateClassUtilitesTop(CoreWriter cw, Class Class)
            {
                if (Class.IsStructure)
                {
                    cw.WriteLine("extern \"C\"");
                    cw.OpenBlock();

                    cw.WriteLine("typedef struct");
                    cw.OpenBlock();

                    foreach (var prop in Class.Property.Where(p => !p.IsConst))
                    {
                        cw.WriteLine($"{prop.Type} {prop.Name};");
                    }
                    cw.CloseBlock();
                    cw.WriteLine($"E_ST_{Class.Name}, *E_ST_{Class.Name}_REF;");

                    cw.CloseBlock();
                    cw.WriteLine();

                    GenerateStructConvMethodIN(cw, Class);
                    GenerateStructConvMethodTO(cw, Class);
                }
                else
                {
                }
            }

            private static void GenerateStructConvMethodIN(CoreWriter cw, Class Class)
            {
                cw.WriteLine($"FORCEINLINE E_ST_{Class.Name} CONV_ST_{Class.Name}_IN({Class.Name} In)");
                cw.OpenBlock();
                cw.WriteLine($"E_ST_{Class.Name} var;");

                foreach (var prop in Class.Property.Where(p => !p.IsConst))
                {
                    cw.WriteLine($"var.{prop.Name} = In.{prop.Name};");
                }

                cw.WriteLine();
                cw.WriteLine("return var;");
                cw.CloseBlock();
                cw.WriteLine();
            }

            private static void GenerateStructConvMethodTO(CoreWriter cw, Class Class)
            {
                cw.WriteLine($"FORCEINLINE {Class.Name} CONV_ST_{Class.Name}_TO(E_ST_{Class.Name} In)");
                cw.OpenBlock();
                cw.WriteLine($"{Class.Name} var;");

                foreach (var prop in Class.Property.Where(p => !p.IsConst))
                {
                    cw.WriteLine($"var.{prop.Name} = In.{prop.Name};");
                }

                cw.WriteLine();
                cw.WriteLine("return var;");
                cw.CloseBlock();
                cw.WriteLine();
            }

            private static void GenerateMethod(CoreWriter cw, Class Class, Method method)
            {
                var inputs = method.InputTypes.Select(ExportVariableCPP).ToList();

                inputs.Insert(0, Class.IsStructure ? $"E_ST_{Class.Name} Self" : "INT_PTR Self");

                var param = string.Join(", ", inputs);

                cw.WriteLine(
                    $"{CPP_API} {ExportVariableCPP(method.ReturnType)} {GetCPPMethodName(method)}({param})");
                cw.OpenBlock();

                var call = string.Join(", ", Enumerable.Range(0, method.InputTypes.Count).Select(i => "_p" + i));
                for (var i = 0; i < method.InputTypes.Count; i++)
                {
                    var m = method.InputTypes[i];
                    cw.WriteLine($"auto _p{i} = {VarNameForCall(m)};");
                }

                if (!method.ReturnType.IsVoid)
                {
                    cw.Write("return ");
                }

                int CloseBracket = 0;

                var retClass = method.ReturnType as ClassVariable;
                if (retClass != null && retClass.ClassType.IsStructure)
                {
                    cw.Write($"CONV_ST_{retClass.ClassType.Name}_IN(");
                    CloseBracket++;
                }

                if (Class.IsStructure)
                {
                    cw.Write($"CONV_ST_{Class.Name}_TO(Self).{method.Name}({call})");
                }
                else
                {
                    cw.Write($"(({Class.Name}*)Self)->{method.Name}({call})");
                }

                cw.Write(new string(')', CloseBracket));
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

                    return $"CONV_ST_{varClass.ClassType.Name}_TO({varClass.Name})";
                }
                else
                {
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
            }

            private static string GetCPPMethodName(Method method)
            {
                if (method.Operator == null)
                {
                    return ExportPrefix + method.Name;
                }

                return ExportOperatorPrefix + method.Name;
            }

            private static void GenerateCPPIndex(IEnumerable<Class> Classes, string OutputPath)
            {
                var cw = new CoreWriter();
                cw.WriteLine("#pragma warning(push)");
                cw.WriteLine("#pragma warning(disable:4996)");
                cw.WriteLine();

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
                string result;

                var varClass = variable as ClassVariable;
                if (varClass != null && varClass.ClassType.IsStructure)
                {
                    result = $"E_ST_{varClass.ClassType.Name}";

                    //if (varClass.IsReference || varClass.IsPointer)
                    //    result += "_REF";
                }
                else
                {
                    result = variable.GetTypeCPP();
                }

                if (!string.IsNullOrEmpty(variable.Name))
                    result += " " + variable.Name;

                return result;
            }
        }
    }
}