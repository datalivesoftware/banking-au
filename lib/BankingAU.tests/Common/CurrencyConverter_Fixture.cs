using Banking.AU.Common.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Banking.AU.Tests.Common
{
    [TestClass]
    public class CurrencyConverter_Fixture
    {
        [TestMethod]
        public void From_decimal()
        {
            // Arrange
            var c = new CurrencyConverter();

            // Act
            var result = c.FieldToString(1234.56m);

            // Assert
            Assert.AreEqual("123456", result);
        }

        [TestMethod]
        public void To_decimal()
        {
            // Arrange
            var c = new CurrencyConverter();

            // Act
            var result = c.StringToField("0000123456");

            // Assert
            Assert.AreEqual(1234.56m, result);
        }
        [TestMethod]
        public void From_decimal_unsigned()
        {
            // Arrange
            var c = new UnsignedCurrencyConverter();

            // Act
            var result = c.FieldToString(-1234.56m);

            // Assert
            Assert.AreEqual("123456", result);
        }

        [TestMethod]
        public void To_decimal_unsigned()
        {
            // Arrange
            var c = new UnsignedCurrencyConverter();

            // Act
            var result = c.StringToField("0000123456");

            // Assert
            Assert.AreEqual(1234.56m, result);
        }
    }
}
