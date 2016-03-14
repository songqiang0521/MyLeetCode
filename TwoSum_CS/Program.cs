using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] indexes = new int[nums.Length];
            int[] org = new int[nums.Length];
            Array.Copy(nums, org, org.Length);

            for (int i = 0; i < indexes.Length; i++)
            {
                indexes[i] = i;
            }

            Array.Sort(nums, indexes);

            for (int i = 0; i < nums.Length; i++)
            {
                int part1 = nums[i];
                int indexPart1 = indexes[i];
                int part2 = target - part1;
                int index = Array.BinarySearch(nums, i + 1, nums.Length - 1 - i, part2);
                if (index > 0)
                {
                    int indexPart2 = indexes[index];
                    var ret = new int[2];
                    ret[0] = Math.Min(indexPart1, indexPart2);
                    ret[1] = Math.Max(indexPart1, indexPart2);

                    return new int[] { ret[0] + 1, ret[1] + 1 };
                }
            }
            return null;
        }


        public int[] TwoSum2(int[] nums, int target)
        {

            Dictionary<int, int> dic = new Dictionary<int, int>(nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {

                int other = target - nums[i];
                int value;
                bool find = dic.TryGetValue(other, out value);
                if (find)
                {
                    int[] ret = new int[2];
                    ret[0] = Math.Min(i + 1, value + 1);
                    ret[1] = Math.Max(i + 1, value + 1);
                    return new int[] { ret[0], ret[1] };
                }
                else
                {
                    dic[nums[i]] = i;
                }

            }
            return null;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //var ret = s.TwoSum(new int[] { 0, 4, 3, 0 }, 0);
            var ret = s.TwoSum(new int[] { 3, 2, 4 }, 6);
        }
    }
}