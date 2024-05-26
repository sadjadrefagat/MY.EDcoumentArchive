namespace MY.EDocumentArchive.Model
{
    public partial class EEW : BaseEntity
    {
        public EEW()
            : base("dbo", "EEW")
        {
        }

        [PrimaryKey]
        public string NationalID { get; set; }

        [PrimaryKey]
        public string Code { get; set; }

        [NoInsert]
        [AutoIdentity]
        public long AutoID { get; set; }

        public string Name { get; set; }
    }
}
