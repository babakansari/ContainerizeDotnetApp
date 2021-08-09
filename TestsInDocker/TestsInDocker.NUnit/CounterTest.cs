using System.Linq;
using NUnit.Framework;

namespace TestsInDocker.NUnit
{
    public class CounterTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCounter()
        {
            // Arrange
            var max = 1;

            // Act
            var counterStr = Counter.RunCounter(max).ToList();

            // Assert
            Assert.AreEqual(counterStr.Count, 1);
            Assert.AreEqual(counterStr.First(), "Counter: 1");
        }
    }
}