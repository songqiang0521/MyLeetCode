using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber_CS
{
    public class Solution2
    {
        public int Reverse(int x)
        {
            char[] nums = null;
            long y = x;
            bool sign = y > 0;
            if (y > 0)
            {
                nums = y.ToString().ToCharArray();
            }
            else
            {
                y = -y;
                nums = y.ToString().ToCharArray();
            }

            char[] nums2 = new char[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                nums2[i] = nums[nums.Length - i - 1];
            }

            string r = new string(nums2);
            if (!sign)
            {
                r = "-" + r;
            }
            long result = Convert.ToInt64(r);

            if (result > int.MaxValue)
            {
                return 0;

            }
            if (result < int.MinValue)
            {
                return 0;
            }

            return (int)result;


        }
    }

    public class Solution
    {
        public int Reverse(int x)
        {
            int y = 0;
            int n;
            while (x != 0)
            {
                //余数
                n = x % 10;
                if (y > int.MaxValue / 10 || y < int.MinValue / 10)
                {
                    return 0;
                }
                y = y * 10 + n;
                x /= 10;
            }
            return y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int x = 123456789;

            Solution s = new Solution();
            int result=s.Reverse(x);
            Console.WriteLine(result);

        }
    }
}
