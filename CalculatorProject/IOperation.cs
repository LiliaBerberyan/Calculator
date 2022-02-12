namespace CalculatorProject
{
    interface IOperation
    {
        U Operate<T, U>(T firstParam, T secondParam);
    }
}
