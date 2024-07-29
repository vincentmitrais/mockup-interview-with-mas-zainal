namespace ExampleApp
{
    public class NumberInt : INumber
    {
        public int Value { get; set; }
        public NumberInt(int value) => Value = value;
        public static NumberInt operator +(NumberInt a, NumberInt b) => new NumberInt(a.Value + b.Value);
        public static NumberInt operator +(NumberInt a, NumberDouble b) => new NumberInt(a.Value + (int)b.Value);
        public static NumberInt operator -(NumberInt a, NumberInt b) => new NumberInt(a.Value - b.Value);
        public static NumberInt operator -(NumberInt a, NumberDouble b) => new NumberInt(a.Value - (int)b.Value);
        public override string ToString() => Value.ToString();
    }
}
