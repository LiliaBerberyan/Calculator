using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    interface ICalculator
    {
        U Count<U, T>(ConsoleKey key, T firstParam, T secondParam);
    }
}
