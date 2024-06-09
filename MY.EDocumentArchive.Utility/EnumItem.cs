namespace MY
{
    abstract public class EnumItem
    {
        public int Value { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
