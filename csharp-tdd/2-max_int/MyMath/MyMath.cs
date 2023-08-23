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
            int num = 0;
            int maxNum = 0;
            int contList = nums.Count;

            for (int item = 0; item < contList; item++)
            {
                    num = nums[item];

                    if (maxNum < num)
                    {
                        maxNum = num;
                    }
            }
            return maxNum;
        }
    }
}
