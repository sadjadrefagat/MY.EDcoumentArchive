namespace MY.EDocumentArchive.Model
{
    public partial class Person : BaseEntity
    {
        public Person()
            : base("General", "Person")
        {
        }

        [NoInsert]
        [PrimaryKey]
        [AutoIdentity]
        public long PersonID { get; set; }

        public int Type { get; set; }

        public int Length { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Name { get; set; }

        [NoInsert]
        [NoSelect]
        public string FullName
        {
            get
            {
                if (Type == 0)
                    return $"{FirstName} {LastName}";
                return Name;
            }
        }

        public string NationalID { get; set; }
    }
}
