namespace ExampleApp
{
    public class NumberDouble : INumber
    {
        public double Value { get; set; }
        public NumberDouble(double value) => Value = value;
        public static NumberDouble operator +(NumberDouble a, NumberDouble b) => new NumberDouble(a.Value + b.Value);
        public static NumberDouble operator +(NumberDouble a, NumberInt b) => new NumberDouble(a.Value + b.Value);
        public static NumberDouble operator -(NumberDouble a, NumberDouble b) => new NumberDouble(a.Value - b.Value);
        public static NumberDouble operator -(NumberDouble a, NumberInt b) => new NumberDouble(a.Value - b.Value);
        public override string ToString() => Value.ToString();
    }
}
