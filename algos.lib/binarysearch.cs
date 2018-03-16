namespace Algos.Lib
{
    public class BinarySearch<T> where T : System.IComparable
    {
        public static int Search(T[] vs, T target)
        {
            var i = 0;
            var j = System.Math.Max(0,vs.Length - 1);

            var done = i == j;

            while (!done)
            {
                var mid = (i + j) / 2;

                if (vs[mid].CompareTo(target) < 0 )
                {
                    i = mid + 1;
                }
                else
                {
                    j = mid;
                }

                done = i == j;
            }
            
            return i < vs.Length && vs[i].CompareTo(target) == 0 ? i : -1;
        }
    }
}