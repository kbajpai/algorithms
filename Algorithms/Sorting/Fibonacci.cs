namespace Algorithms.Sorting
{
    public class Fibonacci
    {
        public static double GetFibo(double n)
        {
            if (n == 0 || n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return GetFibo(n - 2) + GetFibo(n - 1);
            }
        }
    }
}
