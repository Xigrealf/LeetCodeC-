using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class Q557ReverseWordsInAStringIII
    {
        public void Solution()
        {
            string s = "God Damn It";
            ReverseWords(s);
        }

        public string ReverseWords(string s)
        {
            string[] Reverse = s.Split(' ');
            char[] temp;
            char tempChar;
            for (int i = 0; i < Reverse.Length; i++)
            {
                temp = Reverse[i].ToCharArray();
                int left = 0, right = temp.Length - 1;
                while (left < right)
                {
                    tempChar = temp[right];
                    temp[right] = temp[left];
                    temp[left] = tempChar;
                    left++; right--;
                }
                Reverse[i] = new string(temp);
            }

            return string.Join(" ", Reverse);
        }
    }
}
