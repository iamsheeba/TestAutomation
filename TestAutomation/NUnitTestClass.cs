using NUnit.Framework;
using System;
namespace TestAutomation
{
    [TestFixture()]
    public class NUnitTestClass
    {
        [Test()]
        public void ShouldValidateCorrectNum()
        {
            var sut = new Validate();
            var isValid = sut.ValidityOf("X1234567");

            Assert.IsTrue(isValid);
        }
    }
}
