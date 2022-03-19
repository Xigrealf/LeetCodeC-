using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class Q278FirstBadVersion
    {
        public int badVersion = 0;
        public void Solution()
        {
            int n = 5;
            badVersion = 4;
            FirstBadVersion(n);
        }
        public int FirstBadVersion(int n)
        {
            int pivot = n / 2;
            bool bad = IsBadVersion(pivot);
            int latestBad = n;
            while (1 == 1)
            {
                if (bad)
                {
                    latestBad = pivot;
                    if (!IsBadVersion(pivot - 1))
                        return (pivot);
                    pivot = pivot / 2;
                }
                else
                {
                    if (IsBadVersion(pivot + 1))
                        return pivot + 1;
                    pivot = ((latestBad - pivot) / 2) + pivot;
                }
                bad = IsBadVersion(pivot);
            }
        }

        public bool IsBadVersion(int version)
        {
            if (version >= badVersion)
                return true;
            else
                return false;
        }
    }
}
