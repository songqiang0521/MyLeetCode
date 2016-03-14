using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoveElement_CS
{
    class Program
    {
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
            int nreLength = RemoveElement(new int[] { 1, 2, 3, 4, 5, 6, 7, 3, 2, 4, 5, 6 }, 4);
        }
    }
}
