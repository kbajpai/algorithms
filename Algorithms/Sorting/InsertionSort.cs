namespace Algorithms
{
    public class InsertionSort
    {
        public static int[] Sort(int[] input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                int j = i;
                int n = input[j];

                while (j > 0 && input[j - 1] > n)
                {
                    input[j] = input[--j];
                }
                input[j] = n;
            }
            return input;
        }
    }
}
