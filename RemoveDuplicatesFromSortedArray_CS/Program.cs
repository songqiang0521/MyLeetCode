using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesFromSortedArray_CS
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int firstIndex = 0;
            int secondIndex = 0;
            if (nums.Length < 1)
            {
                return 0;
            }
            else if (nums.Length < 2)
            {
                return 1;
            }
            else
            {
                for (secondIndex = 1; secondIndex < nums.Length; secondIndex++)
                {
                    if (nums[firstIndex] != nums[secondIndex])
                    {
                        firstIndex++;
                        nums[firstIndex] = nums[secondIndex];
                    }
                }

                return firstIndex + 1;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
