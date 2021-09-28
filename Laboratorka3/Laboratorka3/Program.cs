using System;

namespace Laboratorka3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding =
                Console.OutputEncoding =
                    System.Text.Encoding.Unicode;

            PrintGuide();

            ParsedExpression expression = ParseInput(new Parser());
            Calculator calc = new Calculator();
            decimal result = calc.EvaluateExpression(expression);

            Console.WriteLine($"Ответ: {result}");
            Pause();
        }

        static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Нажмите ENTER чтобы продолжить...");
            Console.WriteLine();
            Console.ReadLine();
        }

        static void PrintGuide()
        {
            Console.WriteLine("Инструкция:");

            Console.WriteLine(
                "Введите математическое выражение, " +
                "содержащее в себе первый аргумент, " +
                "второй аргумент и действие. " +
                @"Пробелы и '=' в выражении игнорируются. " +
                "Для дробных чисел используйте точку " +
                @"или запятую. " +
                "Выражение можно вводить по частям, " +
                "по одной части на строку "              
            );

            Console.WriteLine();

            Console.WriteLine("Доступные действия:");
            Console.WriteLine(@"Сложение  - '+'");
            Console.WriteLine(@"Вычитание - '-'");
            Console.WriteLine(@"Умножение - '*'");

            Console.WriteLine();

            Console.WriteLine("Примеры ввода:");
            Console.WriteLine("153 + 123");
            Console.WriteLine("123.123 -31");
            Console.WriteLine("52 * 63");
            Console.WriteLine("47+ 42=");
            Console.WriteLine("74,98");
            Console.WriteLine("+");
            Console.WriteLine("84");

            Console.WriteLine();
        }

        static ParsedExpression ParseInput(Parser parser)
        {
            try
            {
                if (parser.ProcessInput(Console.ReadLine()))
                    return parser.GetResult();
                else
                    return ParseInput(parser);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                return ParseInput(parser);
            }
        }
    }
}
