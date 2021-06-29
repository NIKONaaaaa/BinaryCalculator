namespace Calculator.Engine
{
    using System;
    public class Validate
    {
        public string Number()
        {
            string result = "";
            ConsoleKeyInfo input = Console.ReadKey(true);
            while (input.Key != ConsoleKey.Enter && result != null)
            {
                if (input.Key == ConsoleKey.NumPad1 || input.Key == ConsoleKey.D1)
                {
                    result += "1";
                    Console.Write("1");
                }
                else if (input.Key == ConsoleKey.NumPad0 || input.Key == ConsoleKey.D0)
                {
                    result += "0";
                    Console.Write("0");
                }
                else if (input.Key == ConsoleKey.Backspace && 0 < result.Length)
                {
                    result = result[..^1];
                    Console.CursorLeft = Console.GetCursorPosition().Left - 1;
                    Console.Write(" ");
                    Console.CursorLeft = Console.GetCursorPosition().Left - 1;
                }

                input = Console.ReadKey(true);
            }

            return result;
        }

        public char Operation()
        {
            ConsoleKeyInfo input = Console.ReadKey(true);
            while (input.KeyChar != '+' && input.KeyChar != '-' && input.KeyChar != '*' && input.KeyChar != '/')
            {
                input = Console.ReadKey(true);
            }

            Console.Write(input.KeyChar);
            return input.KeyChar;
        }
    }
}