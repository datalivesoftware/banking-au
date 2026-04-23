using Banking.AU.Common.Converters;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.AU.Tests.Common
{
    [TestFixture]
    public class CurrencyConverter_Fixture
    {
        [Test]
        public void From_decimal()
        {
            // Arrange
            var c = new CurrencyConverter();

            // Act
            var result = c.FieldToString(1234.56m);

            // Assert
            Assert.AreEqual("123456", result);
        }

        [Test]
        public void To_decimal()
        {
            // Arrange
            var c = new CurrencyConverter();

            // Act
            var result = c.StringToField("0000123456");

            // Assert
            Assert.AreEqual(1234.56m, result);
        }
        [Test]
        public void From_decimal_unsigned()
        {
            // Arrange
            var c = new UnsignedCurrencyConverter();

            // Act
            var result = c.FieldToString(-1234.56m);

            // Assert
            Assert.AreEqual("123456", result);
        }

        [Test]
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
