using System;
using System.Linq;

namespace Algos.Lib
{
    public class Helpers
    {
        public static void Swap<T>(T[] vs, int i, int j)
        {
            var t = vs[j];
            vs[j] = vs[i];
            vs[i] = t;
        }

        public static T[] Copy<T>(T[] vs)
        {
            var res = new T[vs.Length];
            vs.CopyTo(res, 0);
            return res;
        }

        public static string RandomIntArray(int seed, int maxLength, int minValue, int maxValue)
        {
            var rnd = new System.Random(seed);

            var len = rnd.Next() % maxLength;

            var res = new int[len];
            for (var i = 0; i < len; i++)
            {
                res[i] = minValue + (int) (rnd.NextDouble() * (maxValue - minValue));
            }

            return String.Join(" ", res);
        }

        public static int[] StringToIntArray(string sv)
        {
            return sv.Split(new char[]{}, StringSplitOptions.RemoveEmptyEntries).Select(v => System.Int32.Parse(v)).ToArray();
        }
        
        public static string IntArrayToString(int[] vs)
        {
            return String.Join(" ", vs);
        }
    }
}