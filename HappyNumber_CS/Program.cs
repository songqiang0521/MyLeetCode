using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace HappyNumber_CS
{
    class Program
    {

        public static int Convert(int num)
        {
            int ret = 0;

            while (num > 0)
            {
                ret += (num % 10) * (num % 10);
                num = num / 10;
            }

            return ret;
        }

        public static bool IsHappy(int n)
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

        static void Main(string[] args)
        {
            Debug.Assert(IsHappy(19));
        }
    }
}
