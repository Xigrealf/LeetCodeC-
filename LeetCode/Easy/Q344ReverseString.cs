using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class Q344ReverseString
    {
        public void Solution()
        {
            char[] chars = new char[] { 'h', 'e', 'l', 'l', 'o' };
            ReverseString(chars);
        }

        public void ReverseString(char[] s)
        {
            int left = 0, right = s.Length - 1;
            char temp;
            while (left < right)
            {
                temp = s[right];
                s[right] = s[left];
                s[left] = temp;
                left++; right--;
            }
        }
    }
}
