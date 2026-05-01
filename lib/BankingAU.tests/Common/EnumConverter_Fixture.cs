using Banking.AU.ABA.Records;
using Banking.AU.Common.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Banking.AU.Tests.Common
{
    [TestClass]
    public class EnumConverter_Fixture
    {
        [TestMethod]
        public void From_indicator()
        {
            // Arrange
            var c = new EnumConverter(typeof(Indicator));

            // Act
            var result = c.FieldToString(Indicator.NewOrVaried);

            // Assert
            Assert.AreEqual("N", result);
        }

        [TestMethod]
        public void To_indicator()
        {
            // Arrange
            var c = new EnumConverter(typeof(Indicator));

            // Act
            var result = c.StringToField("X");

            // Assert
            Assert.AreEqual(Indicator.DividendPaid, result);
        }

        [TestMethod]
        public void From_transaction_code()
        {
            // Arrange
            var c = new EnumConverter(typeof(TransactionCode));

            // Act
            var result = c.FieldToString(TransactionCode.CreditItem);

            // Assert
            Assert.AreEqual("50", result);
        }

        [TestMethod]
        public void To_transaction_code()
        {
            // Arrange
            var c = new EnumConverter(typeof(TransactionCode));

            // Act
            var result = c.StringToField("50");

            // Assert
            Assert.AreEqual(TransactionCode.CreditItem, result);
        }
    }
}
