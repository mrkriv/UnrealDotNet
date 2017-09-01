using System.IO;
using System.Linq;
using System.Text;

namespace Generator
{
    public class CoreWriter
    {
        private StringBuilder sb = new StringBuilder();
        private int tab;

        public CoreWriter()
        {
        }

        public CoreWriter(CoreWriter CoreWriter)
        {
            tab = CoreWriter.tab;
        }

        public void Write(bool NeedWrite, string Text)
        {
            if (NeedWrite)
                sb.Append(Text);
        }

        public void Write(CoreWriter CoreWriter)
        {
            sb.Append(CoreWriter.sb);
        }

        public void Write(string Text)
        {
            sb.Append(Text);
        }

        public void WriteLine(bool NeedWrite, string Line)
        {
            if (NeedWrite)
            {
                sb.AppendLine(Line);
                WriteTab();
            }
        }

        public void WriteLine(string Line)
        {
            sb.AppendLine(Line);
            WriteTab();
        }

        public void WriteLine()
        {
            sb.AppendLine();
            WriteTab();
        }

        public void WriteLine(string format, params object[] arg)
        {
            WriteLine(string.Format(format, arg));
        }

        public void OpenBlock()
        {
            sb.Append("{");
            tab++;
            WriteLine();
        }

        public void CloseBlock()
        {
            tab--;
            sb.Remove(sb.Length - 1, 1);
            sb.AppendLine("}");
        }

        private void WriteTab()
        {
            sb.Append(new string('\t', tab));
        }

        public bool IsEmpty()
        {
            return sb.Length == 0;
        }

        public override string ToString()
        {
            return sb.ToString();
        }

        public void SaveToFile(string FilePath)
        {
            if (!Directory.Exists(Path.GetDirectoryName(FilePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(FilePath));
            }

            File.WriteAllText(FilePath, sb.ToString());
        }
    }
}