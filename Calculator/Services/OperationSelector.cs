namespace Calculator.Services
{
    using Operations;
    public class OperationSelector
    {
        public static string Perform(string firstNumber, char operationType, string secondNumber)
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
                    return "Not implemented yet!";
                default:
                    return "Wrong operation type!";
            }
        }
    }
}