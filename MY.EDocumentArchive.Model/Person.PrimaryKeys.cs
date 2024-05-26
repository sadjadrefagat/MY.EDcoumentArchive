namespace MY.EDocumentArchive.Model
{
    public partial class Person
    {
        static public PersonPrimaryKeys __PrimaryKeys = new PersonPrimaryKeys();

        public class PersonPrimaryKeys
        {
            public NameAndValue PersonID(long value) { return new NameAndValue("PersonID", value); }
        }
    }
}
