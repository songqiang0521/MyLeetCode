using Xunit;

namespace SolutionsTests
{
    public class HappyNumberTests
    {
        [Fact]
        public void Test_1()
        {
            Solutions.HappyNumberSolution s = new Solutions.HappyNumberSolution();
            Assert.True(s.IsHappy(19));
        }
    }
}
