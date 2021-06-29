namespace Calculator.Services
{
    using System;
    using System.Collections.Generic;
    public class Parser
    {
        private static int lengthDifference;
        private static string _firstNumber;
        private static string _secondNumber;
        
        public static Stack<char> FirstStack { get; set; }
        public static Stack<char> SecondStack { get; set; }

        public static void BothNumbers(string firstNumber, string secondNumber)
        {
            _firstNumber = firstNumber;
            _secondNumber = secondNumber;
            lengthDifference = _firstNumber.Length - _secondNumber.Length;
            FirstStack = new Stack<char>();
            SecondStack = new Stack<char>();

            if (0 < lengthDifference)
            {
                for (int i = 0; i < Math.Abs(lengthDifference); i++)
                {
                    SecondStack.Push('0');
                }
            }
            else if (lengthDifference < 0)
            {
                for (int i = 0; i < Math.Abs(lengthDifference); i++)
                {
                    FirstStack.Push('0');
                }
            }

            FirstStack = Populate(_firstNumber, FirstStack);
            SecondStack = Populate(_secondNumber, SecondStack);
        }

        internal static Stack<char> Populate(string numberInput, Stack<char> resultStack)
        {
            foreach (char ch in numberInput)
            {
                resultStack.Push(ch);
            }

            return resultStack;
        }
    }
}