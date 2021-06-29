namespace Calculator.Services
{
    using System;
    public class BinaryToDecimal
    {
        private static string _binaryNumber;
        public static int DecimalResult { get; set; }

        public static int Converter(string binary)
        {
            _binaryNumber = binary;
            DecimalResult = Convert.ToInt32(_binaryNumber, 2);
            return DecimalResult;
        }
    }
}