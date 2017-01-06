using System.Collections.Generic;
using System;

namespace Solutions
{
    public class MajorityElementSolution
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>(nums.Length / 2);

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]]++;
                }
                else
                {
                    dic[nums[i]] = 0;
                }
            }
            foreach (var key in dic.Keys)
            {
                if (dic[key] >= nums.Length / 2)
                {
                    return key;

                }
            }

            return 0;
        }
    }
}
