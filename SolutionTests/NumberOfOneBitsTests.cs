using Xunit;

namespace SolutionTests
{
    public class NumberOfOneBitsTests
    {
        [Fact]
        public void Test_1()
        {
            Solutions.NumberOfOneBits s = new Solutions.NumberOfOneBits();
            Assert.True(s.NumberOf1Bits(15)==4);
        }

        [Fact]
        public void Test_2()
        {
            Solutions.NumberOfOneBits s = new Solutions.NumberOfOneBits();
            Assert.True(s.HammingDistance(15,0) == 4);
        }
    }
}
