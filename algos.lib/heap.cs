using System;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;

namespace Algos.Lib
{
    public class Heap<T> where T:System.IComparable 
    {
        public static int LeftChild(int i)
        {
            return 2 * i + 1; 
        }

        public static int RightChild(int i)
        {
            return 2 * i + 2;
        }

        public static int Parent(int i)
        {
            return (i - 1) / 2;
        }

        public static bool IsHeap(T[] vs)
        {
            bool impl(int root)
            {
                var li = LeftChild(root);
                var ri = RightChild(root);

                var isLeftHeap = li < vs.Length ? impl(li) && vs[li].CompareTo(vs[root]) <= 0 : true;
                var isRightHeap = ri < vs.Length ? impl(ri) && vs[ri].CompareTo(vs[root]) <= 0 : true;

                return isLeftHeap && isRightHeap;
            }

            return impl(0);
        }

        public static void SiftDown(T[] vs, int start, int end )
        {
            var root = start;
            var done = LeftChild(root) >= end;

            while (!done)
            {
                var swap = root;

                var li = LeftChild(root);
                if (vs[li].CompareTo(vs[root]) > 0)
                {
                    swap = li;
                }

                var ri = RightChild(root);
                if (ri < end && vs[ri].CompareTo(vs[swap]) > 0)
                {
                    swap = ri;
                }

                if (swap != root)
                {
                    Helpers.Swap(vs,swap,root);
                    root = swap;
                }

                done = LeftChild(root) >= end;
            }
        }
        
        public static void Heapify(T[] vs)
        {
            var i = Parent(vs.Length - 1);
            
            while (i >= 0)
            {
                SiftDown(vs, i, vs.Length - 1);
                i--;
            }
        }
    }
}