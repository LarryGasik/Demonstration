using System.Collections.Generic;
using NUnit.Framework;

namespace Fibonacci.Logic.Tests
{
    [TestFixture]
    public class FibonacciGeneratorTests
    {
        private FibonaciGenerator _sut;
        [SetUp]
        public void SetUp()
        {
            _sut = new FibonaciGenerator();
        }

        [Test]
        public void Fibonacci1()
        {
            var results = _sut.fibonacci(1);
            Assert.AreEqual(new List<int> { 0 }, results);
        }


        [Test]
        public void Fibonacci2()
        {
            var results = _sut.fibonacci(2);
            Assert.AreEqual(new List<int>{0,1}, results);
        }

        [Test]
        public void Fibonacci3()
        {
            var results = _sut.fibonacci(3);
            Assert.AreEqual(new List<int> { 0, 1, 2 }, results);
        }

        [Test]
        public void Fibonacci4()
        {
            var results = _sut.fibonacci(4);
            Assert.AreEqual(new List<int> { 0, 1, 2, 3 }, results);
        }

        [Test]
        public void Fibonacci5()
        {
            var results = _sut.fibonacci(5);
            Assert.AreEqual(new List<int> { 0, 1, 2, 3, 5 }, results);
        }

        [Test]
        public void Fibonacci6()
        {
            var results = _sut.fibonacci(6);
            Assert.AreEqual(new List<int> { 0, 1, 2, 3, 5, 8}, results);
        }


    }
}
