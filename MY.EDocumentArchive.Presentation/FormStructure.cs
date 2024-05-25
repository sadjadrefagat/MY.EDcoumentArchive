namespace MY.EDocumentArchive.Presentation
{
    sealed public class FormStructure : BaseEntity
    {
        public FormStructure()
            : base("Form", "FormStructure")
        {
        }

        [NoInsert]
        [PrimaryKey]
        public long FormStructureID { get; set; }

        public int Type { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
