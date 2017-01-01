using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoveElement_CS
{
    class Program
    {
        public static int RemoveElement2(int[] nums, int val)
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



        public static int RemoveElement(int[] nums, int val)
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

        static void Main(string[] args)
        {
            int nreLength = RemoveElement2(new int[] { 1, 2, 3, 4, 5, 6, 7, 3, 2, 4, 5, 6 }, 4);
        }
    }
}
