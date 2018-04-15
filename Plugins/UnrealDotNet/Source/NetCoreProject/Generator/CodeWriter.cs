using System.IO;
using System.Linq;
using System.Text;

namespace Generator
{
    public class CodeWriter
    {
        private StringBuilder _sb = new StringBuilder();
        private int _tab;

        public CodeWriter()
        {
        }

        public CodeWriter(CodeWriter codeWriter)
        {
            _tab = codeWriter._tab;
        }

        public void Write(bool needWrite, string text)
        {
            if (needWrite)
                _sb.Append(text);
        }

        public void Write(CodeWriter codeWriter)
        {
            _sb.Append(codeWriter._sb);
        }

        public void Write(string text)
        {
            _sb.Append(text);
        }

        public void WriteLine(bool needWrite, string line)
        {
            if (needWrite)
            {
                _sb.AppendLine(line);
                WriteTab();
            }
        }

        public void WriteLineNoTab(string line)
        {
            _sb.Remove(_sb.Length - 1, 1);
            _sb.AppendLine(line);
            WriteTab();
        }

        public void WriteNoTab(string line)
        {
            _sb.Remove(_sb.Length - 1, 1);
            _sb.Append(line);
        }

        public void WriteLine(string line)
        {
            _sb.AppendLine(line);
            WriteTab();
        }

        public void WriteLine()
        {
            _sb.AppendLine();
            WriteTab();
        }

        public void WriteLine(string format, params object[] arg)
        {
            WriteLine(string.Format(format, arg));
        }

        public void OpenBlock()
        {
            _sb.Append("{");
            _tab++;
            WriteLine();
        }

        public void CloseBlock()
        {
            _tab--;
            _sb.Remove(_sb.Length - 1, 1);
            _sb.AppendLine("}");
        }

        private void WriteTab()
        {
            _sb.Append(new string('\t', _tab));
        }

        public bool IsEmpty()
        {
            return _sb.Length == 0;
        }

        public override string ToString()
        {
            return _sb.ToString();
        }

        public void SaveToFile(string filePath)
        {
            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            }

            File.WriteAllText(filePath, _sb.ToString());
        }
    }
}