﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    public class Q567PermutationInString
    {
        public void Solution()
        {
            CheckInclusion("ab", "eidbaooo");
        }
        public bool CheckInclusion(string s1, string s2)
        {
            int[] s1Frequency = getFrequency(s1);
            int[] s2Frequency = getFrequency(s2);

            bool result = false;
            if (s1.Length <= s2.Length)
            {
                result = check(s2, s1Frequency, s1.Length);
            }

            return result;
        }

        private int[] getFrequency(string s)
        {
            int[] frequency = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                frequency[s[i] - 'a']++;
            }
            return frequency;
        }

        private bool compare(int[] frequency1, int[] frequency2)
        {
            for (int i = 0; i < 26; i++)
            {
                if (frequency1[i] != frequency2[i])
                {
                    return false;
                }
            }

            return true;
        }

        private bool check(string s, int[] s2Frequency, int length)
        {
            int[] frequency = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                frequency[s[i] - 'a']++;

                if (compare(frequency, s2Frequency))
                {
                    return true;
                }

                if (i >= length - 1)
                {
                    frequency[s[i - length + 1] - 'a']--;
                }
            }

            return false;
        }
    }
}
