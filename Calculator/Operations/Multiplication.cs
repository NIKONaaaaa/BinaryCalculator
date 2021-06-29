namespace Calculator.Operations
{
    using Engine;
    public class Multiplication
    {
        public static string Result { get; set; }

        public static string Calculate(string firstNumber, ulong iterationCount)
        {
            Result = "0";

            for (ulong i = 0; i < iterationCount; i++)
            {
                Result = Operation.Select(firstNumber, '+', Result);
            }

            return Result;
        }
    }
}