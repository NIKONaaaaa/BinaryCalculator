namespace Calculator.Operations
{
    using Engine;
    using Services;
    public class Division
    {
        public static string Result { get; set; }

        public static string Calculate(string firstNumber, string secondNumber)
        {
            if (BinaryToDecimal.Converter(secondNumber) == 1)
            {
                return firstNumber;
            }

            Result = "1";

            while (BinaryToDecimal.Converter(firstNumber) > 0)
            {
                firstNumber = Operation.Select(firstNumber, '-', secondNumber);
                Result = Operation.Select(Result, '+', "1");
            }

            return Result;
        }
    }
}