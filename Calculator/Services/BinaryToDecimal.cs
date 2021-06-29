namespace Calculator.Services
{
    using System;
    public class BinaryToDecimal
    {
        private static string _binaryNumber;
        public static ulong DecimalResult { get; set; }

        public static ulong Converter(string binary)
        {
            _binaryNumber = binary;
            DecimalResult = Convert.ToUInt64(_binaryNumber, 2);
            return DecimalResult;
        }
    }
}