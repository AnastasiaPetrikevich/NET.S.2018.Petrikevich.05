using System;
using System.Linq;

namespace ExtensionMethods
{
    /// <summary>
    /// Contains Convert methods.
    /// </summary>
    public static class StringExtention
    {
        /// <summary>
        /// Convert number from p-system to decimal.
        /// </summary>
        /// <param name="source">Number to convert.</param>
        /// <param name="notation">Number system.</param>
        /// <returns>Number in decimal system.</returns>
        public static int ToDecimalConverter(this string source, Notation notation)
        {
            int numberInDecimal = 0;
            int power = 0;
            for (int i = source.Length - 1; i >= 0; i--)
            {
                if (!notation.Elements.Contains(source.ElementAt(i).ToString()))
                {
                    throw new ArgumentException(nameof(source));
                }

                if (!int.TryParse(source.ElementAt(i).ToString(), out int digit))
                {
                    digit = ConvertSymbolToDigit(source.ElementAt(i));
                }

                if (digit >= notation.Basis || digit < 0)
                {
                    throw new ArgumentException(nameof(source));
                }

                numberInDecimal += digit * (int)Math.Pow(notation.Basis, power);
                power++;
            }

            return numberInDecimal;
        }

        /// <summary>
        /// Convert symbol to number.
        /// </summary>
        /// <param name="symbol">Symbol to convert.</param>
        /// <returns>Number.</returns>
        private static int ConvertSymbolToDigit(char symbol)
        {
            switch (symbol)
            {
                case 'A':
                case 'a':
                    return 10;
                case 'B':
                case 'b':
                    return 11;
                case 'C':
                case 'c':
                    return 12;
                case 'D':
                case 'd':
                    return 13;
                case 'E':
                case 'e':
                    return 14;
                case 'F':
                case 'f':
                    return 15;
                default:
                    return -1;
            }
        }
    }

    /// <summary>
    ///Describes the number system.
    /// </summary>
    public class Notation
    {
        private int basis;
        private const string elements = "0123456789ABCDEFabcdef";

        public Notation(int basis)
        {
            Basis = basis;
        }

        public int Basis
        {
            get => basis;
            set
            {
                if (value < 2 || value > 16)
                {
                    throw new ArgumentException(nameof(value));
                }
                basis = value;
            }
        }

        public string Elements => elements;
    }
}
