namespace LeetCodeProblems.Tests
{
    public class MedianofTwoSortedArraysTests
    {
        private readonly MedianofTwoSortedArrays sut;

        public MedianofTwoSortedArraysTests()
        {
            sut = new();
        }

        [Fact]
        public void Test1()
        {
            // Given
            var nums1 = new int[] { 1, 3 };
            var nums2 = new int[] { 2 };
            // When
            var acual = sut.Solution(nums1, nums2);
            // Then
            Assert.Equal(2.00000, acual);
        }

        [Fact]
        public void Test2()
        {
            // Given
            var nums1 = new int[] { 1, 2 };
            var nums2 = new int[] { 3, 4 };
            // When
            var acual = sut.Solution(nums1, nums2);
            // Then
            Assert.Equal(2.50000, acual);
        }

        [Fact]
        public void Test3()
        {
            // Given
            var nums1 = new int[] { 1, 1 };
            var nums2 = new int[] { 1, 2 };
            // When
            var acual = sut.Solution(nums1, nums2);
            // Then
            Assert.Equal(1.00000, acual);
        }
    }
}