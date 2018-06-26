using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Algos.Lib.Test
{
    namespace HeapSort
    {
        public class ManualTestCases
        {
            public static IEnumerable<TestCaseData> Cases()
            {
                yield return new TestCaseData("");
            }
        }

        public class RandomTestCases
        {
            private static int nCases = 10;

            private static int maxLength = 10;

            private static int seed = 0;
            
            public static IEnumerable<TestCaseData> Cases()
            {
                for (var i = 0; i < nCases; i++)
                {
                    yield return new TestCaseData(Helpers.RandomIntArray(seed+i, maxLength, 0, 32));
                }    
            }
        }

        [TestFixture]
        public class HeapSortTests
        {
            [TestCaseSource(typeof(ManualTestCases), "Cases")]
            public void ManualTest(string sv)
            {
                var vs = Helpers.StringToIntArray(sv);
                
                HeapSort<int>.Sort2(vs);
                
                var expected = Helpers.Copy<int>(vs);
                Array.Sort(expected);
                
                Assert.AreEqual(expected,vs);
            }
            
            [TestCaseSource(typeof(RandomTestCases), "Cases")]
            public void RandomTest(string sv)
            {
                var vs = Helpers.StringToIntArray(sv);
                
                var expected = Helpers.Copy<int>(vs);
                Array.Sort(expected);
                
                HeapSort<int>.Sort2(vs);
                
                System.Console.WriteLine( "Input =[ {0} ]", sv );
                System.Console.WriteLine( "Result=[ {0} ]", Helpers.IntArrayToString(vs) );
                
                Assert.AreEqual(expected,vs);
            }
            
        }
    }
} 