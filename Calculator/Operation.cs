namespace Calculator
{
    using System.Collections.Generic;
    using Operations;
    public class Operation
    {
        private static Stack<char> firstStack;
        private static Stack<char> secondStack;

        public static string Perform(string firstNumber, char operationType, string secondNumber)
        {
            Parser.ParseNumbers(firstNumber, secondNumber);
            firstStack = Parser.FirstStack;
            secondStack = Parser.SecondStack;

            switch (operationType)
            {
                case '+':
                    return Addition.Calculate(firstStack, secondStack);
                case '-':
                    return Subtraction.Calculate(firstStack, secondStack);
                case '*':
                case '/':
                    return "Not implemented yet!";
                default:
                    return "Wrong operation type!";
                    //TODO: Implement other operations.
            }
        }
    }
}