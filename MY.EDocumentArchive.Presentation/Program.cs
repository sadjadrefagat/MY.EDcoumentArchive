using MY.EDocumentArchive.Model;
using System;
using System.Windows.Forms;

namespace MY.EDocumentArchive.Presentation
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var fs = new FormStructure();
            fs.Type = 5;
            fs.Title = "تست";
            fs.Description = "13242452345342";
            ServiceFactory<FormStructure>.Save(ref fs);



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PersonEditForm(1));


        }
    }
}
