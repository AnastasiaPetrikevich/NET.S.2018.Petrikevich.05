using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static GCD.Algorihtms;

namespace GCD.Tests
{
    [TestFixture]
    public class AlgorithmTests
    {
        [TestCase(9, 81, ExpectedResult = 9)]
        [TestCase(1298, 3423, ExpectedResult = 1)]
        [TestCase(555555, 5, ExpectedResult = 5)]
        [TestCase(272, 12, ExpectedResult = 4)]
        public static int GradestCommonDivisor_ForTwoNumbers_Results(int firstNumber, int secondNumber) => GradestCommonDivisor(firstNumber, secondNumber);

        [TestCase(9, 81, -504, 1197, -54, ExpectedResult = 9)]
        [TestCase(1298, 3423, 5, 99, -358, 44444, 532537, ExpectedResult = 1)]
        [TestCase(555555, 5,-55325,2222275, 100,-290,ExpectedResult = 5)]
        [TestCase(272,44,-60,-22,333792,450,-12, 12, ExpectedResult = 2)]
        public static int GradestCommonDivisor_Results(params int[] numbers) => GradestCommonDivisor(numbers);

        [TestCase(9, 81, ExpectedResult = 9)]
        [TestCase(1298, 3423, ExpectedResult = 1)]
        [TestCase(555555, 5, ExpectedResult = 5)]
        [TestCase(272, 12, ExpectedResult = 4)]
        public static int BinaryGradestCommonDivisor_ForTwoNumbers_Results(int firstNumber, int secondNumber) => BinaryGradestCommonDivisor(firstNumber, secondNumber);

        [TestCase(9, 81, -504, 1197, -54, ExpectedResult = 9)]
        [TestCase(1298, 3423, 5, 99, -358, 44444, 532537, ExpectedResult = 1)]
        [TestCase(555555, 5, -55325, 2222275, 100, -290, ExpectedResult = 5)]
        [TestCase(272, 44, -60, -22, 333792, 450, -12, 12, ExpectedResult = 2)]
        public static int BinaryGradestCommonDivisor_Results(params int[] numbers) => BinaryGradestCommonDivisor(numbers);

        [Test]
        public static void GradestCommonDivisor_ArgumentNullException(params int[] numbers) => Assert.Throws<ArgumentNullException>(() => GradestCommonDivisor(null));
        [Test]
        public static void BinaryGradestCommonDivisor_ArgumentNullException(params int[] numbers) => Assert.Throws<ArgumentNullException>(() => BinaryGradestCommonDivisor(null));
        [Test]
        public static void GradestCommonDivisor_ArgumentException(params int[] numbers) => Assert.Throws<ArgumentNullException>(() => GradestCommonDivisor( ));
        [Test]
        public static void BinaryGradestCommonDivisor_ArgumentException(params int[] numbers) => Assert.Throws<ArgumentNullException>(() => BinaryGradestCommonDivisor( ));

    }
}
