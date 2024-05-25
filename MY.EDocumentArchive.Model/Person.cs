namespace MY.EDocumentArchive.Model
{
    public class Person : BaseEntity
    {
        public Person()
            : base("General", "Person")
        {
        }

        [NoInsert]
        [PrimaryKey]
        public long PersonID { get; set; }

        public int Type { get; set; }

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
