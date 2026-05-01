using Banking.AU.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Banking.AU.Tests.Common
{
    [TestClass]
    public class Bsb_Fixture
    {
        [TestMethod]
        public void Encode_bsb()
        {
            // Arrange

            // Act
            var bsb = Bsb.Encode(73, Bsb.State.TAS, 123);

            // Assert
            Assert.AreEqual("737-123", bsb);
        }

        [TestMethod]
        public void Encode_empty_bsb()
        {
            // Arrange

            // Act
            var bsb = Bsb.Encode(0, 0, 0);

            // Assert
            Assert.AreEqual("000-000", bsb);
        }
    }
}
