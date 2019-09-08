namespace Ripple.BIN
{
    public class Optional<valueType>
    {
        public valueType Value { get; set; }

        public Optional(valueType value)
        {
            this.Value = value;
        }

        public static implicit operator Optional<valueType>(valueType value)
        {
            return new Optional<valueType>(value);
        }

        public static implicit operator valueType(Optional<valueType> optional)
        {
            return optional.Value;
        }
    }
}
