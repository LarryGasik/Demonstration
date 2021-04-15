using NUnit.Framework;
using Prime.Service;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class Tests
    {
        private PrimeService _sut;
        [SetUp]
        public void Setup()
        {
            _sut = new PrimeService();
        }

        [Test]
        public void IsPrime_ValuesLessThan2_ReturnFalse()
        {
            var result = _sut.isPrime(1);
            Assert.IsFalse(result, "1 should not be prime");
        }


        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _sut.isPrime(value);

            Assert.IsFalse(result, $"{value} should not be prime");
        }
    }
}