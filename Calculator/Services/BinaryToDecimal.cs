namespace Calculator.Services
{
    using System;
    public class BinaryToDecimal
    {
        public static ulong DecimalResult { get; set; }

        public static ulong Converter(string binary)
        {
            DecimalResult = Convert.ToUInt64(binary, 2);
            return DecimalResult;
        }
    }
}