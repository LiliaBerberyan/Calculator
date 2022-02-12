namespace CalculatorProject
{
    class SumOperation : IOperation
    {
        public U Operate<T, U>(T firstParam, T secondParam)
        {
            dynamic first = firstParam;
            dynamic second = secondParam;
            return first + second;
        }
    }
}
