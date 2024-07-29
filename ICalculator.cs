namespace ExampleApp
{
    public interface ICalculator<T, U> 
        where T : INumber
        where U : INumber
    {
        public T Add(T a, U b);
        public T Subtract(T a, U b);
    }
}
