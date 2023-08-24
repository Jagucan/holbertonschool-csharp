using NUnit.Framework;
using Text;

namespace TextTests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void TestUniqueChar_Valid()
        {
            string input = "helo";
            int result = Str.UniqueChar(input);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestUniqueChar_NoNonRepeatingCharacter()
        {
            string input = "abcabc";
            int result = Str.UniqueChar(input);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void TestUniqueChar_Empty()
        {
            string input = "";
            int result = Str.UniqueChar(input);
            Assert.AreEqual(-1, result);
        }
    }
}
