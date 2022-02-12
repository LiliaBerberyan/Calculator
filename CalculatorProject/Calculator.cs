using System;

namespace CalculatorProject
{
    class Calculator<U, T>
    {
        private readonly Func<ConsoleKey, IOperation> _operation;
        public Calculator(Func<ConsoleKey, IOperation> operation)
        {
            _operation = operation;
        }
        public U Count(ConsoleKey key, T firstParam, T secondParam)
        {
            IOperation operation = _operation(key);
            return operation.Operate<T, U>(firstParam, secondParam);
        }

    }
}
