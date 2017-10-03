using System;

namespace Generator.Metadata
{
    public abstract class Type : Primitive
    {
        public Type NamespaceBaseType { get; set; }
        public bool IsImplemented { get; set; }
        public string SourceFile { get; set; }
        public Domain Domain { get; set; }

        public bool IsVoid => Name == "void";

        public string FullName => NamespaceBaseType != null ? NamespaceBaseType.FullName + "." + Name : Name;
    }
}