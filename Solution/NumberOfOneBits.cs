
namespace Solutions
{
    public class NumberOfOneBits
    {
        public int HammingDistance(int x, int y)
        {
            uint r = (uint)(x ^ y);
            int count = NumberOf1Bits(r);
            return count;
        }

        public int NumberOf1Bits(uint n)
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
    }
}
