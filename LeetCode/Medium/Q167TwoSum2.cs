using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    public class Q167TwoSum2
    {
        public void Solution()
        {
            int[] numbers = new int[] { 2, 3, 4 };
            TwoSum(numbers, 6);
        }

        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0, right = numbers.Length - 1, pivot = numbers.Length / 2;
            while (numbers[pivot] + numbers[left] > target)
            {
                right = pivot;
                pivot = pivot / 2;
            }
            while (numbers[pivot] + numbers[right] < target)
            {
                left = pivot;
                pivot = (right + left) / 2;
            }

            while (left < right)
            {
                if (numbers[left] + numbers[right] == target)
                    return new int[] { left + 1, right + 1 };
                else if (numbers[left] + numbers[right] > target)
                    right--;
                else
                    left++;
            }
            return numbers;
        }
    }
}
