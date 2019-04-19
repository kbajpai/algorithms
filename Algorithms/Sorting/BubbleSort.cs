namespace Algorithms.Sorting
{
    public class BubbleSort
    {
        private static void Swap(int a, int b)
        {
            int n = a;
            a = b;
            b = n;
        }

        public static int[] Sort(int[] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = 0; j < input.Length - 1 - i; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        int n = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = n;
                    }
                }
            }
            return input;
        }
    }
}
