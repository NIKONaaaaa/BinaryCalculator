namespace Calculator.Operations
{
    using Engine;
    public class Division
    {
        public static string Result { get; set; }

        public static string Calculate(string firstNumber, ulong iterationCount)
        {
            for (ulong i = 0; i < iterationCount; i++)
            {
                Result = Operation.Select(firstNumber, '-', firstNumber);
            }

            return Result;
        }
    }
}