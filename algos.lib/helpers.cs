namespace Algos.Lib
{
    public class Helpers
    {
        public static void Swap<T>(T[] vs, int i, int j)
        {
            var t = vs[j];
            vs[j] = vs[i];
            vs[i] = vs[j];
        }

        public static T[] Copy<T>(T[] vs)
        {
            var res = new T[vs.Length];
            vs.CopyTo(res, 0);
            return res;
        }

        public static int[] Random(int seed, int maxLength, int minValue, int maxValue)
        {
            var rnd = new System.Random(seed);

            var len = rnd.Next() % maxLength;

            var res = new int[len];
            for (var i = 0; i < len; i++)
            {
                res[i] = minValue + (int) (rnd.NextDouble() * (maxValue - minValue));
            }

            return res;
        }
    }
}