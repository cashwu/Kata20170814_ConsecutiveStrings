using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170814_ConsecutiveStrings
{
    [TestClass]
    public class ConsecutiveStringsTests
    {
        [TestMethod]
        public void input_a_b_and_0_should_return_empty()
        {
            LongestConsecShouldBe("", new[] { "a", "b" }, 0);
        }

        private static void LongestConsecShouldBe(string expected, string[] strarr, int count)
        {
            var longest = new LongestConsecutives();
            var actual = longest.LongestConsec(strarr, count);
            Assert.AreEqual(expected, actual);
        }
    }

    public class LongestConsecutives
    {
        public string LongestConsec(string[] strarr, int k)
        {
            return "";
        }
    }
}
