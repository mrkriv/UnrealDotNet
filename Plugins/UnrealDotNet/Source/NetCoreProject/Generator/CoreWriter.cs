using System;
using System.IO;

namespace Generator
{
    public class CoreWriter : IDisposable
    {
        private readonly TextWriter tw;
        private int tab;

        public CoreWriter(string FilePath)
        {
            tw = new StreamWriter(FilePath);
        }

        public CoreWriter(TextWriter tw)
        {
            this.tw = tw;
        }

        public void Write(string Text)
        {
            tw.Write(Text);
        }

        public void WriteLine(string Line)
        {
            tw.WriteLine(Line);
            WriteTab();
        }

        public void WriteLine()
        {
            tw.WriteLine();
            WriteTab();
        }

        public void WriteLine(string format, params object[] arg)
        {
            WriteLine(string.Format(format, arg));
        }

        public void OpenBlock()
        {
            tw.Write("{");
            tab++;
            WriteLine();
        }

        public void CloseBlock()
        {
            tab--;
            WriteLine();
            tw.Write("}");
        }

        private void WriteTab()
        {
            tw.Write(new string('\t', tab));
        }

        public override string ToString()
        {
            return tw.ToString();
        }

        public void Dispose()
        {
            tw.Dispose();
        }
    }
}