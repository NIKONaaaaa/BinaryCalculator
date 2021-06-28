namespace Calculator.Services
{
    using System;
    public class BinaryToDecimal
    {
        private static string binaryNumber;
        public static int DecimalResult { get; set; }

        public static int Converter(string binary)
        {
            binaryNumber = binary;
            DecimalResult = Convert.ToInt32(binaryNumber, 2);
            return DecimalResult;
        }
    }
}