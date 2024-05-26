using MY.EDocumentArchive.BusinessLogic.Model;
using System;
using System.Windows.Forms;

namespace MY.EDocumentArchive.Presentation
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var appConfig = new ApplicationConfig()
            {
                DatabaseConnection = new SqlServerDatabaseConnection()
                {
                    ServerAddress = "192.168.1.54",
                    Port = 1433,
                    DatabaseName = "MY.EDocumentArchive",
                    Login = new ServerAuthenticate()
                    {
                        Username = "sa",
                        Password = "Admin+1000",
                    },
                },
                ProductUser = new ProductUserInfo()
                {
                    Name = "مدیران یار امید آذر آبادگان",
                    Logo = null,
                },
            };

            AppConfig.ServiceFactoryConfig = new ServiceFactoryConfig(appConfig)
            {
                AutoCommitTransactions = true,
            };

            #region Test
            //var fs = new FormStructure
            //{
            //    Type = 10,
            //    Title = "یبلیبلی",
            //    Description = "222222222"
            //};
            //ServiceFactory<FormStructure>.Save(ref fs);

            //var eew = new EEWModel
            //{
            //    NationalID = "3840100836",
            //    Code = "20",
            //    Name = "پیمان"
            //};
            //ServiceFactory<EEWModel>.Insert(ref eew);

            //var eew = ServiceFactory<EEWModel>.FetchByPrimaryKeys(EEWModel.__PrimaryKeys.NationalID("1377392759"), EEWModel.__PrimaryKeys.Code("10"));
            //eew.Name = "سجاد رفاقت";
            //ServiceFactory<EEWModel>.Update(eew);
            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PersonEditForm(15));
        }
    }
}
