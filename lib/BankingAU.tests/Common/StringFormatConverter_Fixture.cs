using Banking.AU.Common.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Banking.AU.Tests.Common
{
    [TestClass]
    public class StringFormatConverter_Fixture
    {
        [TestMethod]
        public void From_decimal()
        {
            // Arrange
            var c = new StringFormatConverter(typeof(decimal), "F2");

            // Act
            var result = c.FieldToString(1234.5678m);

            // Assert
            Assert.AreEqual("1234.57", result);
        }

        [TestMethod]
        public void To_decimal()
        {
            // Arrange
            var c = new StringFormatConverter(typeof(decimal), "F2");

            // Act
            var result = c.StringToField("1234.57");

            // Assert
            Assert.AreEqual(1234.57m, result);
        }
        [TestMethod]
        public void From_decimal_to_integer()
        {
            // Arrange
            var c = new StringFormatConverter(typeof(int), "F0");

            // Act
            var result = c.FieldToString(1234.5678m);

            // Assert
            Assert.AreEqual("1235", result);
        }

        [TestMethod]
        public void To_integer_from_decimal()
        {
            // Arrange
            var c = new StringFormatConverter(typeof(int), "F0");

            // Act
            var result = c.StringToField("1235");

            // Assert
            Assert.AreEqual(1235, result);
        }
    }
}
