﻿namespace Calculator
{
    using System.Collections.Generic;
    public class Operation
    {
        private static Stack<char> firstStack;
        private static Stack<char> secondStack;

        public static string Perform(string firstNumber, string operationType, string secondNumber)
        {
            new Parser();
            Parser.ParseNumbers(firstNumber, secondNumber);
            firstStack = Parser.FirstStack;
            secondStack = Parser.SecondStack;

            switch (operationType)
            {
                case "+":
                    return Addition.Calculate(firstStack, secondStack);
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