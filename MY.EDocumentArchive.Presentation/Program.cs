using MY.EDocumentArchive.BusinessLogic;
using MY.EDocumentArchive.BusinessLogic.Model;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace MY.EDocumentArchive.Presentation
{
    internal static class Program
    {
        static private void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }

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
            AppConfig.ShowErrorMessage = ShowError;

            #region Test
            //var ps = ServiceFactory<PersonModel>.FetchByFilter(p =>
            //    Convert.IsDBNull(p.Name) &&
            //    p.FirstName == p.LastName &&
            //    (
            //        Convert.ToInt64(p.NationalID) % 2 != 0 ||
            //        p.NationalID.Length == 9
            //    ) &&
            //    p.Type == PersonType.شرکت);
            //var p1 = ServiceFactory<PersonModel>.FetchByFilter(p => p.Length * 4 == 3);

            //var pt = Activator.CreateInstance(type);

            //var i = 0;
            //var ps2 = ServiceFactory<PersonModel>.FetchByFilter(p =>
            //Convert.IsDBNull(p.Name) &&
            //(
            //    p.FirstName == p.LastName ||
            //    p.Name.Contains(")") ||
            //    p.Name.Contains(string.Format("{0} {1} ({0})", p.FirstName, p.LastName + p.NationalID)) ||
            //    p.Name.Contains($"ID={p.FirstName}\"5\"") ||
            //    Convert.ToInt64(p.NationalID) % 2 != 30 * 500
            //) &&
            //p.Length * 4 == 3 &&
            //"abcde".Length == 5 &&
            //p.NationalID.Length == 9 &&
            //p.Type == PersonType.شرکت);
            //.Name.IsDbNull()
            //.And()
            //.FirstName.Equals().LastName
            //.And()
            //.Begin()
            //    .NationalID.ToInt64().Mode(2).NotEquals().Const<int>(0)
            //    .Or()
            //    .NationalID.Length().Equals().Const<int>(9)
            //.End()
            //.Type.Equals().Enum<PersonType>().شخص;


            //var ps = ServiceFactory<PersonModel>.FetchByFilter(p =>
            //    Convert.IsDBNull(p.Name) &&
            //    p.FirstName == p.LastName &&
            //    Convert.ToInt64(p.NationalID) % 2 != 0 &&
            //    p.NationalID.Length == 9
            //    p.Type == PersonType.شرکت);


            //var ps2 = ServiceFactory<PersonModel>.FetchByFilter()
            //        .Name.IsDbNull()
            //        .And()
            //        .FirstName.Equals().LastName
            //        .And()
            //        .NationalID.ToInt64().Mode(2).NotEquals().Const<int>(0)
            //        .And()
            //        .NationalID.Length().Equals().Const<int>(9)
            //        .Type.Equals().Enum<PersonType>().شخص;


            //var ps3 = ServiceFactory<PersonModel>.FetchByFilter(p => p.Type == PersonType.شرکت);

            //var ps4 = ServiceFactory<PersonModel>.FetchByFilter().Type.Equals(PersonType.شرکت);


            //ServiceFactory<PersonModel>.FetchByFilter(Equal(PersonModel.__Fields.Type, PersonType.شخص).And(StartWith(PersonModel.__Fields.Name, "س")));

            //var fs1 = new FormStructureModel
            //{
            //    Type = FormStructureType.پرونده_مشتری,
            //    Title = "تست 3",
            //    Description = "333"
            //};

            //var fs2 = new FormStructureModel
            //{
            //    Type = FormStructureType.سند,
            //    Title = "تست 3",
            //    Description = "4444"
            //};

            //var tran = ServiceTransaction.CreateTransaction();

            //var service = new ServiceFactory<FormStructureModel>();
            //service.Insert(ref fs1, transaction: tran);

            //if (!tran.HasError)
            //    service.Insert(ref fs2, transaction: tran);

            //tran.Finish();

            //if (tran.HasError)
            //    ShowError(tran.GetErrorMessages().Combine());

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

            var fsList = ServiceFactory<FormStructureModel>.FetchAll();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var culture = CultureInfo.CreateSpecificCulture("fa-IR");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            //DevExpress.XtraEditors.WindowsFormsSettings.PreferredDateTimeCulture = DevExpress.XtraEditors.DateTimeCulture.CurrentCulture;

            Application.Run(new PersonEditForm(15));
        }
    }
}
