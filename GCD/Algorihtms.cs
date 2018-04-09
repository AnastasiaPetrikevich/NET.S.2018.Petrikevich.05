using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
    /// <summary>
    /// Contains methods for finding GCD.
    /// </summary>
    public class Algorihtms
    {
        /// <summary>
        /// Overload version of GradestCommonDivisor for two numbers.
        /// </summary>
        /// <param name="numbers">Numbers for which Gradest Common Divisor searched.</param>
        /// <returns>Gradest Common Divisor.</returns>
        public static int GradestCommonDivisor(params int[] numbers)
        {
            Func<int, int, int> gcd = GradestCommonDivisor;
            return FindGCG(gcd, numbers);
        }

        /// <summary>
        /// Calculates GradestCommonDivisor for three numbers using Euclid algorithm.
        /// </summary>
        /// <param name="firstNumber">First number for which Gradest Common Divisor searched.</param>
        /// <param name="secondNumber">Second number for which Gradest Common Divisor searched.</param>
        /// <param name="thirdNumber">Third number for which Gradest Common Divisor searched.</param>
        /// <returns>Gradest Common Divisor.</returns>
        public static int GradestCommonDivisor(int firstNumber, int secondNumber, int thirdNumber)
        {
            Func<int, int, int> gcd = GradestCommonDivisor;
            return FindGCG(gcd, firstNumber, secondNumber, thirdNumber);
        }

        /// <summary>
        /// Calculates GradestCommonDivisor for two numbers using Euclid algorithm.
        /// </summary>
        /// <param name="firstNumber">First number for which Gradest Common Divisor searched.</param>
        /// <param name="secondNumber">Second number for which Gradest Common Divisor searched.</param>
        /// <returns>Gradest Common Divisor.</returns>
        public static int GradestCommonDivisor(int firstNumber, int secondNumber)
        {
            if (firstNumber < 0)
            {
                firstNumber = Math.Abs(firstNumber);
            }

            if (secondNumber < 0)
            {
                secondNumber = Math.Abs(secondNumber);
            }

            while (firstNumber != secondNumber)
            {
                if (firstNumber > secondNumber)
                {
                    firstNumber = firstNumber - secondNumber;
                }
                else
                {
                    secondNumber = secondNumber - firstNumber;
                }
            }
            return Math.Abs(firstNumber);
        }

        /// <summary>
        /// Overload version of BinaryGradestCommonDivisor for two numbers.
        /// </summary>
        /// <param name="numbers">Numbers for which Gradest Common Divisor searched.</param>
        /// <returns>Gradest Common Divisor.</returns>
        public static int BinaryGradestCommonDivisor(params int[] numbers)
        {
            Func<int,int,int> gcd = BinaryGradestCommonDivisor;
            return FindGCG(gcd, numbers);
        }

        /// <summary>
        /// Calculates GradestCommonDivisor for three numbers using Stein algorithm (binary).
        /// </summary>
        /// <param name="firstNumber">First number for which Gradest Common Divisor searched.</param>
        /// <param name="secondNumber">Second number for which Gradest Common Divisor searched.</param>
        /// <param name="thirdNumber">Third number for which Gradest Common Divisor searched.</param>
        /// <returns>Gradest Common Divisor.</returns>
        public static int BinaryGradestCommonDivisor(int firstNumber, int secondNumber,int thirdNumber)
        {
            Func<int, int, int> gcd = BinaryGradestCommonDivisor;
            return FindGCG(gcd, firstNumber, secondNumber, thirdNumber);
        }

        /// <summary>
        /// Calculates GradestCommonDivisor for two numbers using Stein algorithm (binary).
        /// </summary>
        /// <param name="firstNumber">first number for which Gradest Common Divisor searched.</param>
        /// <param name="secondNumber">second number for which Gradest Common Divisor searched.</param>
        /// <returns>Gradest Common Divisor.</returns>
        public static int BinaryGradestCommonDivisor(int firstNumber, int secondNumber)
        {
            if (firstNumber < 0)
            {
                firstNumber = Math.Abs(firstNumber);
            }

            if (secondNumber < 0)
            {
                secondNumber = Math.Abs(secondNumber);
            }

            if ((firstNumber == secondNumber) || (secondNumber == 0))
            {
                return firstNumber;
            }

            if (firstNumber == 0)
            {
                return secondNumber;
            }

            if ((~firstNumber & 1) != 0)
            {
                if ((secondNumber & 1) != 0)
                {
                    return BinaryGradestCommonDivisor(firstNumber >> 1, secondNumber);
                }
                return BinaryGradestCommonDivisor(firstNumber >> 1, secondNumber >> 1) << 1;
            }

            if ((~secondNumber & 1) != 0)
            {
                return BinaryGradestCommonDivisor(firstNumber, secondNumber >> 1);
            }

            if (firstNumber > secondNumber)
            {
                return BinaryGradestCommonDivisor((firstNumber - secondNumber) >> 1, secondNumber);
            }

            return BinaryGradestCommonDivisor((secondNumber - firstNumber) >> 1, firstNumber);
        }

        /// <summary>
        /// Calculates Gradest Common Divisor for params.
        /// </summary>
        /// <param name="gcd">Type of algorihtm.</param>
        /// <param name="numbers">Numbers for which Gradest Common Divisor searched.</param>
        /// <returns>Gradest Common Divisor.</returns>
        public static int FindGCG(Func<int, int, int> gcd, params int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers));
            }

            if (numbers.Length == 0)
            {
                throw new ArgumentException(nameof(numbers));
            }

            int result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result = gcd(result, numbers[i]);
            }
            return result;
        }

        /// <summary>
        /// Calculates Gradest Common Divisor for three numbers.
        /// </summary>
        /// <param name="gcd">Type of algorihtm.</param>
        /// <param name="firstNumber">First number for which Gradest Common Divisor searched.</param>
        /// <param name="secondNumber">Second number for which Gradest Common Divisor searched.</param>
        /// <param name="thirdNumber">Third number for which Gradest Common Divisor searched.</param>
        /// <returns>Gradest Common Divisor.</returns>
        public static int FinGCD(Func<int, int, int> gcd, int firstNumber, int secondNumber, int thirdNumber)
        {
            int result = gcd(firstNumber, secondNumber);
            result = gcd(result, thirdNumber);
            return result;
        }
    }
}
