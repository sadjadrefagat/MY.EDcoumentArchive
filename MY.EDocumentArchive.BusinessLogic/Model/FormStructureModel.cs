using MY.EDocumentArchive.Model;

namespace MY.EDocumentArchive.BusinessLogic.Model
{
    sealed public class FormStructureModel : FormStructure
    {
        public FormStructureModel()
        {
        }

        public new FormStructureType Type
        {
            get
            {
                return FormStructureType.GetByValue(base.Type);
            }
            set
            {
                base.Type = value.Value;
            }
        }
    }
}
