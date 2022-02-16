using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    internal interface ICalculatorCreator
    {
        IEnumerable<IOperation> GetOperations();
        Calculator CreateCalculator(Func<ConsoleKey, IOperation> operation);
    }
}
