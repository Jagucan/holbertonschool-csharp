using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAddMethod()
        {
            // Arrange
            int a = 5;
            int b = 7;
            int expectedSum = a + b;

            // Act
            int actualSum = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}
