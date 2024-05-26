namespace MY.EDocumentArchive.BusinessLogic
{
    //public enum PersonType
    //{
    //    شخص = 10,
    //    شرکت = 20,
    //    متفرقه = 30,
    //}

    public class PersonType : EnumItem
    {
        static public PersonType GetByValue(int value)
        {
            switch (value)
            {
                case 10:
                    return شخص;
                case 20:
                    return شرکت;
                case 30:
                    return متفرقه;
            }
            return null;
        }

        static public PersonType شخص = new PersonType()
        {
            Value = 10,
            Text = "شخص",
        };

        static public PersonType شرکت = new PersonType()
        {
            Value = 20,
            Text = "شرکت",
        };

        static public PersonType متفرقه = new PersonType()
        {
            Value = 30,
            Text = "متفرقه",
        };

    }
}