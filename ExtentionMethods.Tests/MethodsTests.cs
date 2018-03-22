using System;
using static ExtensionMethods.Methods;
using NUnit.Framework;


namespace ExtentionMethods.Tests
{
    [TestFixture]
    public class MethodsTests
    {
        [TestCase("0110111101100001100001010111111", 2, ExpectedResult = 934331071)]
        [TestCase("01101111011001100001010111111", 2, ExpectedResult = 233620159)]
        [TestCase("1AeF101", 16, ExpectedResult = 28242177)]
        [TestCase("1ACB67", 16, ExpectedResult = 1756007)]
        [TestCase("764241", 8, ExpectedResult = 256161)]
        public static int ConvertToDecimalSystem_Results(string number, int p) => number.ConvertToDecimalSystem(p);

        [TestCase("1ACB67", 2)]
        [TestCase("SA123", 2)]
        [TestCase("96783", 8)]
        public static void ConvertToDecimalSystem_ArgumentException(string number, int p) => Assert.Throws<ArgumentOutOfRangeException>(() => number.ConvertToDecimalSystem(p));


        
    }
}
