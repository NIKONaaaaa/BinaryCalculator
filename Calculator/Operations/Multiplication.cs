namespace Calculator.Operations
{
    using Services;
    public class Multiplication
    {
        public static string Result { get; set; }

        public static string Calculate(string firstNumber, int iterationCount)
        {
            Result = "0";

            for (int i = 0; i < iterationCount; i++)
            {
                Result = OperationSelector.Perform(firstNumber, '+', Result);
            }

            return Result;
        }
    }
}