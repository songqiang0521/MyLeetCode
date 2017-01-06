using Xunit;

namespace SolutionTests
{
    public class UglyNumberTests
    {
        [Fact]
        public void Test_1()
        {
            Solutions.UglyNumberSolution s = new Solutions.UglyNumberSolution();
            Assert.True(s.IsUgly(1));
        }
    }
}
