using Xunit;

namespace SolutionTests
{
    public class ExcelColumnTests
    {
        [Fact]
        public void Test_1()
        {
            Solutions.ExcelColumnSolution s = new Solutions.ExcelColumnSolution();

            for (int i = 1; i < 10000; i++)
            {
                var title = s.NumberToTitle(i);
                var number = s.TitleToNumber(title);
                Assert.True(number == i);
            }
        }
    }
}
