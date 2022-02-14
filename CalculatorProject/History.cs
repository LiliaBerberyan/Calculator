using System;
using System.IO;

namespace CalculatorProject
{
    static class History
    {
        static History()
        {
            Path = "History.txt";
        }
        private static string Path { get; }
        public static void Add<U, T>(T firstParam, T secondParam, ConsoleKey key, U result)
        {
            string text = $"{firstParam} {key.ToString()} {secondParam}={result}";
            Write(text);
        }
        private static void Write(string message)
        {
            File.AppendAllText(Path, message + "\n");
        }
    }
}
