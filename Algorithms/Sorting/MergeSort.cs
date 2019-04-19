using System;

namespace Algorithms
{
    public class MergeSort
    {
        private static int[] merge(int[] a, int[] b)
        {
            int len = a.Length + b.Length;
            int i = 0, ia = 0, ib = 0;

            int[] retVal = new int[len];

            while (i < len)
            {
                if (ia == a.Length || ib == b.Length)
                {
                    if (ia == a.Length && ib != b.Length)
                    {
                        Array.Copy(b, ib, retVal, i, b.Length - ib);
                    }
                    else
                    {
                        Array.Copy(a, ia, retVal, i, a.Length - ia);
                    }
                    i = len;
                }
                else
                {
                    if (a[ia] > b[ib])
                    {
                        retVal[i++] = b[ib++];
                    }
                    else
                    {
                        retVal[i++] = a[ia++];
                    }
                }
            }
            return retVal;
        }
        public static int[] Sort(int[] inp)
        {
            if (inp.Length == 1)
            {
                return inp;
            }
            else
            {
                int mid = inp.Length / 2;
                int[] a = new int[mid];
                int[] b = new int[inp.Length - mid];

                Array.Copy(inp, 0, a, 0, a.Length);
                Array.Copy(inp, a.Length, b, 0, b.Length);

                a = Sort(a);
                b = Sort(b);

                return merge(a, b);
            }
        }
    }
}
