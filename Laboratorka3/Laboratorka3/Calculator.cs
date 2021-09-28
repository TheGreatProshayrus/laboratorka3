using System;

namespace Laboratorka3
{
    public class Calculator
    {
        // Додавання
        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        // Віднімання
        public decimal Substract(decimal a, decimal b)
        {
            return a - b;
        }

        // Множення
        public decimal Multiply(decimal a, decimal b)
        {
            return a * b;
        }

        // Обчислення виразу з парсера
        public decimal EvaluateExpression(ParsedExpression expression)
        {
            switch (expression.Operation)
            {
                case Operation.Addition:
                    return Add(
                        expression.LeftOperand,
                        expression.RightOperand
                    );

                case Operation.Substraction:
                    return Substract(
                        expression.LeftOperand,
                        expression.RightOperand
                    );

                case Operation.Multiplication:
                    return Multiply(
                        expression.LeftOperand,
                        expression.RightOperand
                    );

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
