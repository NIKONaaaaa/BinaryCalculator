namespace Calculator.Operations
{
    using System.Collections.Generic;
    public class Subtraction
    {
        private static bool isCarried;
        private static Stack<char> numberResult;
        
        public static string Result { get; set; }

        public static string Calculate(Stack<char> firstStack, Stack<char> secondStack)
        {
            isCarried = false;
            numberResult = new Stack<char>();
            Result = "";

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
                                break;
                        }
                        break;
                    case '1' when secondStack.Peek() == '0':
                        switch (isCarried)
                        {
                            case false:
                                numberResult.Push('1');
                                break;
                            case true:
                                numberResult.Push('0');
                                isCarried = false;
                                break;
                        }
                        break;
                    case '0' when secondStack.Peek() == '1':
                        switch (isCarried)
                        {
                            case false:
                                numberResult.Push('1');
                                isCarried = true;
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

            while (0 < numberResult.Count)
            {
                while (numberResult.Peek() == '0' && numberResult.Count > 1)
                {
                    numberResult.Pop();
                }

                Result += numberResult.Pop();
            }

            return Result;
        }
    }
}