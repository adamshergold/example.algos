using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace Algos.Lib.Test
{
    namespace HeapSort
    {
        public class ManualTestCases
        {
            public static IEnumerable<TestCaseData> Cases()
            {
                yield return new TestCaseData(new int[] { }).SetName(" Empty ");
            }
        }

        public class RandomTestCases
        {
            private static int nCases = 10;

            private static int maxLength = 16;

            private static int seed = 0;
            
            public static IEnumerable<TestCaseData> Cases()
            {
                for (var i = 0; i < nCases; i++)
                {
                    yield return new TestCaseData(Helpers.Random(seed, maxLength, -16, 16));
                }    
            }
        }

//        [TestFixture]
//        public class HeapSortTests
//        {
//            [TestCaseSource(typeof(ManualTestCases), "Cases")]
//            public void ManualTest(int[] vs)
//            {
//                HeapSort<int>.Sort(vs);
//                
//                var expected = Helpers.Copy<int>(vs);
//                Array.Sort(expected);
//                
//                Assert.AreEqual(expected,vs);
//            }
//            
//            [TestCaseSource(typeof(RandomTestCases), "Cases")]
//            public void RandomTest(int[] vs)
//            {
//                HeapSort<int>.Sort(vs);
//                
//                var expected = Helpers.Copy<int>(vs);
//                Array.Sort(expected);
//                
//                Assert.AreEqual(expected,vs);
//            }
//            
//        }
    }
} 