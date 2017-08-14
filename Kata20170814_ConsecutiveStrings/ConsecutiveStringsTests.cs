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

        [TestMethod]
        public void input_aa_b_c_and_2_should_return_aab()
        {
            LongestConsecShouldBe("aab", new[] { "aa", "b", "c" }, 2);
        }


        [TestMethod]
        public void input_b_c_aa_and_2_should_return_aab()
        {
            LongestConsecShouldBe("caa", new[] { "b", "c", "aa" }, 2);
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
        public string LongestConsec(string[] strarr, int count)
        {
            var result = "";

            for (var i = 0; i + count <= strarr.Length; i++)
            {
                var str = CompareString(strarr, i, count);
                result = result.Length > str.Length ? result : str;
            }

            return result;
        }

        private static string CompareString(string[] strarr, int idx, int count)
        {
            var result = "";
            for (var j = idx; j < idx + count; j++)
            {
                result += strarr[j];
            }

            return result;
        }
    }
}
