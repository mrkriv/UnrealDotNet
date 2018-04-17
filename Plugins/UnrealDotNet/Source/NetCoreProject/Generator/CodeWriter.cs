using System.IO;
using System.Runtime.CompilerServices;
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(bool needWrite, string text)
        {
            if (needWrite)
                _sb.Append(text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(CodeWriter codeWriter)
        {
            _sb.Append(codeWriter._sb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(string text)
        {
            _sb.Append(text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLine(bool needWrite, string line)
        {
            if (needWrite)
            {
                _sb.AppendLine(line);
                WriteTab();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLineNoTab(string line)
        {
            _sb.Remove(_sb.Length - 1, 1);
            _sb.AppendLine(line);
            WriteTab();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteNoTab(string line)
        {
            _sb.Remove(_sb.Length - 1, 1);
            _sb.Append(line);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteNoTabLine(string line)
        {
            _sb.Remove(_sb.Length - 1, 1);
            _sb.AppendLine(line);
            WriteTab();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLine(string line)
        {
            _sb.AppendLine(line);
            WriteTab();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLine()
        {
            _sb.AppendLine();
            WriteTab();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLine(string format, params object[] arg)
        {
            WriteLine(string.Format(format, arg));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OpenBlock()
        {
            _sb.Append("{");
            _tab++;
            WriteLine();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CloseBlock()
        {
            _tab--;
            _sb.Remove(_sb.Length - 1, 1);
            _sb.AppendLine("}");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void WriteTab()
        {
            _sb.Append(new string('\t', _tab));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsEmpty()
        {
            return _sb.Length == 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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