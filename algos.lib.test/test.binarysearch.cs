using System.Collections.Generic;

using NUnit.Framework;
    
namespace Algos.Lib.Test
{
    namespace BinarySearch
    {
        public class TestCases
        {
            public static IEnumerable<TestCaseData> Cases()
            {
                yield return new TestCaseData(new int[] { }, 5).SetName("Empty").Returns(-1);
                yield return new TestCaseData(new int[] { 1 }, 0).SetName("{1},0").Returns(-1);
                yield return new TestCaseData(new int[] { 1 }, 1).SetName("{1},1").Returns(0);
                yield return new TestCaseData(new int[] { 1 }, 2).SetName("{1},1").Returns(-1);
                yield return new TestCaseData(new int[] { 1, 2, 4, 5 }, 4).SetName("{1,2,4,5},4").Returns(2);
                yield return new TestCaseData(new int[] { 1, 2, 4, 5 }, 1).SetName("{1,2,4,5},1").Returns(0);
                yield return new TestCaseData(new int[] { 1, 2, 4, 5 }, 5).SetName("{1,2,4,5},5").Returns(3);
            }
        }

        [TestFixture]
        public class Tests
        {
            [TestCaseSource(typeof(TestCases), "Cases")]
            public int Test(int[] vs, int target)
            {
                return BinarySearch<int>.Search(vs, target);
            }
        }
    }
}