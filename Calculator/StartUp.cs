namespace Calculator
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            Console.Write("Enter first binary number     : ");
            string firstNumber = Console.ReadLine();

            Console.Write("Choose operation type(+ - * /): ");
            char operationType = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Enter second binary number    : ");
            string secondNumber = Console.ReadLine();

            Console.Write("The result is                 : ");
            string result = Operation.Perform(firstNumber, operationType, secondNumber);
            Console.WriteLine(result);

            //TODO: Implement operations with negative numbers.
        }
    }
}