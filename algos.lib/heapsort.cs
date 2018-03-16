namespace Algos.Lib
{
    public class HeapSort<T> where T:System.IComparable
    {
        public static void Sort(T[] vs)
        {
            Heap<T>.Heapify(vs);
            for (var i = vs.Length-1; i >=0; i-- )
            {
                Helpers.Swap(vs, 0, i);
                Heap<T>.SiftDown(vs,0,i);
            }
        }
    }
}