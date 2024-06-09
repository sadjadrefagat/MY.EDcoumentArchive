namespace MY.EDocumentArchive.Model
{
    public partial class FormStructure : BaseEntity
    {
        public FormStructure()
            : base("Form", "FormStructure")
        {
        }

        [NoInsert]
        [PrimaryKey]
        [AutoIdentity]
        public long FormStructureID { get; set; }

        public int Type { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
