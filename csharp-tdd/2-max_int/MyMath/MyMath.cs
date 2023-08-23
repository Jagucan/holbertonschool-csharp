using System;
using System.Collections.Generic;

namespace MyMath
{
    public class Operations
    {
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
            {
                return 0;
            }
            int maxNum = nums[0];

            for (int item = 1; item < nums.Count; item++)
            {
                int num = nums[item];

                if (maxNum < num)
                {
                    maxNum = num;
                }
            }
            return maxNum;
        }
    }
}
