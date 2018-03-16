using System.Collections.Generic;

using NUnit.Framework;

namespace Algos.Lib.Test
{
    namespace Heap
    {
        public class ManualTests
        {
            public static IEnumerable<TestCaseData> Cases()
            {
                yield return new TestCaseData(new int[] { }).SetName("Empty").Returns(true);
                yield return new TestCaseData(new int[] { 1 }).SetName("{ 1 }").Returns(true);
                yield return new TestCaseData(new int[] { 1, 2 }).SetName("{ 1, 2 }").Returns(false);
                yield return new TestCaseData(new int[] { 2, 1 }).SetName("{ 2, 1 }").Returns(true);
            }
        }

        [TestFixture]
        public class ManualHeapTests
        {
            [TestCaseSource(typeof(ManualTests), "Cases")]
            public bool Test(int[] vs)
            {
                Algos.Lib.Heap<int>.Heapify(vs);
                return Algos.Lib.Heap<int>.IsHeap(vs);
            }
        }
    }
}