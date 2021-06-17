using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Fibonacci.Logic.Tests
{
    //Note: I don't know if you use unit tests, what framework you went with,
    //      but this is what I'm doing to test my output. I don't have the
    //      exact test cases in front of me, but I think this is what it was.
    //      Either way, this is the framework for the traditional
    //      Arrange, Act Assert method. 

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
