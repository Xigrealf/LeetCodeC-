using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    public class Q3LongestSubstringWithoutRepeatingCharacters
    {
        public void Solution()
        {
            LengthOfLongestSubstring("abcabcbb");
        }

        public int LengthOfLongestSubstring(string s)
        {
            int ptr = 0;
            string currentMaxString = "";
            char[] chars = s.ToCharArray();
            while (ptr < s.Length)
            {
                List<char> charsToReturn = new List<char>();
                for (int i = ptr; i < chars.Length; i++)
                {
                    if (charsToReturn.IndexOf(chars[i]) < 0)
                    {
                        charsToReturn.Add(chars[i]);
                    }
                    else
                        break;
                }
                if (charsToReturn.Count > currentMaxString.Length)
                    currentMaxString = new string(charsToReturn.ToArray());
                ptr++;
            }
            return currentMaxString.Length;
        }
    }
}
