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
        public void TestDivideByZero()
        {
            int[,] matrix = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[,] result = Matrix.Divide(matrix, 0);
            Assert.IsNull(result);
        }

        [Test]
        public void TestDivideWithValidValue()
        {
            int[,] matrix = new int[,]
            {
                { 2, 4, 6 },
                { 9, 12, 15 },
                { -1, -2, -3 }
            };

            int[,] result = Matrix.Divide(matrix, 5);
            Assert.AreEqual(0, result[0, 0]);
            Assert.AreEqual(0, result[0, 1]);
            Assert.AreEqual(1, result[0, 2]);
        }

        [Test]
        public void TestDivideEmptyMatrix()
        {
            int[,] matrix = new int[,]
            {
                { 0, 0 },
                { 0, 0 },
                { 0, 0 }
            };

            int[,] result = Matrix.Divide(matrix, 2);
            Assert.AreEqual(0, result[0, 0]);
        }

        [Test]
        public void TestDivideWithNegativeValue()
        {
            int[,] matrix = new int[,]
            {
                { -1, -2, -3 },
                { -4, -5, -6 },
                { -7, -8, -9 }
            };

            int[,] result = Matrix.Divide(matrix, -2);
            Assert.AreEqual(3, result[1, 2]);
        }

        [Test]
        public void TestDivideNull()
        {
            int[,] matrix = null;
            int[,] result = Matrix.Divide(matrix, 2);
            Assert.IsNull(result);            
        }
    }
}