namespace Algorithms.Sorting
{
    public class InsertionSort
    {
        public static int[] Sort(int[] inp)
        {
            for (int i = 1; i < inp.Length; i++)
            {
                int j = i;
                int n = inp[j];

                while (j > 0 && inp[j - 1] > n)
                {
                    inp[j] = inp[--j];
                }
                inp[j] = n;
            }
            return inp;
        }
    }
}
