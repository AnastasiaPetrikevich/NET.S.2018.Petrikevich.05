using System;
using System.Linq;
using System.Text;

namespace ExtensionMethods
{
    /// <summary>
    /// Contains Convert methods.
    /// </summary>

    public static class Methods
    {
        /// <summary>
        /// Convert number from p-system to decimal.
        /// </summary>
        /// <param name="number">Number to convert.</param>
        /// <param name="p">System rank.</param>
        /// <returns>Number in decimal system.</returns>
        public static int ConvertToDecimalSystem(this string number, int p)
        {
            int numberInDecimal = 0;
            int power = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (!int.TryParse(number.ElementAt(i).ToString(), out int digit))
                {
                    digit = ConvertSymbolToDigit(number.ElementAt(i));
                }
                if (digit >= p || digit < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(number));
                }
                numberInDecimal += digit * (int)Math.Pow(p, power);
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
}