using System;

namespace CalculatorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            StartWork();
        }
        public static void StartWork()
        {
            Func<ConsoleKey, IOperation> operation = GetOperation;
            ICalculatorCreator creator = new CalculatorCreater();
            ICalculator calculator = creator.CreateCalculator(operation);
            ConsoleOperations(calculator);
        }
        public static void ConsoleOperations(ICalculator calculator)
        {
            Console.WriteLine("Calculator\nYou can do + - / * operations");

            while (true)
            {
                Console.WriteLine("Write first number");
                var number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Write operation");
                ConsoleKey key = Console.ReadKey().Key;
                Console.WriteLine("\nWrite second number");
                var number2 = int.Parse(Console.ReadLine());
                var result = calculator.Count<double, double>(key, number1, number2);
                Console.WriteLine($"result={result}");
                History.Add(number1, number2, key, result);
                Console.ReadKey();
            }
        }
        public static IOperation GetOperation(ConsoleKey key)
        {
            IOperation operation = null;
            switch (key)
            {
                case ConsoleKey.OemPlus:
                    operation = new SumOperation();
                    break;
                case ConsoleKey.OemMinus:
                    operation = new MinusOperation();
                    break;
                case ConsoleKey.D8:
                    operation = new MultiplyOperation();
                    break;
                case ConsoleKey.Oem2:
                    operation = new DivideOperation();
                    break;
            }
            return operation;
        }
    }
}
