using NUnit.Framework;
using Text;

namespace TextTests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void TestPalindrome_ValidPalindrome()
        {
            string input = "racecar";
            bool result = Str.IsPalindrome(input);
            Assert.IsTrue(result);
        }

        [Test]
        public void TestPalindrome_ValidPalindromeWithPunctuation()
        {
            string input = "A man, a plan, a canal: Panama.";
            bool result = Str.IsPalindrome(input);
            Assert.IsTrue(result);
        }

        [Test]
        public void TestPalindrome_Invalid()
        {
            string input = "hello";
            bool result = Str.IsPalindrome(input);
            Assert.IsFalse(result);
        }

        [Test]
        public void TestPalindrome_Empty()
        {
            string input = "";
            bool result = Str.IsPalindrome(input);
            Assert.IsTrue(result);
        }
    }
}
