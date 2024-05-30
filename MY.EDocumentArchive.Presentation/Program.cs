using MY.EDocumentArchive.BusinessLogic;
using MY.EDocumentArchive.BusinessLogic.Model;
using System;
using System.Windows.Forms;

namespace MY.EDocumentArchive.Presentation
{
    internal static class Program
    {
        static private string NationalCodeControlBit(string nationalID)
        {
            return "";
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

            //var ps = ServiceFactory<PersonModel>.FetchByFilter(p =>
            //    Convert.IsDBNull(p.Name) &&
            //    p.FirstName == p.LastName &&
            //    (
            //        Convert.ToInt64(p.NationalID) % 2 != 0 ||
            //        p.NationalID.Length == 9
            //    ) &&
            //    p.Type == PersonType.شرکت);

            var ps2 = new ServiceFactory<PersonModel>().
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
