namespace MY.EDocumentArchive.Model
{
    public partial class EEW
    {
        static public EEWPrimaryKeys __PrimaryKeys = new EEWPrimaryKeys();

        public class EEWPrimaryKeys
        {
            public NameAndValue NationalID(string value) { return new NameAndValue("NationalID", value); }
            public NameAndValue Code(string value) { return new NameAndValue("Code", value); }
        }
    }
}
