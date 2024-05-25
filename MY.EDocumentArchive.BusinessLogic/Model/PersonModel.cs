using MY.EDocumentArchive.Model;

namespace MY.EDocumentArchive.BusinessLogic.Model
{
    sealed public class PersonModel : Person
    {
        public PersonModel()
        {
        }

        public new PersonType Type { get; set; }
    }
}
