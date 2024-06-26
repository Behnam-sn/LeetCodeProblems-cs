﻿namespace LeetCodeProblems;

// https://leetcode.com/problems/merge-sorted-array/description/

public class MergeSortedArray
{
    public static void Solution(int[] nums1, int m, int[] nums2, int n)
    {
        var i = m - 1;
        var j = n - 1;
        int k = m + n - 1;

        while (j >= 0)
        {
            if (i >= 0 && nums1[i] > nums2[j])
            {
                nums1[k--] = nums1[i--];
            }
            else
            {
                nums1[k--] = nums2[j--];
            }
        }
    }
}
