using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsInDocker.MSTest
{
    [TestClass]
    public class CounterTest
    {
        [TestMethod]
        public void TestMethod1()
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
