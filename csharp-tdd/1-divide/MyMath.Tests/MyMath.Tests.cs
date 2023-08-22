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
        public void TestDivide()
        {
            int[,] matrix1 = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[,] result1;
            result1 = Matrix.Divide(matrix1, 0);
            
            int[,] matrix2 = new int[,]
            {
                { 2, 4, 6 },
                { 9, 12, 15 },
                { -1, -2, -3 }
            };
            int[,] result2;
            result2 = Matrix.Divide(matrix2, 5);

            int[,] matrix3 = new int[,]
            {
                { 0, 0 },
                { 0, 0 },
                { 0, 0 }
            };

            int[,] result3;
            result3 = Matrix.Divide(matrix1, 0);

            int[,] matrix4 = new int[,]
            {
                { -1, -2, -3 },
                { -4, -5, -6 },
                { -7, -8, -9 }
            };

            int[,] result4;
            result4 = Matrix.Divide(matrix1, -2);
        }
    }
}