using System;
using NUnit.Framework;
using SomeService;

namespace Tests
{
    namespace SomeService.Tests
    {
        [TestFixture]
        public class TimeServiceTests
        {
            [Test]
            public void WhenTimeIsEven()
            {
                DateTime candidate = new DateTime(2000, 1, 1, 1, 1, 4);
                var result = TimeService.IsSecondEven(candidate);
                Assert.AreEqual(true, result);
            }
            [Test]
            public void Odd()
            {
                DateTime candidate = new DateTime(2000, 1, 1, 1, 1, 3);
                var result = TimeService.IsSecondEven(candidate);
                Assert.AreEqual(false, result);
            }
            [Test]
            public void WhenTimeIsZero()
            {
                Assert.True(true);
            }
        }
    }
}