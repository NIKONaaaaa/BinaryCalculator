namespace Calculator.Operations
{
    using System.Collections.Generic;

    public class Multiplication
    {
        private static bool isCarried;
        private static Stack<char> numberResult;
        private static Stack<char> firstStack;
        private static Stack<char> secondStack;
        private static int iterations;

        public static string Result { get; set; }

        //TODO: Fix this mess.

        public static string Calculate(Stack<char> stackOne, Stack<char> stackTwo, int iterationNumber)
        {
            isCarried = false;
            numberResult = stackOne;
            iterations = iterationNumber;
            Result = "";

            for (int i = 0; i < iterations; i++)
            {
                firstStack = numberResult;
                secondStack = stackOne;
                numberResult.Clear();

                while (0 < firstStack.Count)
                {
                    switch (firstStack.Peek())
                    {
                        case '0' when secondStack.Peek() == '0':
                            switch (isCarried)
                            {
                                case false:
                                    numberResult.Push('0');
                                    break;
                                case true:
                                    numberResult.Push('1');
                                    isCarried = false;
                                    break;
                            }

                            break;

                        case '1' when secondStack.Peek() == '0':
                        case '0' when secondStack.Peek() == '1':
                            switch (isCarried)
                            {
                                case false:
                                    numberResult.Push('1');
                                    break;
                                case true:
                                    numberResult.Push('0');
                                    break;
                            }

                            break;

                        case '1' when secondStack.Peek() == '1':
                            switch (isCarried)
                            {
                                case false:
                                    numberResult.Push('0');
                                    isCarried = true;
                                    break;
                                case true:
                                    numberResult.Push('1');
                                    break;
                            }

                            break;
                    }

                    firstStack.Pop();
                    secondStack.Pop();
                }

                if (isCarried)
                {
                    numberResult.Push('1');
                }
            }

            while (0 < numberResult.Count)
            {
                Result += numberResult.Pop();
            }

            return Result;
        }
    }
}