using System;
using System.Linq;
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

        [TestMethod]
        public void input_aa_b_and_1_should_return_aa()
        {
            LongestConsecShouldBe("aa", new[] { "aa", "b" }, 1);
        }

        [TestMethod]
        public void input_aa_b_and_n1_should_return_empty()
        {
            LongestConsecShouldBe("", new[] { "aa", "b" }, -1);
        }

        [TestMethod]
        public void input_aa_b_and_3_should_return_empty()
        {
            LongestConsecShouldBe("", new[] { "aa", "b" }, 3);
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
            var result = "";
            if (k <= 0 || strarr.Length < k)
            {
                return result;
            }

            for (int i = 0; i < strarr.Length; i++)
            {
                if (i + 1 >= strarr.Length)
                {
                    break;
                }
                result = strarr[i].Length > strarr[i + 1].Length ? strarr[i] : strarr[i + 1];
            }

            return result;
        }
    }
}
