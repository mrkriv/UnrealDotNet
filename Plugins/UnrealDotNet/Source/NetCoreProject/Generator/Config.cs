namespace Generator
{
    public class Config
    {
        public Filter Filter { get; set; }

        public string DllEditorImportName { get; set; }
        public string DllPaksImportName { get; set; }
        public string EnginePathSeg { get; set; }
        public string ExportPrefix { get; set; }
        public string ExportOperatorPrefix { get; set; }
        public string ExportPropertyPrefix { get; set; }
        public string ExportProtectedPrefix { get; set; }
        public string ExportProtectedPostfix { get; set; }
        public string ExportEventAddPrefix { get; set; }
        public string ExportEventRemovePrefix { get; set; }
        public string EventPrivatePrefix { get; set; }
        public string EventInvokePrefix { get; set; }
        public string EventPropertyGetPostfix { get; set; }
        public string EventPropertySetPostfix { get; set; }
        public string CppPch { get; set; }
        public string CppApi { get; set; }
        public string CppApiUe { get; set; }
        public bool IsWriteSourceFileName { get; set; }
    }
}