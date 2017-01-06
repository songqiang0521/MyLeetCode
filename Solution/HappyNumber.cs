using System.Collections.Generic;

namespace Solutions
{
    public class HappyNumberSolution
    {
        public int Convert(int num)
        {
            int ret = 0;

            while (num > 0)
            {
                ret += (num % 10) * (num % 10);
                num = num / 10;
            }

            return ret;
        }

        public bool IsHappy(int n)
        {
            int threshold = 0;
            while (threshold < 100)
            {
                n = Convert(n);
                if (n == 1)
                {
                    return true;
                }
                threshold++;
            }
            return false;
        }
    }
}
