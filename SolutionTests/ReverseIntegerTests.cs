using Xunit;

namespace SolutionTests
{
    public class ReverseIntegerTests
    {
        [Fact]
        public void Test_1()
        {
            Solutions.ReverseIntegerSolution s = new Solutions.ReverseIntegerSolution();
            int x = 123456789;
            int result = s.Reverse1(x);
            Assert.True(result == 987654321);

            result = s.Reverse2(x);
            Assert.True(result == 987654321);
        }
    }
}
