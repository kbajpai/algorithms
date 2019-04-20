using System;

namespace Algorithms.Sorting
{
    public class MergeSort
    {
        private static int[] Merge(int[] a, int[] b)
        {
            int ia = 0, ib = 0;
            int[] retVal = new int[a.Length + b.Length];

            for (int i = 0; i < a.Length + b.Length;)
            {
                if (ia == a.Length && ib != b.Length)
                {
                    Array.Copy(b, ib, retVal, i, retVal.Length - i);
                    i = retVal.Length;
                }
                else if (ib == b.Length && ia != a.Length)
                {
                    Array.Copy(a, ia, retVal, i, retVal.Length - i);
                    i = retVal.Length;
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
                //Divide
                int[] a = new int[inp.Length / 2];
                int[] b = new int[inp.Length - a.Length];

                Array.Copy(inp, 0, a, 0, a.Length);
                Array.Copy(inp, a.Length, b, 0, b.Length);

                a = Sort(a);
                b = Sort(b);

                return Merge(a, b);
            }
        }
    }
}
