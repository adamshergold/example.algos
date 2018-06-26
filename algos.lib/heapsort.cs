namespace Algos.Lib
{
    public class HeapSort<T> where T:System.IComparable
    {
        
        public static void Sort2(T[] vs)
        {
            int LeftChild(int i)
            {
                return 2 * i + 1;
            }

            int RightChild(int i)
            {
                return 2 * i + 2;
            }

            int Parent(int i)
            {
                return (i - 1) / 2;
            }
            
            // If xs[0..n-1] is a heap then we want xs[0..n] to be heap
            void SiftUp(T[] xs, int n)
            {
                var i = n;
                
                while (i>0)
                {
                    var p = Parent(i);
                    
                    // if this one bigger than parent then swap
                    if( xs[i].CompareTo( xs[p] ) > 0 )
                        Helpers.Swap(xs,p,i);

                    i = p;
                }
                return;
            }
            
            // If xs[1..n] is a heap and we want xs[0..n] to be
            void SiftDown(T[] xs, int n)
            {
                var i = 0;
                var done = i >= n;
                while (!done)
                {
                    var swap = i;

                    var lc = LeftChild(i);
                    var rc = RightChild(i);

                    swap = lc <= n && xs[lc].CompareTo(xs[i]) > 0 ? lc : swap;
                    swap = rc <= n && xs[rc].CompareTo(xs[swap]) > 0 ? rc : swap;
                    
                    if( i != swap )
                        Helpers.Swap(xs,i,swap);

                    done = i == swap;

                    i = swap;
                }
            }
            
            for( var i = 1; i < vs.Length; i++ )
                SiftUp(vs, i);

            for (var i = vs.Length - 1; i > 0; i--)
            {
                Helpers.Swap(vs,0,i);
                SiftDown(vs,i-1);
            }
        }

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