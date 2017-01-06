using Xunit;

namespace SolutionTests
{
    public class StringToIntegerTests
    {
        [Fact]
        public void Test_1()
        {
            Solutions.StringToIntegerSolution s = new Solutions.StringToIntegerSolution();
            Assert.True(s.MyAtoi("-123456789") == -123456789);
        }
    }
}
