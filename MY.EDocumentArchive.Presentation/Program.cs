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
                Type = 10,
                Title = "یبلیبلی",
                Description = "222222222"
            };
            ServiceFactory<FormStructure>.Save(ref fs);



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PersonEditForm());
        }
    }
}
