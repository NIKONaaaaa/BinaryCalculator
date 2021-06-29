namespace Calculator.Engine
{
    using Services;
    using System;
    public class Run
    {
        public void Start()
        {
            while (true)
            {
                Console.Clear();

                Console.Write("Enter first binary number     : ");
                string firstNumber = new Validator().Digit();
                Console.WriteLine();

                Console.Write("Choose operation type(+ - * /): ");
                char operationType = new Validator().Operation();
                Console.WriteLine();

                Console.Write("Enter second binary number    : ");
                string secondNumber = new Validator().Digit();

                string result = Operation.Select(firstNumber, operationType, secondNumber);

                Console.Clear();

                Console.Write("First number in binary        : ");
                Console.WriteLine(firstNumber);
                Console.Write("             in decimal       : ");
                Console.WriteLine(BinaryToDecimal.Converter(firstNumber));
                Console.Write("Second number in binary       : ");
                Console.WriteLine(secondNumber);
                Console.Write("              in decimal      : ");
                Console.WriteLine(BinaryToDecimal.Converter(secondNumber));
                Console.Write("The result in binary          : ");
                Console.WriteLine(result);
                Console.Write("           in decimal         : ");
                Console.WriteLine(BinaryToDecimal.Converter(result));

                Console.Write("Press any key for another calculation...");
                Console.ReadKey(true);
            }
        }
    }
}