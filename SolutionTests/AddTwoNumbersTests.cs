using Xunit;
using Solutions;

namespace SolutionTests
{
    public class AddTwoNumbersTests
    {
        [Fact]
        public void Test_1()
        {
            //Input: (2-> 4-> 3) +(5-> 6-> 4)
            //Output: 7-> 0-> 8

            ListNode head = new ListNode(2);
            head.next = new ListNode(4);
            head.next.next = new ListNode(3);


            ListNode head2 = new ListNode(5);
            head2.next = new ListNode(6);
            head2.next.next = new ListNode(4);

            Solutions.AddTwoNumbersSolution s = new Solutions.AddTwoNumbersSolution();
            var result = s.AddTwoNumbers(head, head2);

            Assert.True(result.val == 7);
            Assert.True(result.next.val == 0);
            Assert.True(result.next.next.val == 8);
        }
    }
}
