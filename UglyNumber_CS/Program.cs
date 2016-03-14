using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UglyNumber_CS
{
    class Program
    {
        public static bool IsUgly(int num)
        {
            if (num == 1)
            {
                return true;
            }
            if (num == 0)
            {
                return false;
            }
            while (num % 2 == 0) num /= 2;
            while (num % 3 == 0) num /= 3;
            while (num % 5 == 0) num /= 5;

            return num == 1;
        }

        static void Main(string[] args)
        {

            var is19 = IsUgly(19);
        }
    }
}
