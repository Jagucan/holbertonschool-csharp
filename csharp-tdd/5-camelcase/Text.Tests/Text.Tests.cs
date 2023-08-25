using NUnit.Framework;
using Text;

namespace TextTests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void TestCamelCase_ValidString()
        {
            string input = "thisIsCamelCasevalidString";
            int result = Str.CamelCase(input);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void TestCamelCase_EmptyString()
        {
            string input = "";
            int result = Str.CamelCase(input);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestCamelCase_NullString()
        {
            string input = null;
            int result = Str.CamelCase(input);
            Assert.AreEqual(0, result);
        }
    }
}
