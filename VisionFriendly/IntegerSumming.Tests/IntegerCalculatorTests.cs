using System;
using NUnit.Framework;

namespace IntegerSumming.Tests
{
    [TestFixture]
    public class IntegerCalculatorTests
    {
        [Test]
        public void IntegersAreSummed()
        {
            object[] input = new object[] {1, 2, 3, 4};

            var results = IntegerCalculator.SumOfIntegers(input);

            Assert.AreEqual(10, results);
        }

        [Test]
        public void LongsAreNotSummed()
        {
            object[] input = new object[] { 1, 2, 3, 4, (long)1 };

            var results = IntegerCalculator.SumOfIntegers(input);

            Assert.AreEqual(10, results);
        }


        [Test]
        public void StringsAreNotSummed()
        {
            object[] input = new object[] { 1, 2, 3, 4, "ham" };

            var results = IntegerCalculator.SumOfIntegers(input);

            Assert.AreEqual(10, results);
        }

        [Test]
        public void FloatsAreNotSummed()
        {
            object[] input = new object[] { 1, 2, 3, 4, (float)23 };

            var results = IntegerCalculator.SumOfIntegers(input);

            Assert.AreEqual(10, results);
        }

        [Test]
        public void BytesAreNotSummed()
        {
            object[] input = new object[] { 1, 2, 3, 4, new byte[5] };

            var results = IntegerCalculator.SumOfIntegers(input);

            Assert.AreEqual(10, results);
        }

        [Test]
        public void ArraysAreNotSummed()
        {
            object[] input = new object[] { 1, 2, 3, 4, new int[2]{4,2} };

            var results = IntegerCalculator.SumOfIntegers(input);

            Assert.AreEqual(10, results);
        }

        [Test]
        public void ExceptionsAreNotSummed()
        {
            object[] input = new object[] { 1, 2, 3, 4, new NotImplementedException("2"),  };

            var results = IntegerCalculator.SumOfIntegers(input);

            Assert.AreEqual(10, results);
        }
    }
}
