using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class Q238MoveZeroes
    {
        public void Solution()
        {
            int[] nums = new int[] { 0, 1 };
            MoveZeroesOptimal(nums);
        }

        public void MoveZeroes(int[] nums)
        {
            int rotateKeeper = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0 && rotateKeeper < nums.Length)
                {
                    for (int j = i; j < nums.Length - 1; j++)
                    {
                        nums[j] = nums[j + 1];
                    }
                    nums[nums.Length - 1] = 0;
                    i--;
                }
                rotateKeeper++;
            }
        }

        public void MoveZeroesSecondTry(int[] nums)
        {
            int left = 0, right = nums.Length - 1;
            while (left < right)
            {
                if (nums[left] == 0)
                {
                    for (int j = left; j < right; j++)
                    {
                        nums[j] = nums[j + 1];
                    }
                    nums[right] = 0;
                    right--;
                }
                else
                    left++;
            }
        }

        public void MoveZeroesOptimal(int[] nums)
        {
            int left = 0, zeroCount = 0;
            while (left < nums.Length)
            {
                if (left + zeroCount > nums.Length - 1)
                {
                    for (int i = left; i < nums.Length; i++)
                    {
                        nums[i] = 0;
                    }
                    break;
                }
                else
                {
                    if (nums[left + zeroCount] == 0)
                    {
                        zeroCount++;
                    }
                    else
                    {
                        nums[left] = nums[left + zeroCount];
                        left++;
                    }
                }
            }
        }
    }
}
