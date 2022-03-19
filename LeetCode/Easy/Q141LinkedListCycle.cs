using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class Q141LinkedListCycle
    {
        public void Solution()
        {
            int[] nums = new int[] { 1, 3, 4, 6, 7, 10 };
            int[] targets = new int[] { 11 };

            foreach (int item in targets)
            {
                SearchInsert(nums, item);
            }
        }

        public int SearchInsert(int[] nums, int target)
        {
            int pivot, left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                pivot = left + (right - left) / 2;
                if (nums[pivot] == target)
                    return pivot;
                if (target < nums[pivot])
                    right = pivot - 1;
                else
                    left = pivot + 1;
            }

            return left;
        }
    }
}
