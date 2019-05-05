using Algorithms.Sorting;
using NUnit.Framework;
using System;

namespace Algorithms.Tests
{
    [TestFixture]
    public class SortTests
    {
        private int[] sortedTenThou = null;
        private int[] revSortedTenThou = null;
        private int[] unsortedTenThou = null;
        private int[] million = null;
        private int[] milSorted = null;
        private int[] revMilSorted = null;
        private int[] tenMill = null;
        private int[] tenMillSort = null;
        private int[] tenMillRevSort = null;

        private int[] GetInt(string lines)
        {
            return Array.ConvertAll(lines.Replace(Environment.NewLine, ",")
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries), s => int.Parse(s));
        }
        [OneTimeSetUp]
        public void Setup()
        {
            million = GetIntegers()
            //sortedTenThou = GetInt(AlgorithmsTests.Properties.Resources.sorted);
            //revSortedTenThou = GetInt(AlgorithmsTests.Properties.Resources.revSort);
            //unsortedTenThou = GetInt(AlgorithmsTests.Properties.Resources.unsorted);
            //million = GetInt(AlgorithmsTests.Properties.Resources.million);
            //milSorted = GetInt(AlgorithmsTests.Properties.Resources.milSort);
            //revMilSorted = GetInt(AlgorithmsTests.Properties.Resources.milRevSort);
            //tenMill = GetInt(AlgorithmsTests.Properties.Resources.tenMill);
            //tenMillRevSort = GetInt(AlgorithmsTests.Properties.Resources.tenMillRevSort);
            //tenMillSort = GetInt(AlgorithmsTests.Properties.Resources.tenMillSort);
        }
        [Test]
        public void InsertionSortTestBigO()
        {
            var actual = InsertionSort.Sort(unsortedTenThou);
            CollectionAssert.AreEqual(sortedTenThou, actual);
        }
        [Test]
        public void InsertionSortTestBestCase()
        {
            var actual = InsertionSort.Sort(sortedTenThou);
            CollectionAssert.AreEqual(sortedTenThou, actual);
        }
        [Test]
        public void InsertionSortTestWorstCase()
        {
            var actual = InsertionSort.Sort(revSortedTenThou);
            CollectionAssert.AreEqual(sortedTenThou, actual);
        }
        [Test]
        public void MergeSortTestBigO()
        {
            var actual = MergeSort.Sort(unsortedTenThou);
            CollectionAssert.AreEqual(sortedTenThou, actual);
        }
        [Test]
        public void MergeSortTestBestCase()
        {
            var actual = MergeSort.Sort(sortedTenThou);
            CollectionAssert.AreEqual(sortedTenThou, actual);
        }
        [Test]
        public void MergeSortTestWorstCase()
        {
            var actual = MergeSort.Sort(revSortedTenThou);
            CollectionAssert.AreEqual(sortedTenThou, actual);
        }
        [Test]
        public void MergeSortTestMilBigO()
        {
            var actual = MergeSort.Sort(million);
            CollectionAssert.AreEqual(milSorted, actual);
        }
        [Test]
        public void MergeSortTestMilBestCase()
        {
            var actual = MergeSort.Sort(milSorted);
            CollectionAssert.AreEqual(milSorted, actual);
        }
        [Test]
        public void MergeSortTestMilWorstCase()
        {
            var actual = MergeSort.Sort(revMilSorted);
            CollectionAssert.AreEqual(milSorted, actual);
        }
        [Test]
        public void MergeSortTestTenMilBestCase()
        {
            var actual = MergeSort.Sort(tenMillSort);
            CollectionAssert.AreEqual(tenMillSort, actual);
        }
        [Test]
        public void MergeSortTestTenMilAvgCase()
        {
            var actual = MergeSort.Sort(tenMill);
            CollectionAssert.AreEqual(tenMillSort, actual);
        }
        [Test]
        public void MergeSortTestTenMilWorstCase()
        {
            var actual = MergeSort.Sort(tenMillRevSort);
            CollectionAssert.AreEqual(tenMillSort, actual);
        }
        [Test]
        public void BubbleSortTestBigO()
        {
            var actual = BubbleSort.Sort(unsortedTenThou);
            CollectionAssert.AreEqual(sortedTenThou, actual);
        }
        [Test]
        public void BubbleSortTestBestCase()
        {
            var actual = BubbleSort.Sort(sortedTenThou);
            CollectionAssert.AreEqual(sortedTenThou, actual);
        }
        [Test]
        public void BubbleSortTestWorstCase()
        {
            var actual = BubbleSort.Sort(revSortedTenThou);
            CollectionAssert.AreEqual(sortedTenThou, actual);
        }
    }
}