namespace Calculator
{
    public class Operation
    {
        public static string Perform(string firstNumber, string operationType, string secondNumber)
        {
            switch (operationType)
            {
                case "+":
                    return Addition.Calculate(firstNumber, secondNumber);
                case "-":
                case "*":
                case "/":
                    return "Not implemented yet!";
                default:
                    return "Wrong operation type!";
                    //TODO: Implement other operations.
            }
        }
    }
}