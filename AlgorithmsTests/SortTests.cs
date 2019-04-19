using Algorithms.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Algorithms.Tests
{
    [TestClass()]
    public class SortTests
    {
        private int[] SortedArray = null;
        private int[] InputArray = null;
        private double[] fiboncacci = null;

        private int[] GetInt(string lines)
        {
            return Array.ConvertAll(lines.Split(','), s => int.Parse(s));
        }
        private double[] GetFibo(string lines)
        {
            return Array.ConvertAll(lines.Split(','), s => double.Parse(s));
        }
        [TestInitialize]
        public void Setup()
        {
            SortedArray = GetInt(AlgorithmsTests.Properties.Resources.sorted);
            InputArray = GetInt(AlgorithmsTests.Properties.Resources.unsorted);
            fiboncacci = GetFibo(AlgorithmsTests.Properties.Resources.Fibonacci);
        }

        [TestMethod()]
        public void InsertionSortTest_Big()
        {
            var actual = InsertionSort.Sort(InputArray);
            CollectionAssert.AreEqual(SortedArray, actual);
        }

        [TestMethod()]
        public void MergeSortTest_Big()
        {
            var actual = MergeSort.Sort(InputArray);
            CollectionAssert.AreEqual(SortedArray, actual);
        }

        [TestMethod()]
        public void BubbleSortTest_Big()
        {
            var actual = BubbleSort.Sort(InputArray);
            CollectionAssert.AreEqual(SortedArray, actual);
        }


        [TestMethod()]
        public void FiboTest()
        {
            Assert.AreEqual(1, Fibonacci.GetFibo(1));
            Assert.AreEqual(1, Fibonacci.GetFibo(2));
            Assert.AreEqual(2, Fibonacci.GetFibo(3));
            Assert.AreEqual(double.Parse("832040"), Fibonacci.GetFibo(30));
        }
    }
}