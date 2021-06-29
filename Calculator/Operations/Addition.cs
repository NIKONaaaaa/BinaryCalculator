namespace Calculator.Operations
{
    using System.Collections.Generic;

    public class Addition
    {
        private static bool _isCarried;
        private static Stack<char> _numberResult;
        
        public static string Result { get; set; }

        public static string Calculate(Stack<char> firstStack, Stack<char> secondStack)
        {
            _isCarried = false;
            _numberResult = new Stack<char>();
            Result = "";

            while (0 < firstStack.Count)
            {
                switch (firstStack.Peek())
                {
                    case '0' when secondStack.Peek() == '0':
                        switch (_isCarried)
                        {
                            case false:
                                _numberResult.Push('0');
                                break;
                            case true:
                                _numberResult.Push('1');
                                _isCarried = false;
                                break;
                        }
                        break;
                    case '1' when secondStack.Peek() == '0':
                    case '0' when secondStack.Peek() == '1':
                        switch (_isCarried)
                        {
                            case false:
                                _numberResult.Push('1');
                                break;
                            case true:
                                _numberResult.Push('0');
                                break;
                        }
                        break;
                    case '1' when secondStack.Peek() == '1':
                        switch (_isCarried)
                        {
                            case false:
                                _numberResult.Push('0');
                                _isCarried = true;
                                break;
                            case true:
                                _numberResult.Push('1');
                                break;
                        }
                        break;
                }

                firstStack.Pop();
                secondStack.Pop();
            }

            if (_isCarried)
            {
                _numberResult.Push('1');
            }

            while (0 < _numberResult.Count)
            {
                Result += _numberResult.Pop();
            }

            return Result;
        }
    }
}