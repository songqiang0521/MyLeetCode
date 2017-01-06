using System.Collections.Generic;
using System;

namespace Solutions
{
    public class RemoveElementSolution
    {
        public int RemoveElement2(int[] nums, int val)
        {
            int oldCount = 0;
            Array.Sort(nums);
            int frontIndex = Array.IndexOf(nums, val);
            int backIndex = Array.LastIndexOf(nums, val);
            if (frontIndex == -1 && -1 == backIndex)
            {
                return nums.Length;
            }

            oldCount = frontIndex;
            int moveCount = 0;
            backIndex++;
            while (backIndex < nums.Length)
            {
                nums[frontIndex] = nums[backIndex];
                frontIndex++;
                backIndex++;
                moveCount++;
            }
            //moveCount--;
            return oldCount + moveCount;
        }

        public int RemoveElement(int[] nums, int val)
        {
            int index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[index++] = nums[i];
                }
            }

            return index;
        }
    }
}
