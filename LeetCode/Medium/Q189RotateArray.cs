using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    public class Q189RotateArray
    {
        public void Solution()
        {
            int[] nums = new int[] { -1 };
            Rotate(nums, 2);
        }

        public void Rotate(int[] nums, int k)
        {
            if (k > nums.Length)
                k = k % nums.Length;
            if (k == nums.Length)
                k = 0;
            int right = nums.Length - 1, left = 0;
            int[] temp = new int[k];
            for (int i = nums.Length - k; i < nums.Length; i++)
            {
                temp[left] = nums[i];
                left++;
            }
            for (int i = nums.Length - 1; i - k >= 0; i--)
            {
                nums[i] = nums[i - k];
            }
            for (int i = 0; i < k; i++)
            {
                nums[i] = temp[i];
            }
        }

        public void RotateOptimal(int[] nums, int k)
        {

        }
    }
}
