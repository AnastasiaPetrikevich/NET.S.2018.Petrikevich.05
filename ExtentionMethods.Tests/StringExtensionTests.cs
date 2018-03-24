using System;
using ExtensionMethods;
using NUnit.Framework;


namespace ExtentionMethods.Tests
{
    [TestFixture]
    public class StringExtensionTests
    {
        [TestCase("0110111101100001100001010111111", 2, ExpectedResult = 934331071)]
        [TestCase("01101111011001100001010111111", 2, ExpectedResult = 233620159)]
        [TestCase("1AeF101", 16, ExpectedResult = 28242177)]
        [TestCase("1ACB67", 16, ExpectedResult = 1756007)]
        [TestCase("764241", 8, ExpectedResult = 256161)]
        [TestCase("10", 5, ExpectedResult = 5)]
        public static int ToDecimalConverter_Results(string source, int p)
        {
            Notation notation = new Notation(p);
            return source.ToDecimalConverter(notation);
        }

        [TestCase("1ACB67", 2)]
        [TestCase("SA123", 2)]
        [TestCase("96783", 8)]
        public static void ToDecimalConverter_ArgumentException(string source, int p) 
        {
            Notation notation = new Notation(p);
            Assert.Throws<ArgumentException>(() => source.ToDecimalConverter(notation));
        }

    }
}
