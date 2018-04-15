using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Generator.Metadata;

namespace Generator
{
    public class Filter
    {
        private readonly Regex _replaceRegex = new Regex("(,?[A-Z_]+_API)|(PRAGMA_[A-Z_]+)");
        private IEnumerable<string> _manualImplementedClassMasks;
        private Regex[] _manualImplementedClassMasksRegexes;

        public IEnumerable<string> ClassBlackList { get; set; }
        public IEnumerable<string> NewObjectBlackList { get; set; }
        public IEnumerable<string> EnumBlackList { get; set; }
        public IEnumerable<string> DelegateBlackList { get; set; }
        public IEnumerable<string> ManageClassBlackList { get; set; }
        public IEnumerable<string> ReadOnlyClass { get; set; }
        public Dictionary<string, string> UseConvertToManageType { get; set; }
        public Dictionary<string, string> UseConvertFromManageType { get; set; }
        public Dictionary<string, IEnumerable<string>> MethodInClassBlackList { get; set; }
        public Dictionary<string, IEnumerable<string>> PropertyInClassBlackList { get; set; }

        public IEnumerable<string> ManualImplementedClassMasks
        {
            get => _manualImplementedClassMasks;
            set
            {
                _manualImplementedClassMasks = value;
                _manualImplementedClassMasksRegexes = value.Select(x => new Regex(x)).ToArray();
            }
        }

        public string FilterSourceCode(string code)
        {
            return _replaceRegex.Replace(code, "");
        }

        public List<Class> FilterClasses(IEnumerable<Class> classes)
        {
            var result = classes.Where(MathClass).Where(TypeFilter).OrderBy(cl => cl.Name).ToList();

            foreach (var cl in result)
            {
                cl.IsReadOnly = ReadOnlyClass.Any(name => cl.IsChild(name));

                cl.Methods = cl.Methods.Where(MethodFilter).OrderBy(m => m.Name).ToList();
                cl.Property = cl.Property.Where(PropertyFilter).OrderBy(p => p.Name).ToList();

                FilterConstructors(cl);

                RemoveMethodDublicatedName(cl);
            }

            return result;
        }

        private bool MathClass(Class cl)
        {
            if (_manualImplementedClassMasksRegexes.Any(filter => filter.IsMatch(cl.Name)))
            {
                cl.IsManualImplemented = true;
                cl.IsImplemented = true;
                return false;
            }

            if (cl.IsTemplate)
            {
                return false;
            }

            return true;
        }

        public List<Delegate> FilterDelegates(IEnumerable<Delegate> delegates)
        {
            var result = delegates.Where(TypeFilter).OrderBy(cl => cl.Name).ToList();
            return result;
        }

        public List<Enum> FilterEnum(IEnumerable<Enum> enums)
        {
            return enums.Where(TypeFilter).OrderBy(cl => cl.Name).ToList();
        }

        private void FilterConstructors(Class cl)
        {
            if (!cl.Constructors.Any())
            {
                var ctr = new Method(cl.Name)
                {
                    ReturnType = new ClassVariable(cl),
                    OwnerClass = cl,
                };

                cl.Constructors.Add(ctr);
            }
            else
            {
                cl.Constructors = cl.Constructors.Where(MethodFilter)
                    .Where(m => m.AccessModifier == AccessModifier.Public).OrderBy(m => m.Name).ToList();

                foreach (var m in cl.Constructors)
                {
                    var counter = 0;
                    foreach (var t in m.InputTypes)
                    {
                        t.Name = t.Name ?? "_p" + counter++;
                    }
                }
            }
        }

        private void RemoveMethodDublicatedName(Class cl)
        {
            var primitivs = cl.Methods.Cast<Primitive>().Concat(cl.Property).ToList();

            foreach (var prim in primitivs)
            {
                if (!prim.UMeta.ContainsKey("DisplayName"))
                    continue;

                var name = prim.GetDisplayName();
                var dublicated = primitivs.Where(m => name == m.GetDisplayName()).ToList();

                if (dublicated.Count > 1)
                {
                    dublicated.ForEach(m => m.UMeta.Remove("DisplayName"));
                }
            }
        }

        private bool ClassFilter(Class cl)
        {
            return (cl.BaseClass == null || TypeFilter(cl.BaseClass)) &&
                   !ClassBlackList.Contains(cl.Name);
        }

        private bool EunmFilter(Enum en)
        {
            return en.Fields.Any() &&
                   !EnumBlackList.Contains(en.Name);
        }

        public bool FilterDelegate(Delegate dlg)
        {
            return
                dlg.Dependent.All(TypeFilter) &&
                !DelegateBlackList.Contains(dlg.Name);
        }

        public bool TypeFilter(Type type)
        {
            if (!type.IsImplemented ||
                type.IsTemplate ||
                type.NamespaceBaseType != null)
            {
                return false;
            }

            if (type.TemplateTypes.Any(x => !TypeFilter(x.Type)))
            {
                return false;
            }

            switch (type)
            {
                case Enum en:
                    return EunmFilter(en);
                case Class cl:
                    return ClassFilter(cl);
                case Delegate dlg:
                    return FilterDelegate(dlg);
            }

            return true;
        }

        public bool MethodFilter(Method m)
        {
            return !m.ReturnType.IsConst &&
                   !m.IsOverride &&
                   !m.IsFriend &&
                   !m.IsTemplate &&
                   !m.InputTypes.Any(v => (v.IsPointer && v.IsReference) || v.Type.IsVoid || v.IsReadOnly()) &&
                   (!m.IsVirtual || !m.OwnerClass.IsFinal) &&
                   m.Dependent.All(TypeFilter) &&
                   m.OwnerClass.Methods.Count(x => x.Name == m.Name) <= 1 && // TODO: поддержка перегрузок
                   m.Operator == null &&
                   (m.AccessModifier == AccessModifier.Public || !m.OwnerClass.IsStructure && !m.OwnerClass.IsFinal) &&
                   (!MethodInClassBlackList.ContainsKey(m.OwnerClass.Name) ||
                    !MethodInClassBlackList[m.OwnerClass.Name].Contains(m.Name));
        }

        public bool PropertyFilter(Variable m)
        {
            if (m.AccessModifier != AccessModifier.Public) // todo: экспортировать protected свойства
                return false;

            if (m.IsPointer && (m.Type as Class)?.IsStructure != false)
                return false;

            if (m.IsConst)
                return false;

            if (PropertyInClassBlackList.ContainsKey(m.OwnerClass.Name) &&
                PropertyInClassBlackList[m.OwnerClass.Name].Contains(m.Name))
                return false;

            if (!TypeFilter(m.Type))
                return false;

            return true;
        }

        public IEnumerable<Method> GetVirtualMethods(Class Class)
        {
            if (!IsManageClass(Class))
                return new Method[0];

            return Class.Methods.Where(m => m.IsVirtual &&
                                            !m.IsOverride &&
                                            !m.IsConst &&
                                            m.ReturnType.Type.IsVoid &&
                                            m.InputTypes.All(t => !t.IsReadOnly()));
        }

        public bool IsManageClass(Class Class)
        {
            if (ManageClassBlackList.Contains(Class.Name))
                return false;

            if (Class.IsFinal || Class.IsStructure)
                return false;

            while (Class != null)
            {
                if (Class.Methods.Any(m => m.IsVirtual))
                    return true;

                Class = Class.BaseClass;
            }

            return false;
        }

        public bool GetConvertToManageType(Type type, out string toType)
        {
            if (type.IsTemplate)
            {
                toType = "TemplatePointerDescription";
                return true;
            }

            if ((type as Class)?.IsStructure == false)
            {
                toType = "ObjectPointerDescription";
                return true;
            }

            if (UseConvertToManageType.TryGetValue(type.Name, out toType))
                return true;

            return false;
        }

        public bool IsUseConvertFromManageType(Type type)
        {
            if (UseConvertFromManageType.ContainsKey(type.Name))
                return true;

            return false;
        }
    }
}