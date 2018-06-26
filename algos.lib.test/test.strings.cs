using System.Collections.Generic;

using NUnit.Framework;

namespace Algos.Lib.Test
{
    namespace Strings
    {
        [TestFixture]
        public class PalindromePermutationsTests
        {
            public static IEnumerable<TestCaseData> Cases()
            {
                yield return new TestCaseData("tact coa").Returns(true);
            }

            [TestCaseSource("Cases")]
            public bool Test(string a)
            {
                return Algos.Lib.Strings.PalindromePermutation(a);
            }
        }
    }
}