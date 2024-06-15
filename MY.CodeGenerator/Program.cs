using System;
using System.Windows.Forms;

namespace MY.CodeGenerator
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GeneratorForm());
        }

        static public void WaitCursor()
        {
            Cursor.Current = Cursors.WaitCursor;
        }

        static public void DefaultCursor()
        {
            Cursor.Current = Cursors.Default;
        }
    }
}
