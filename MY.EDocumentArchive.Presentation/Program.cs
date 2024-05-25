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
            var fs = new FormStructure
            {
                Type = 5,
                Title = "تست",
                Description = "13242452345342"
            };
            ServiceFactory<FormStructure>.Save(ref fs);



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PersonEditForm(1));


        }
    }
}
