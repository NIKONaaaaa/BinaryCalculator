namespace Calculator.Operations
{
    using Services;
    using System.Collections.Generic;

    public class Multiplication
    {
        private static int iterations;
        private static Stack<char> firstStack;
        private static Stack<char> secondStack;

        public static string Result { get; set; }

        public static string Calculate(string numberOne, string numberTwo)
        {
            iterations = BinaryToDecimal.Converter(numberTwo);
            Result = "0";

            for (int i = 0; i < iterations; i++)
            {
                Result = Addition.Calculate(numberOne, Result);
            }

            return Result;
        }
    }
}