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
                    return Addition.Calculate(firstNumber, secondNumber);
                case '-':
                    return Subtraction.Calculate(firstNumber, secondNumber);
                case '*':
                    return Multiplication.Calculate(firstNumber, secondNumber);
                case '/':
                    return "Not implemented yet!";
                default:
                    return "Wrong operation type!";
                    //TODO: Implement other operations.
            }
        }
    }
}