namespace ExampleApp
{
    public class Calculator<T, U> : ICalculator<T, U>
        where T : INumber
        where U : INumber
    {
      public T Add(T a, U b)
        {
            return (dynamic)a + (dynamic)b;
        }

        public T Subtract(T a, U b)
        {
            return (dynamic)a - (dynamic)b;
        }
    }
}
