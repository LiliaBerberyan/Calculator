using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    class CalculatorCreater : ICalculatorCreator
    {
        private List<IOperation> operations = new List<IOperation>();
        private Func<ConsoleKey, IOperation> _operation;
        public Calculator CreateCalculator(Func<ConsoleKey, IOperation> operation)
        {
            var operations = GetOperations();
            _operation = operation;
            return new Calculator(_operation);
        }
        public IEnumerable<IOperation> GetOperations()
        {
            Type[] types = Assembly.GetExecutingAssembly().GetTypes();
            for (int i = 0; i < types.Length; i++)
            {
                if (types[i] is IOperation)
                {
                    operations.Add((IOperation)types[i]);
                }
            }
            return new List<IOperation>();
        }
    }
}
