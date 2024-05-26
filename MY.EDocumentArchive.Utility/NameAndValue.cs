namespace MY
{
    sealed public class NameAndValue
    {
        public NameAndValue(string name, object value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; set; }
        public object Value { get; set; }
    }
}
