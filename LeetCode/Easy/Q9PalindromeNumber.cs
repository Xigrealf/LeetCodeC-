using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class Q9PalindromeNumber
    {
        public void Solution()
        {
            int x = 121;
            IsPalindromeReverseString(x);
        }

        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
                return false;
            int left = 0, right = x.ToString().Length - 1;
            char[] temp = x.ToString().ToCharArray();
            while (left < right)
            {
                if (temp[left] == temp[right])
                {
                    left++; right--;
                }
                else
                    return false;
            }

            return true;
        }

        public bool IsPalindromeReverseString(int x)
        {
            string a = new string(x.ToString().Reverse().ToArray());
            if (a == x.ToString())
                return true;
            else
                return false;
        }
    }
}
