using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    public class Q7ReverseInteger
    {
        public void Solution()
        {
            int[] ints = new int[] { 1534236469, 0, 123, -123, 120 };
            foreach (var item in ints)
            {
                Reverse(item);
            }
        }

        public int Reverse(int x)// Pop & Push Seems More Optimal
        {
            bool minus = false;
            while (x % 10 == 0 && x != 0)
                x = x / 10;
            if (x < 0)
            {
                x = x * -1;
                minus = true;
            }
            int left = 0, right = x.ToString().Length - 1;
            char[] temp = x.ToString().ToCharArray();
            char tempChar;
            while (left < right)
            {
                tempChar = temp[left];
                temp[left] = temp[right];
                temp[right] = tempChar;
                left++;
                right--;
            }
            try
            {
                if (minus)
                    return Convert.ToInt32("-" + new string(temp));
                else
                    return Convert.ToInt32(new string(temp));
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
