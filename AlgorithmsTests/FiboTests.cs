using Algorithms.Sorting;
using NUnit.Framework;

namespace AlgorithmsTests
{
    [TestFixture]
    public class FiboTests
    {
        [Test]
        public void FiboTest()
        {
            Assert.AreEqual(1, Fibonacci.GetFibo(1));
            Assert.AreEqual(1, Fibonacci.GetFibo(2));
            Assert.AreEqual(2, Fibonacci.GetFibo(3));
            Assert.AreEqual(double.Parse("832040"), Fibonacci.GetFibo(30));
        }
    }
}
