namespace MY.EDocumentArchive.BusinessLogic
{
    sealed public class FormStructureType : EnumItem
    {
        static public FormStructureType GetByValue(int value)
        {
            switch (value)
            {
                case 1:
                    return پرونده_مشتری;
                case 2:
                    return سند;
                default:
                    return null;
            }
        }

        static public FormStructureType پرونده_مشتری = new FormStructureType()
        {
            Value = 1,
            Text = "پرونده مشتری",
        };

        static public FormStructureType سند = new FormStructureType()
        {
            Value = 2,
            Text = "سند",
        };
    }
}
