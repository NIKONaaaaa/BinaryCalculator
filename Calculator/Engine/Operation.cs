namespace Calculator.Engine
{
    using Services;
    using Operations;
    public class Operation
    {
        public static string Select(string firstNumber, char operationType, string secondNumber)
        {
            switch (operationType)
            {
                case '+':
                    Parser.BothNumbers(firstNumber, secondNumber);
                    return Addition.Calculate(Parser.FirstStack, Parser.SecondStack);
                case '-':
                    Parser.BothNumbers(firstNumber, secondNumber);
                    return Subtraction.Calculate(Parser.FirstStack, Parser.SecondStack);
                case '*':
                    BinaryToDecimal.Converter(secondNumber);
                    return Multiplication.Calculate(firstNumber, BinaryToDecimal.DecimalResult);
                case '/':
                    return Division.Calculate(firstNumber, secondNumber);
                default:
                    return "42";
            }
        }
    }
}