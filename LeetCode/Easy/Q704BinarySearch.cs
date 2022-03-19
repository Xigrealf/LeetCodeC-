using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class Q704BinarySearch
    {
        public void Solution()
        {
            int[] nums = new int[] { -1, 0, 3, 5, 9, 12 };
            Search(nums, 2);
        }

        public int Search(int[] nums, int target)
        {
            bool? lastDirectionMinus = null;
            for (int i = nums.Length / 2; i < nums.Length;)
            {
                if (nums[i] == target)
                    return i;
                else if (nums[i] > target)
                {
                    if (lastDirectionMinus == false)
                        return -1;
                    lastDirectionMinus = true;
                    i--;
                    if (i < 0)
                        return -1;
                }
                else
                {
                    if (lastDirectionMinus == true)
                        return -1;
                    lastDirectionMinus = false;
                    i++;
                    if (i > nums.Length)
                        return -1;
                }
            }
            return -1;
        }

        public int OptimalSearch(int[] nums, int target)
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
            return -1;
        }
    }
}
