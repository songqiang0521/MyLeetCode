using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace NumberOf1Bits_CS
{
    class Program
    {

        public static int HammingDistance(int x, int y)
        {
            uint r = (uint)(x ^ y);
            int count = NumberOf1Bits(r);
            return count;
        }


        public static int NumberOf1Bits(uint n)
        {
            int count = 0;

            for (int i = 0; i < 32; i++)
            {
                if ((n & 1) == 1)
                {
                    count++;
                }
                n >>= 1;
            }

            return count;
        }

        static void Main(string[] args)
        {
            Debug.Assert(NumberOf1Bits(15) == 4);


        }
    }
}
