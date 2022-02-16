using System;

namespace CalculatorProject
{
    class Calculator : ICalculator
    {
        private readonly Func<ConsoleKey, IOperation> _operation;
        public Calculator(Func<ConsoleKey, IOperation> operation)
        {
            _operation = operation;
        }
        public U Count<U, T>(ConsoleKey key, T firstParam, T secondParam)
        {
            IOperation operation = _operation(key);
            return operation.Operate<T, U>(firstParam, secondParam);
        }
    }
}
